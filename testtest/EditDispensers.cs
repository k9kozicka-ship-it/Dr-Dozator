using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; //for graphs
using MySqlConnector;

namespace testtest
{
    public partial class EditDispensers : KryptonForm
    {
        private MySqlConnection conn;
        private string connectionString = "Server=127.0.0.1;Port=3307;User=root;Password=1234;Database=sapunerkdb;SslMode=None;";

        public EditDispensers()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void EditDispensers_Load(object sender, EventArgs e)
        {
            this.Text = "Database Management";
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();

                ConfigureGrid(dispensersGridView);
                ConfigureGrid(usersGridView);
                ConfigureGrid(statsGridView);

                
                dtpStart.Value = DateTime.Now.Date; //00:00:00
                dtpEnd.Value = DateTime.Now.Date.AddDays(1).AddSeconds(-1); //23:59:59

                
                dispensersGridView.CellClick += dispensersGridView_CellClick;
                usersGridView.CellClick += usersGridView_CellClick;

                // Mask passwords
                usersGridView.CellFormatting += usersGridView_CellFormatting;

                
                dtpStart.ValueChanged += ValidateDateRange;
                dtpEnd.ValueChanged += ValidateDateRange;

                LoadDispenserData();
                LoadUserData();
                PopulateComboBoxes();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Connection error: " + ex.Message);
                this.Close();
            }
        }

        private void ValidateDateRange(object sender, EventArgs e)
        {
            // If Start Date is after End Date
            if (dtpStart.Value > dtpEnd.Value)
            {

                KryptonMessageBox.Show("The Start Date cannot be after the End Date.",
                                       "Invalid Date Range",
                                       KryptonMessageBoxButtons.OK,
                                       KryptonMessageBoxIcon.Error);

                // infinite loop def
                dtpStart.ValueChanged -= ValidateDateRange;
                dtpEnd.ValueChanged -= ValidateDateRange;

                // Reset control to match valid date
                if (sender == dtpStart)
                {
                    // If user moved start past end move start back to End
                    dtpStart.Value = dtpEnd.Value.Date;
                }
                else
                {
                    // If user moved end before start end moved to Start
                    dtpEnd.Value = dtpStart.Value.Date.AddDays(1).AddSeconds(-1);
                }


                dtpStart.ValueChanged += ValidateDateRange;
                dtpEnd.ValueChanged += ValidateDateRange;
            }
        }

        private void ConfigureGrid(KryptonDataGridView dgv)
        {
            if (dgv == null) return;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                LoadStatistics();
            }
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            try
            {
                string query = @"
                    SELECT 
                        s.Id as 'ID', 
                        COUNT(l.id) as 'Total Uses'
                    FROM sapunerki s
                    LEFT JOIN usage_logs l ON s.Id = l.dispenser_id 
                        AND l.timestamp BETWEEN @start AND @end
                    GROUP BY s.Id
                    ORDER BY s.Id ASC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@start", dtpStart.Value);
                adapter.SelectCommand.Parameters.AddWithValue("@end", dtpEnd.Value);

                DataTable statsTable = new DataTable();
                adapter.Fill(statsTable);

                if (statsGridView != null)
                {
                    statsGridView.DataSource = statsTable;
                }

                UpdateChart(statsTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load statistics: " + ex.Message);
            }
        }

        private void UpdateChart(DataTable dt)
        {
            if (usageChart == null) return;

            Color customBgColor = ColorTranslator.FromHtml("#636C87");
            usageChart.Series.Clear();
            usageChart.Titles.Clear();
            usageChart.ChartAreas[0].AxisX.Interval = 1;
            usageChart.BackColor = customBgColor;
            usageChart.ChartAreas[0].BackColor = customBgColor;

            var title = usageChart.Titles.Add($"Usage from {dtpStart.Value:dd/MM} to {dtpEnd.Value:dd/MM}");
            title.ForeColor = Color.White;
            title.Font = new Font("Segoe UI", 12, FontStyle.Bold);


            ChartArea area = usageChart.ChartAreas[0];
            area.AxisX.LabelStyle.ForeColor = Color.White;
            area.AxisX.LineColor = Color.White;
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(70, Color.White);
            area.AxisY.LabelStyle.ForeColor = Color.White;
            area.AxisY.LineColor = Color.White;
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(70, Color.White);

            Series series = new Series("Usage")
            {
                ChartType = SeriesChartType.Column,
                XValueMember = "ID",
                YValueMembers = "Total Uses",
                IsValueShownAsLabel = true
            };
            series.LabelForeColor = Color.White;
            series.Palette = ChartColorPalette.BrightPastel;

            usageChart.DataSource = dt;
            usageChart.Series.Add(series);
            usageChart.DataBind();
        }

        // ==========================================
        // DISPENSER MANAGEMENT
        // ==========================================

        private void LoadDispenserData()
        {
            try
            {
                DataTable dt = new DataTable();
                new MySqlDataAdapter("SELECT Id, User, Floor FROM sapunerki", conn).Fill(dt);
                dispensersGridView.DataSource = dt;
            }
            catch { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxUser.SelectedValue == null) return;
            ExecuteSecure("INSERT INTO sapunerki (User, 6, Floor) VALUES (@u, @f)",
                new MySqlParameter("@u", comboBoxUser.SelectedValue),
                new MySqlParameter("@f", comboBoxFloor.SelectedValue));
            LoadDispenserData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text)) return;
            ExecuteSecure("UPDATE sapunerki SET User = @u, Floor = @f WHERE Id = @id",
                new MySqlParameter("@u", comboBoxUser.SelectedValue),
                new MySqlParameter("@f", comboBoxFloor.SelectedValue),
                new MySqlParameter("@id", textBoxId.Text));
            LoadDispenserData();
            if (tabControl1.SelectedIndex == 2) LoadStatistics();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text)) return;
            // Clean logs first to maintain ID integrity
            ExecuteSecure("DELETE FROM usage_logs WHERE dispenser_id = @id", new MySqlParameter("@id", textBoxId.Text));
            ExecuteSecure("DELETE FROM sapunerki WHERE Id = @id", new MySqlParameter("@id", textBoxId.Text));
            LoadDispenserData();
            if (tabControl1.SelectedIndex == 2) LoadStatistics();
            textBoxId.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            comboBoxUser.SelectedIndex = -1;
            comboBoxFloor.SelectedIndex = -1;
        }

        private void dispensersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dispensersGridView.Rows[e.RowIndex];
                textBoxId.Text = row.Cells["Id"].Value.ToString();
                comboBoxUser.SelectedValue = row.Cells["User"].Value.ToString();
                comboBoxFloor.SelectedValue = row.Cells["Floor"].Value;
            }
        }

        // ==========================================
        // USER MANAGEMENT
        // ==========================================

        private void LoadUserData()
        {
            try
            {
                DataTable dt = new DataTable();
                new MySqlDataAdapter("SELECT Username, Password, Priority FROM users", conn).Fill(dt);
                usersGridView.DataSource = dt;
            }
            catch { }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ExecuteSecure("INSERT INTO users (Username, Password, Priority) VALUES (@u, @p, @pr)",
                new MySqlParameter("@u", textboxUsername.Text),
                new MySqlParameter("@p", textBoxPassword.Text),
                new MySqlParameter("@pr", textBoxPriority.Text));
            LoadUserData();
            PopulateComboBoxes();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            ExecuteSecure("UPDATE users SET Password=@p, Priority=@pr WHERE Username=@u",
                new MySqlParameter("@p", textBoxPassword.Text),
                new MySqlParameter("@pr", textBoxPriority.Text),
                new MySqlParameter("@u", textboxUsername.Text));
            LoadUserData();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            ExecuteSecure("DELETE FROM users WHERE Username = @u", new MySqlParameter("@u", textboxUsername.Text));
            LoadUserData();
            PopulateComboBoxes();
        }

        private void btnClearUserField_Click(object sender, EventArgs e)
        {
            textboxUsername.Clear(); textBoxPassword.Clear(); textBoxPriority.Clear();
        }

        private void usersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = usersGridView.Rows[e.RowIndex];
                textboxUsername.Text = row.Cells["Username"].Value.ToString();
                textBoxPassword.Text = row.Cells["Password"].Value.ToString();
                textBoxPriority.Text = row.Cells["Floor"].Value.ToString();
            }
        }

        private void usersGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && usersGridView.Columns[e.ColumnIndex].Name == "Password" && e.Value != null)
            {
                e.Value = new string('●', e.Value.ToString().Length);
                e.FormattingApplied = true;
            }
        }

        // ==========================================
        // HELPERS & STUBS
        // ==========================================

        private void ExecuteSecure(string sql, params MySqlParameter[] p)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(p);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void PopulateComboBoxes()
        {
            try
            {
                DataTable u = new DataTable();
                new MySqlDataAdapter("SELECT Username FROM users", conn).Fill(u);
                comboBoxUser.DataSource = u; comboBoxUser.DisplayMember = "Username"; comboBoxUser.ValueMember = "Username";

                DataTable f = new DataTable();
                new MySqlDataAdapter("SELECT DISTINCT Priority FROM users", conn).Fill(f);
                comboBoxFloor.DataSource = f; comboBoxFloor.DisplayMember = "Floor"; comboBoxFloor.ValueMember = "Floor";

                comboBoxUser.SelectedIndex = -1; comboBoxFloor.SelectedIndex = -1;
            }
            catch { }
        }

        private void kryptonLabel2_Click(object sender, EventArgs e) { }
        private void kryptonTextBox1_TextChanged(object sender, EventArgs e) { }
        private void kryptonLabel4_Click(object sender, EventArgs e) { }
        private void kryptonLabel8_Click(object sender, EventArgs e) { }

        // This triggers if you didn't rename the button in the designer
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        private void EditDatabase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn?.State == ConnectionState.Open) conn.Close();
        }
    }
}

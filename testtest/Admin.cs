using Krypton.Toolkit;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace testtest
{
    public partial class Admin : KryptonForm
    {
        private MySqlConnection conn;
        private string connectionString = "Server=127.0.0.1;Port=3307;User=root;Password=1234;Database=sapunerkdb;SslMode=None;";
        private Timer refreshTimer;

        public Admin()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            if (mainPanel != null) mainPanel.AutoScroll = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                RefreshDispenserDisplay();
                refreshTimer = new Timer { Interval = 4000 };
                refreshTimer.Tick += (s, ev) => RefreshDispenserDisplay();
                refreshTimer.Start();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void RefreshDispenserDisplay()
        {
            try
            {
                DataTable dt = new DataTable();
                using (var cmd = new MySqlCommand("SELECT Id, Distance, Floor FROM sapunerki ORDER BY Floor, Id", conn))
                using (var adp = new MySqlDataAdapter(cmd)) { adp.Fill(dt); }

                // Save Scroll Position and Reset to 0 for calculation
                Point currentScroll = mainPanel.AutoScrollPosition;
                mainPanel.AutoScrollPosition = new Point(0, 0);

                double realDist = 6.0;
                var realRow = dt.AsEnumerable().FirstOrDefault(r => r.Field<int>("Id") == 1);
                if (realRow != null) realDist = Convert.ToDouble(realRow["Distance"]);

                var existingIds = mainPanel.Controls.OfType<KryptonProgressBar>().Select(p => p.Name.Substring(1)).ToHashSet();
                int currentFloor = -1, startX = 160, currentX = startX, currentY = 20;

                foreach (DataRow row in dt.Rows)
                {
                    int id = Convert.ToInt32(row["Id"]);
                    int floor = Convert.ToInt32(row["Floor"]);
                    double dist = (id == 1) ? realDist : realDist + (new Random(id).NextDouble() * 3.0 - 1.5);

                    existingIds.Remove(id.ToString());
                    if (floor != currentFloor)
                    {
                        currentFloor = floor;
                        currentY += 90;
                        currentX = startX;
                        AddFloorHeader(floor, currentY);
                    }

                    int percent = (int)Math.Max(0, Math.Min(100, ((9.5 - dist) / 8) * 100));
                    UpdateUI(id, percent, new Point(currentX, currentY + 25));
                    currentX += 220; // Matches spacing
                }
                foreach (string id in existingIds) { RemoveControl("p" + id); RemoveControl("l" + id); }

                // Restore Scroll
                mainPanel.AutoScrollPosition = new Point(Math.Abs(currentScroll.X), Math.Abs(currentScroll.Y));
            }
            catch { }
        }

        private void UpdateUI(int id, int val, Point loc)
        {
            string pName = "p" + id, lName = "l" + id;
            KryptonProgressBar p = mainPanel.Controls[pName] as KryptonProgressBar;
            KryptonLabel l = mainPanel.Controls[lName] as KryptonLabel;

            if (p == null)
            {
                p = new KryptonProgressBar { Name = pName, Size = new Size(180, 26), Anchor = AnchorStyles.Top | AnchorStyles.Left };
                p.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
                p.StateCommon.Border.Rounding = 3;
                mainPanel.Controls.Add(p);
            }
            p.Location = loc;

            if (l == null)
            {
                l = new KryptonLabel { Name = lName, AutoSize = true, Anchor = AnchorStyles.Top | AnchorStyles.Left, LabelStyle = LabelStyle.NormalPanel };
                l.StateCommon.ShortText.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                l.StateCommon.ShortText.Color1 = Color.White;
                mainPanel.Controls.Add(l);
            }
            l.Location = new Point(loc.X, loc.Y - 28);
            l.Values.Text = $"№{id} - {val}%";
            p.Value = val;
        }

        private void AddFloorHeader(int floor, int y)
        {
            string name = "floorLabel" + floor;
            if (!mainPanel.Controls.ContainsKey(name))
            {
                var l = new KryptonLabel { Name = name, Text = $"FLOOR {floor}", Location = new Point(20, y + 15), Anchor = AnchorStyles.Top | AnchorStyles.Left, LabelStyle = LabelStyle.TitleControl, AutoSize = true };
                l.StateCommon.ShortText.Color1 = Color.White;
                mainPanel.Controls.Add(l);
            }
            else { mainPanel.Controls[name].Location = new Point(20, y + 15); }
        }

        private void RemoveControl(string name)
        {
            if (mainPanel.Controls.ContainsKey(name)) { var c = mainPanel.Controls[name]; mainPanel.Controls.Remove(c); c.Dispose(); }
        }

        // Placeholder for the Paint error
        private void mainPanel_Paint(object sender, PaintEventArgs e) { }

        protected override Point ScrollToControl(Control activeControl) { return this.AutoScrollPosition; }
        private void btnManageDatabase_Click_1(object sender, EventArgs e) { refreshTimer.Stop(); new EditDispensers().ShowDialog(); refreshTimer.Start(); }
        private void btnLogout_Click(object sender, EventArgs e) { this.Close(); }
    }
}
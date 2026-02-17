using Krypton.Toolkit;
using MySqlConnector;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace testtest
{
    public partial class NormalUser : KryptonForm
    {
        private MySqlConnection conn;
        private string connectionString = "Server=127.0.0.1;Port=3307;User=root;Password=1234;Database=sapunerkdb;SslMode=None;";

        public NormalUser() { InitializeComponent(); this.DoubleBuffered = true; mainPanel.AutoScroll = true; }

        public void SetLBLName(string n) { UserNameLbl.Text = n; }
        public void SetFloorLBL(int p) { Floor_label.Text = "Floor " + p + ":"; }

        private void NormalUser_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                timer1.Interval = 4000; timer1.Start();
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                using (var cmd = new MySqlCommand("SELECT * FROM sapunerki WHERE User = @u", conn))
                {
                    cmd.Parameters.AddWithValue("@u", UserNameLbl.Text);
                    using (var adp = new MySqlDataAdapter(cmd)) { adp.Fill(dt); }
                }

                // Save scroll and reset
                Point currentScroll = mainPanel.AutoScrollPosition;
                mainPanel.AutoScrollPosition = new Point(0, 0);

                int currentX = 80;
                int currentY = 150;

                double baseDist = 6.0;
                var baseRow = dt.AsEnumerable().FirstOrDefault(r => r.Field<int>("Id") == 1);
                if (baseRow != null) baseDist = Convert.ToDouble(baseRow["Distance"]);

                foreach (DataRow row in dt.Rows)
                {
                    int id = Convert.ToInt32(row["Id"]);
                    double dist = (id == 1) ? baseDist : baseDist + (new Random(id).NextDouble() * 2 - 1);
                    int val = (int)Math.Max(0, Math.Min(100, ((9.5 - dist) / 8) * 100));

                    string pName = "p" + id, lName = "d" + id;
                    KryptonProgressBar p = mainPanel.Controls.Find(pName, true).FirstOrDefault() as KryptonProgressBar;
                    KryptonLabel l = mainPanel.Controls.Find(lName, true).FirstOrDefault() as KryptonLabel;

                    if (p == null)
                    {
                        p = new KryptonProgressBar { Name = pName, Size = new Size(180, 26), Location = new Point(currentX, currentY), Anchor = AnchorStyles.Top | AnchorStyles.Left };
                        p.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
                        p.StateCommon.Border.Rounding = 3;

                        l = new KryptonLabel { Name = lName, Location = new Point(currentX, currentY - 28), Anchor = AnchorStyles.Top | AnchorStyles.Left, LabelStyle = LabelStyle.NormalPanel };
                        l.StateCommon.ShortText.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                        l.StateCommon.ShortText.Color1 = Color.White;
                        mainPanel.Controls.Add(p); mainPanel.Controls.Add(l);
                    }
                    else
                    {
                        p.Location = new Point(currentX, currentY);
                        l.Location = new Point(currentX, currentY - 28);
                    }

                    p.Value = val;
                    l.Values.Text = $"№{id} {val}%";
                    currentX += 220; // Match Admin spacing
                }

                // Restore scroll
                mainPanel.AutoScrollPosition = new Point(Math.Abs(currentScroll.X), Math.Abs(currentScroll.Y));
            }
            catch { }
        }

        // Placeholder for the Click error
        private void kryptonLabel2_Click(object sender, EventArgs e) { }

        protected override Point ScrollToControl(Control activeControl) { return this.AutoScrollPosition; }
    }
}   
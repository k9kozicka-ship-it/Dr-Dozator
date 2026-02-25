using Krypton.Toolkit;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testtest
{
    public partial class Admin : KryptonForm
    {
        private MySqlConnection conn;
        private string connectionString = "Server=127.0.0.1;Port=3307;User=root;Password=1234;Database=sapunerkdb;SslMode=None;";
        private Timer refreshTimer;

        // NOTIFICATION and TELEGRAM 
        private HashSet<int> notifiedDispensers = new HashSet<int>();
        private NotifyIcon appNotifyIcon;
        private static readonly HttpClient httpClient = new HttpClient();

        // Put Telegram Bot Token from @BotFather here
        private string telegramBotToken = "8691791019:AAFYJju1f0LbXhtEkbkKFAhDqpNbL-iu09c";

        //if its a GC it should have a - sign
        private string telegramChatId = "-1003854751985";

        public Admin()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            if (mainPanel != null) mainPanel.AutoScroll = true;

            // Initialize the Desktop Notification Icon
            appNotifyIcon = new NotifyIcon();
            appNotifyIcon.Icon = SystemIcons.Warning; // Uses standard Windows warning icon
            appNotifyIcon.Visible = true;
            appNotifyIcon.Text = "Dispenser Monitor";
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

        // --- METHOD TO SEND PHONE NOTIFICATION WITH HTML FORMATTING ---
        private async Task SendPhoneNotification(string message)
        {
            try
            {
                // &parse_mode=HTML supports bold (<b>), italics (<i>), and clean spacing
                string url = $"https://api.telegram.org/bot{telegramBotToken}/sendMessage?chat_id={telegramChatId}&text={Uri.EscapeDataString(message)}&parse_mode=HTML";
                await httpClient.GetAsync(url);
            }
            catch (Exception ex)
            {
                // Ignore network errors so it doesn't crash the desktop app
                Console.WriteLine("Failed to send phone notification: " + ex.Message);
            }
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

                    // NOTIFICATION LOGIC
                    if (percent < 30)
                    {
                        // Check if already notified the group for this dispenser
                        if (!notifiedDispensers.Contains(id))
                        {
                            // simple Windows Desktop Notification
                            appNotifyIcon.ShowBalloonTip(5000, "Low Dispenser Level Alert", $"Dispenser №{id} on Floor {floor} is critically low ({percent}%).", ToolTipIcon.Warning);

                            
                            string alertMsg =
                                "🚨 <b>CRITICAL LEVEL ALERT</b> 🚨\n\n" +
                                $"🏢 <b>Floor:</b> {floor}\n" +
                                $"🧴 <b>Dispenser:</b> № {id}\n" +
                                $"📉 <b>Level:</b> {percent}%\n\n" +
                                "<i>Please refill as soon as possible.</i>";

                            // Send Phone Notification via Telegram
                            _ = SendPhoneNotification(alertMsg);

                            // Mark as notified 
                            notifiedDispensers.Add(id);
                        }
                    }
                    else
                    {
                        // If it goes back above 30% (refilled), reset so it can notify again in the future
                        if (notifiedDispensers.Contains(id))
                        {
                            notifiedDispensers.Remove(id);

                            // Send a success notification to the group chat that it was fixed!
                            string refillMsg =
                                "✅ <b>DISPENSER REFILLED</b> ✅\n\n" +
                                $"🏢 <b>Floor:</b> {floor}\n" +
                                $"🧴 <b>Dispenser:</b> № {id}\n" +
                                $"🔋 <b>Current Level:</b> {percent}%\n\n" +
                                "<i>Thank you for maintaining the dispensers!</i>";

                            _ = SendPhoneNotification(refillMsg);
                        }
                    }
                

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

            // Make the label text red if below 30%
            l.StateCommon.ShortText.Color1 = (val < 30) ? Color.Salmon : Color.White;
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

     
        private void mainPanel_Paint(object sender, PaintEventArgs e) { }

        protected override Point ScrollToControl(Control activeControl) { return this.AutoScrollPosition; }

        private void btnManageDatabase_Click_1(object sender, EventArgs e)
        {
            refreshTimer.Stop();
            new EditDispensers().ShowDialog();
            refreshTimer.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clean up the notification icon so it doesn't leave a "ghost" icon in the taskbar
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (appNotifyIcon != null)
            {
                appNotifyIcon.Visible = false;
                appNotifyIcon.Dispose();
            }
            base.OnFormClosed(e);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Krypton.Toolkit;

namespace testtest
{
    public partial class LoginForm : KryptonForm
    {
        public string username;
        public string password;
        public int priority;

        public LoginForm()
        {
            InitializeComponent();
            priority = -1;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            username = kryptonTextBox1.Text;
            password = kryptonTextBox2.Text;
            MySqlCommand myCommand;
            MySqlConnection conn;
            string connectionString = "Server=127.0.0.1;Port=3307;User=root;Password=1234;Database=sapunerkdb;SslMode=None;";

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                myCommand = new MySqlCommand("SELECT * FROM users where Password = @password and Username = @username;", conn);
                myCommand.Parameters.AddWithValue("@password", password);
                myCommand.Parameters.AddWithValue("@username", username);

                using (var myReader = myCommand.ExecuteReader())
                {
                    if (myReader.Read())
                    {
                        priority = myReader.GetInt32("Priority");
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid username and password.");
                        return;
                    }
                }


                this.Hide(); // Hide Login

                if (priority == 0)
                {
                    Admin admin = new Admin();
                    admin.ShowDialog();
                }
                else
                {
                    //NormalUser form = new NormalUser();
                    //form.SetLBLName(username);
                    //form.SetFloorLBL(priority);
                    //form.ShowDialog();
                    MessageBox.Show("Please enter valid username and password.");
                    return;
                }


                kryptonTextBox1.Text = string.Empty;
                kryptonTextBox2.Text = string.Empty;
                this.Show(); // Re-show Login form when closing the dashboard
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

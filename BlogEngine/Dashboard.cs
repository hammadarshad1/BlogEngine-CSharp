using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BlogEngine
{
    public partial class Dashboard : Form
    {
        public Login login;
        public Dashboard(Login login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lgn = new Login();
            lgn.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            userLabel.Text = "Welcome, " + login.userName;
        }
        private int imagenumber = 1;
        private void AboutBtn_Click(object sender, EventArgs e)
        {
          panel2.Visible = true;
        }

        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {

            try
            {
                string content = blogtxt.Text;
                string date = dateTimePicker1.Text;
                string query = $"INSERT INTO blog (content, duration) VALUES ('" + content + "', '" + date + "')";
                MySqlConnection conn2 = new MySqlConnection("server=localhost;user id=root;database=blogengine");
                MySqlCommand command = new MySqlCommand(query, conn2);
                MySqlDataReader reader;
                conn2.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Save Data");
                while (reader.Read())
                {
                }
                conn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            blogtxt.Text = "";
        }

        private void ThemeBtn_Click(object sender, EventArgs e)
        {
            backBtn.Visible = true;
            panel2.Visible = true;
            userLabel.Text = "Write a Post!";
        }

        private void NewPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backBtn.Visible = true;
            panel2.Visible = true;
            userLabel.Text = "Write a Post!";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            backBtn.Visible = false;
            userLabel.Text = "Dashboard";
        }
    }
}

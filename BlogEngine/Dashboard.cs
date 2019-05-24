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
using System.IO;
using System.Diagnostics;

namespace BlogEngine
{
   
    public partial class Dashboard : Form
    {

        Login n = new Login();
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
        //private int imagenumber = 1;
        private void AboutBtn_Click(object sender, EventArgs e)
        {
            profilePanel.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            userLabel.Text = "About BlogEngine";
        }

        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            string content = blogtxt.Text;
            string date = dateTimePicker1.Text;
            string path = @"C:\Users\Hammad\Downloads\Compressed\BlogEngine\users post\" + login.userName + ".html";
            string html = "<html><body>" + content + "</body></html>";

            if (blogtxt.Text == "")
            {
                MessageBox.Show("This is not allowed!");
            }
            else
            {
                try
                {
                    
                    string query = $"INSERT INTO blog (content, duration) VALUES ('" + content + "', '" + date + "')";
                    MySqlConnection conn2 = new MySqlConnection("server=localhost;user id=root;database=blogengine");
                    MySqlCommand command = new MySqlCommand(query, conn2);
                    MySqlDataReader reader;
                    conn2.Open();
                    reader = command.ExecuteReader();
                    MessageBox.Show("Save Data");
                    linkLabel.Visible = true;
                    while (reader.Read())
                    {
                    }
                    conn2.Close();
                    if(!File.Exists(path))
                    {
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine("{0}--------({1})<br><hr>", html, date);
                        }
                    }
                    else
                    {
                        using (StreamWriter w = File.AppendText(path))
                        {
                            w.WriteLine("{0}--------({1})<br><hr>\n\n", html, date);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            blogtxt.Text = "";
        }

        private void ThemeBtn_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            profilePanel.Visible = false;
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
            panel3.Visible = false;
            panel2.Visible = false;
            backBtn.Visible = false;
            userLabel.Text = "Dashboard";
            profilePanel.Visible = false;
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            n.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string path = @"C:\Users\Hammad\Downloads\Compressed\BlogEngine\users post\" + login.userName + ".html";
            Process.Start(path);
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = false;
            profilePanel.Visible = true;
            userLabel.Text = "Profile";
            MySqlConnection Connection = new MySqlConnection("server=localhost;user id=root;database=blogengine");
            MySqlCommand command;
            
            MySqlDataReader mdr;

            

            Connection.Open();
            string query = "SELECT * FROM logindb WHERE User_name='" + login.userName + "'";
            command = new MySqlCommand(query, Connection);
            mdr = command.ExecuteReader();

            if(mdr.Read())
            {
                userText.Text = mdr.GetString("User_name");
                passText.Text = mdr.GetString("Password");
                emailtxt.Text = mdr.GetString("Email");
                gndrTxt.Text = mdr.GetString("Gender");
            }
            else
            {
                MessageBox.Show("no data exist");
            }
            Connection.Close();

        }

        private void ChngPassBtn_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            newpasstxt.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=blogengine");
            string query = "update logindb set Password='" + this.newpasstxt.Text + "'WHERE User_Name='"+login.userName+"';";
            connection.Open();
            
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Password Change");
                    button1.Visible = false;
                    newpasstxt.Visible = false;
                }
                else
                {
                    MessageBox.Show("Password not Change");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string content = blogtxt.Text;
            string date = dateTimePicker1.Text;
            string path = @"C:\Users\Hammad\Downloads\Compressed\BlogEngine\users post\" + login.userName + ".html";
            string html = "<html><body>" + content + "</body></html>";

            if (blogtxt.Text == "")
            {
                MessageBox.Show("This is not allowed!");
            }
            else
            {
                try
                {

                    string query = $"INSERT INTO blog (content, duration) VALUES ('" + content + "', '" + date + "')";
                    MySqlConnection conn2 = new MySqlConnection("server=localhost;user id=root;database=blogengine");
                    MySqlCommand command = new MySqlCommand(query, conn2);
                    MySqlDataReader reader;
                    conn2.Open();
                    reader = command.ExecuteReader();
                    MessageBox.Show("Save Data");
                    linkLabel.Visible = true;
                    while (reader.Read())
                    {
                    }
                    conn2.Close();
                    if (!File.Exists(path))
                    {
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine("{0}--------({1})<br><hr>", html, date);
                        }
                    }
                    else
                    {
                        using (StreamWriter w = File.AppendText(path))
                        {
                            w.WriteLine("{0}--------({1})<br><hr>\n\n", html, date);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            blogtxt.Text = "";
        }
    }
}

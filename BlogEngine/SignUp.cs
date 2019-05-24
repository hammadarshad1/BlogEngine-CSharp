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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void userTextBox_Enter(object sender, EventArgs e)
        {
            if(userTextBox.Text == "User Name")
            {
                userTextBox.Text = "";
                userTextBox.ForeColor = Color.Black;
            }
        }

        private void userTextBox_Leave(object sender, EventArgs e)
        {
            if (userTextBox.Text == "")
            {
                userTextBox.Text = "User Name";
                userTextBox.ForeColor = Color.Silver;
            }
        }

        private void passTextBox_Enter(object sender, EventArgs e)
        {
            if(passTextBox.Text == "PASSWORD")
            {
                passTextBox.Text = "";
                passTextBox.ForeColor = Color.Black;
            }
        }

        private void passTextBox_Leave(object sender, EventArgs e)
        {
            if (passTextBox.Text == "")
            {
                passTextBox.Text = "PASSWORD";
                passTextBox.ForeColor = Color.Silver;
            }
        }

        private void EmailTextBox_Enter(object sender, EventArgs e)
        {
            if (EmailTextBox.Text == "someone@email.com")
            {
                EmailTextBox.Text = "";
                EmailTextBox.ForeColor = Color.Black;
            }
        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            if (EmailTextBox.Text == "")
            {
                EmailTextBox.Text = "someone@email.com";
                EmailTextBox.ForeColor = Color.Silver;
            }
        }

        private void genderComboBox_Enter(object sender, EventArgs e)
        {
            if(genderComboBox.Text == "Gender")
            {
                genderComboBox.Text = "";
                genderComboBox.ForeColor = Color.Black;
            }
        }

        private void genderComboBox_Leave(object sender, EventArgs e)
        {
            if (genderComboBox.Text == "")
            {
                genderComboBox.Text = "Gender";
                genderComboBox.ForeColor = Color.Silver;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                string user = userTextBox.Text;
                string password = passTextBox.Text;
                string email = EmailTextBox.Text;
                string gender = genderComboBox.Text;

                string query = $"INSERT INTO logindb (User_name, Password, Email, Gender) VALUES ('" + userTextBox.Text + "', '" + passTextBox.Text + "', '" + EmailTextBox.Text + "', '" + genderComboBox.Text + "')";
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

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login m = new Login();
            m.Show();

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }


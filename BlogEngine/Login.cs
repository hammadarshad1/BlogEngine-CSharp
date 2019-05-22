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
using System.Threading;

namespace BlogEngine
{
    
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
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
        //form to form
        public string setUserValue;
        public string userName;
        private void loginButton_Click(object sender, EventArgs e)
        {
            userName = userTextBox.Text;
            string password = passTextBox.Text;
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=blogengine");
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from logindb where User_name = '"+userTextBox.Text+"' and Password = '"+passTextBox.Text+"'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                var userdash = new Dashboard(this);
                userdash.Show();
                setUserValue = userTextBox.Text;
            }
            else
            {
                MessageBox.Show("Wrong User or Password","alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void signupButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            SignUp sign = new SignUp();
            sign.Show();
        }


        private void PictureBox4_Click(object sender, EventArgs e)
        {
            
        }
       
    }
}

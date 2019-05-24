using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogEngine
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        Timer time;
        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            time = new Timer();
            time.Interval = 7000;
            time.Start();
            time.Tick += Time_Tick;
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            time.Stop();
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}

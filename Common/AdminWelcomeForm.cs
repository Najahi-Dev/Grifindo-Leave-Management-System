using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Sample_LMS.Common
{
    public partial class AdminWelcomeForm : Form
    {
        public string username = "";

        public AdminWelcomeForm(string user)
        {
            InitializeComponent();
            lblname.Text = user;
            username = user;
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bunifuProgressBar1.Value < 100)
            {
                bunifuProgressBar1.Value += 1;

                lblpercent.Text = bunifuProgressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                AdminNav nav = new AdminNav(username);
                nav.Show();
                this.Close();
            }
        }
    }
}

using Grifindo_Sample_LMS.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Grifindo_Sample_LMS.Common
{
    public partial class EmployeeWelcomeForm : Form
    {
        public string username = "";

        public EmployeeWelcomeForm(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void EmployeeWelcomeForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblname.Text = username;
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
                EmployeeNav nav = new EmployeeNav(username);
                nav.Show();
                this.Close();
            }
        }
    }
}

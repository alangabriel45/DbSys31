using hotelReservation.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelReservation
{
    public partial class Form1 : Form
    {    
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLoginReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lgn = new Login();
            lgn.ShowDialog();
            
        }

        private void btnLoginReg_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(btnLoginReg, "Log In/Sign Up");
        }
    }
}

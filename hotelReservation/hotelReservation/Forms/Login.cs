using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelReservation.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnNewAcc_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnNewAcc, "Create new account");
        }

        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmReg reg = new FrmReg();
            reg.ShowDialog();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(pictureBox2, "Close");
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(pictureBox3, "Minimize");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

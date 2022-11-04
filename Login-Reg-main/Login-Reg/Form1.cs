using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Reg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //panel_reg1.Visible = false;
            //panel_login.BringToFront();
            panel_reg1.SendToBack();
            panelloginBar.BackColor = Color.Yellow;
            panelReg_bar.BackColor = select_color;
            panelReg_bar.Visible = false;
        }
        Color select_color = Color.FromArgb(49, 46, 46);
        private void button_GoToLogin_Click(object sender, EventArgs e)
        {
            //panel_login.BringToFront();
            /*panel_login.Visible = true;
            panel_reg1.Visible = false;*/
            //panel_Registration.Visible = false;
            panel_reg1.SendToBack();
            panel_login.BringToFront();
            panelloginBar.BackColor = Color.Yellow;
            //panelReg_bar.BackColor = select_color;
            panelReg_bar.Visible = false;
            panelloginBar.Visible = true;
            button_GoToLogin.BackColor = select_color;
            button_GoToRegistration.BackColor = Color.Black;
            //MessageBox.Show("It Clicks");
        }

        private void button_GoToRegistration_Click(object sender, EventArgs e)
        {
            //panel_Registration.BringToFront();
            //panel_reg1.BringToFront();
            /*panel_login.Visible = false;
            panel_reg1.Visible = true;*/
            //panel_Registration.Visible = true;
            panel_reg1.BringToFront();
            panel_login.SendToBack();
            panelReg_bar.BackColor = Color.Yellow;
            panelloginBar.BackColor = select_color;
            button_GoToLogin.BackColor = Color.Black;
            button_GoToRegistration.BackColor = select_color;
            panelReg_bar.Visible = true;
            panelloginBar.Visible = false;
            //MessageBox.Show("It Clicks");
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_Registration_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It Clicks");
        }

        private void panel_reg1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_reg1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }

        private void panel_login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelloginBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelReg_bar_Click(object sender, EventArgs e)
        {

        }
    }
}

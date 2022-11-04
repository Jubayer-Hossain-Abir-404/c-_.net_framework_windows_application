using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProjectCRUDTAB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);

            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Home());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new New());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new List());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new Settings());
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "CRUD-PROJECT";
            notifyIcon1.BalloonTipText = "CRUD-PROJECT";
            notifyIcon1.Text = "CRUD-PROJECT";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
           
            
                
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mainpanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadform(new Home());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            loadform(new New());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            loadform(new List());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            loadform(new Settings());
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void TopBar_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}

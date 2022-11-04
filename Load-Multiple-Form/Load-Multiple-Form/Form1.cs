using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Load_Multiple_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void loadform(object Form)
        {
            if(this.main_panel.Controls.Count > 0)
            {
                this.main_panel.Controls.RemoveAt(0);

            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(f);
            this.main_panel.Tag = f;
            f.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new dashboard_Form());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new menu1_Form());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new menu2_Form());
        }
    }
}

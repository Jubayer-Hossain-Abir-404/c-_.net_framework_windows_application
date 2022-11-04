using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstLoadingAnimation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadLabel.Parent = pictureBox1 ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Hide();  // this will hide the loading screen
            Form2 form = new Form2(); 
            form.ShowDialog();
            Close(); //this would close the loading screen
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

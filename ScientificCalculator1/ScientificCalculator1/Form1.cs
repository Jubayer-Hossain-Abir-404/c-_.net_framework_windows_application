using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Clear();
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if(!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
                
            }
            else
            {
                textBox.Text += button.Text;
            }

        }
    }
}

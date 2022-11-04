using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SOFTWARE
{
    public partial class receive : Form
    {
        public receive()
        {
            InitializeComponent();
        }

        public receive(decimal Total)
        {
            this.TotalAmount = Total;
            InitializeComponent();
        }

        decimal TotalAmount = 0;
        decimal BalanceAmount = 0;
        private const int CS_DROPSHADOW = 0x00020000;
        public string numberRole = "MONEY";

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void receive_Load(object sender, EventArgs e)
        {
            label_Amount.Text = TotalAmount.ToString();
            textAmount.Select();
        }

        private void MakeAmount(string amountTxt)
        {
            decimal Change;
            textAmount.Text = textAmount.Text + amountTxt;
            if (textAmount.Text.Length == 1)
            {
                textAmount.Text = "0.0" + textAmount.Text;
            }
            if (textAmount.Text.Length > 4)
            {
                Change = Convert.ToDecimal(textAmount.Text) * 10;
                textAmount.Text = Change.ToString("G29");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numberRole == "DIGITS")
            {
                textAmount.Text = textAmount.Text + "1";
            }
            else
            {
                MakeAmount(button1.Text);
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numberRole == "DIGITS")
            {
                textAmount.Text = textAmount.Text + "2";
            }
            else
            {
                MakeAmount(button2.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (numberRole == "DIGITS")
            {
                textAmount.Text = textAmount.Text + "3";
            }
            else
            {
                MakeAmount(button3.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (numberRole == "DIGITS")
            {
                textAmount.Text = textAmount.Text + "4";
            }
            else
            {
                MakeAmount(button4.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (numberRole == "DIGITS")
            {
                textAmount.Text = textAmount.Text + "5";
            }
            else
            {
                MakeAmount(button5.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (numberRole == "DIGITS")
            {
                textAmount.Text = textAmount.Text + "6";
            }
            else
            {
                MakeAmount(button6.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (numberRole == "DIGITS")
            {
                textAmount.Text = textAmount.Text + "7";
            }
            else
            {
                MakeAmount(button7.Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (numberRole == "DIGITS")
            {
                textAmount.Text = textAmount.Text + "8";
            }
            else
            {
                MakeAmount(button8.Text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (numberRole == "DIGITS")
            {
                textAmount.Text = textAmount.Text + "9";
            }
            else
            {
                MakeAmount(button9.Text);
            }
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textAmount.Clear();
            textAmount.Select();
        }
    }
}

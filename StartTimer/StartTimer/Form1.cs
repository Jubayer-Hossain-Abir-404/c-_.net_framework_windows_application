using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartTimer
{
    public partial class Form1 : Form
    {
        int timeCs, timeSec, timeMin;
        bool isActive;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeCs++;
                if (timeCs >= 100) //means that 1 second has passed
                {
                    timeSec++;
                    timeCs = 0; //time in centy seconds is zero

                    if (timeSec >= 60)
                    {
                        timeMin++;
                        timeSec = 0;
                    }
                }
            }

            DrawTime();

        }
        private void DrawTime()
        {
            label2.Text = String.Format("{0:00}", timeCs);
            label3.Text = String.Format("{0:00}", timeSec);
            label1.Text = String.Format("{0:00}", timeMin);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isActive = false;

            ResetTime();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        

        private void ResetTime()
        {
            timeCs = 0;
            timeSec = 0;
            timeMin = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTime();

            isActive = false;
        }
    }
}

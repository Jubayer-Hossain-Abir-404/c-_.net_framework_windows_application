using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\dbFormLogin1.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sqa = new SqlDataAdapter("SELECT count(*) FROM TblLogin WHERE UserName ='" + textUserName.Text + "' and Password = '"+textPassword.Text+"'", con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);

            if(dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MainMenu main = new MainMenu();
                main.Show();
            }
            else
            {
                MessageBox.Show("Username/Password is incorrect. Please try again!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

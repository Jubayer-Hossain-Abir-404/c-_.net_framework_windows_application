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

namespace NewProjectCRUDTAB
{
    public partial class New : Form
    {
        public New()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP-ProBook\Documents\CRUD_Table2.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("INSERT INTO CRUD_Table2 (Username, Password,Site) values ( '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Success");
            
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
            
            
            //textBox2.Focus();

            this.ActiveControl = textBox2;
            con.Close();
        }

        private void New_Load(object sender, EventArgs e)
        {
            
            
            //textBox2.Focus();

            this.ActiveControl = textBox2;


        }
    }
}

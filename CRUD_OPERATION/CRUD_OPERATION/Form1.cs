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

namespace CRUD_OPERATION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BindData();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP-ProBook\Documents\CRUD_Table1.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand command = new SqlCommand("INSERT INTO CRUD_Table values ('"+int.Parse(textBox3.Text)+"', '"+ textBox1.Text + "', '" + textBox2.Text + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Success");
            con.Close();
            BindData();

        }

        void BindData()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CRUD_Table", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("UPDATE CRUD_Table SET Username = '"+textBox1.Text+ "', Password = '" + textBox2.Text + "' WHERE Id='"+ int.Parse(textBox3.Text) +"'", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Upadated");
            con.Close();
            
            BindData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox3.Text != "") { 
            con.Open();
            SqlCommand command = new SqlCommand("DELETE CRUD_Table WHERE Id= '" + int.Parse(textBox3.Text) + "' ",con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted");
            BindData();
            }
            else
            {
                MessageBox.Show("Put Product ID");
            }
        }
    }
}

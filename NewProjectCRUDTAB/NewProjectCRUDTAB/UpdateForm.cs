using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NewProjectCRUDTAB
{
    public partial class UpdateForm : Form
    {
        int Id1; string Username1, Password1, Site1;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP-ProBook\Documents\CRUD_Table2.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Id1 = Convert.ToInt32(textBox1.Text);
            Username1 = textBox2.Text;
            Password1 = textBox3.Text;
            Site1 = textBox4.Text;
            con.Open();
            SqlCommand command = new SqlCommand("UPDATE CRUD_Table2 SET Username = '" + Username1+ "', Password = '" + Password1 + "', Site = '" + Site1 + "' WHERE Id='" + Id1 + "'", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Upadated");
            con.Close();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public UpdateForm(int Id, string Username, string Password, string Site)
        {
            InitializeComponent();
            Id1 = Id;
            Username1 = Username;
            Password1 = Password;
            Site1 = Site;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            //textBox1.Text = Id1.ToString();
            textBox2.Text = Username1;
            textBox3.Text = Password1;
            textBox4.Text = Site1;
        }
    }
}

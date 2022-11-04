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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP-ProBook\Documents\CRUD_Table2.mdf;Integrated Security=True;Connect Timeout=30");


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void List_Load(object sender, EventArgs e)
        {
            
        }

        private void Getdatafromtable()
        {


            SqlCommand command = new SqlCommand("SELECT * FROM CRUD_Table2", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void List_Load_1(object sender, EventArgs e)
        {
            Getdatafromtable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult confirm = MessageBox.Show("Are you Sure you want to delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {

                    int Id;
                    Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IDColumn"].Value);
                    //MessageBox.Show(Id.ToString());
                    con.Open();
                    SqlCommand command = new SqlCommand("DELETE CRUD_Table2 WHERE Id= '" + Id + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Deleted");
                    Getdatafromtable();
                }

            }
            //code for update
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                int Id;
                string Username, Password, Site;
                Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IDColumn"].Value);
                Username = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["NameColumn"].Value);
                Password = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["PasswordColumn"].Value);
                Site = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["SiteColumn"].Value);
                UpdateForm updateform = new UpdateForm(Id, Username, Password, Site);
                updateform.ShowDialog();
                Getdatafromtable();

            }
        }
    }
}

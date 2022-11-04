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
using Microsoft.Win32;
using OfficeOpenXml;

namespace CRUD_CELL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BindData();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP-ProBook\Documents\CRUD_Table2.mdf;Integrated Security=True;Connect Timeout=30");

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e) //insert button
        {
            con.Open();
            SqlCommand command = new SqlCommand("INSERT INTO CRUD_Table2 values ('" + int.Parse(textBox1.Text) + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Success");
            con.Close();
            BindData();
        }

        void BindData()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CRUD_Table2", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void button2_Click(object sender, EventArgs e) //update button
        {
            con.Open();
            SqlCommand command = new SqlCommand("UPDATE CRUD_Table2 SET Username = '" + textBox2.Text + "', Password = '" + textBox3.Text + "', Site = '" + textBox4.Text + "' WHERE Id='" + int.Parse(textBox1.Text) + "'", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Upadated");
            con.Close();

            BindData();
        }

        private void button3_Click(object sender, EventArgs e) //delete button
        {
            if (textBox1.Text != "")
            {
                con.Open();
                SqlCommand command = new SqlCommand("DELETE CRUD_Table2 WHERE Id= '" + int.Parse(textBox1.Text) + "' ", con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted");
                BindData();
            }
            else
            {
                MessageBox.Show("Put ID");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //This is just my cellclick event
        {
            dataGridView1.CurrentRow.Selected = true;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Username"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["Site"].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e) // button for setup 
        {
            //With this the registarion key is created in the given directory link
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\MICROSOFT\\Windows\\CurrentVersion\\Run", true);
            
            //My application will be created and valyue will be set. and by the side the directory link will show the application exe file
            reg.SetValue("My application", Application.ExecutablePath.ToString());
            // This is just a messagebox 
            MessageBox.Show("You have been successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e) // button for remove
        {
            //With this the registarion key is created in the given directory link
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\MICROSOFT\\Windows\\CurrentVersion\\Run", true);
            //Here the link will be deleted
            reg.DeleteValue("My application", false);
            MessageBox.Show("You have been successfully removed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectAll();
            DataObject copydata = dataGridView1.GetClipboardContent();
            if(copydata != null)
            {
                Clipboard.SetDataObject(copydata);
                Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
                xlapp.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook xlwbook ;
                Microsoft.Office.Interop.Excel.Worksheet xlsheet;
                object miseddata = System.Reflection.Missing.Value;
                xlwbook = xlapp.Workbooks.Add(miseddata);

                xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlwbook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
                xlr.Select();

                xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);


            }
        }
    }
}

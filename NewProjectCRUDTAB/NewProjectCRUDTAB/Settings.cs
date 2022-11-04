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

namespace NewProjectCRUDTAB
{
    public partial class Settings : Form
    {
        
        public Settings()
        {
            InitializeComponent();
            
            int id = 1;
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Table_Check WHERE Id='" + id + "'", con);
            //SqlDataAdapter sd = new SqlDataAdapter(command);
            var sd = command.ExecuteReader();
            //var queryResult = command.ExecuteScalar();
            if (sd.HasRows)
            {
                sd.Read();
                string checkYN = sd["check_t"].ToString();
                con.Close();
                if (checkYN == "1")
                {
                    radioButton1.Checked = true;
                    con.Close();
                }
                else if (checkYN == "0")
                {
                    radioButton2.Checked = true;
                    con.Close();
                }
            }
            con.Close();


        }
        int button_check = 0;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP-ProBook\Documents\CRUD_Table2.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void button1_Click(object sender, EventArgs e)
        {
            rdlc_report RDLC = new rdlc_report();
            RDLC.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            //With this the registarion key is created in the given directory link
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\MICROSOFT\\Windows\\CurrentVersion\\Run", true);

            //My application will be created and valyue will be set. and by the side the directory link will show the application exe file
            reg.SetValue("CRUD-PROJECT", Application.ExecutablePath.ToString());
            // This is just a messagebox 

            //MessageBox.Show("Path has been successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Controls.Clear();
            //this.InitializeComponent();
            int id = 1;
            button_check = 1;
            con.Open();
            SqlCommand command = new SqlCommand("UPDATE Table_Check SET check_t = '" + button_check + "'  WHERE Id='" + id + "'", con);
            command.ExecuteNonQuery();
            //MessageBox.Show("Upadated");
            con.Close();
            //MessageBox.Show("Success");



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //With this the registarion key is created in the given directory link
           RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\MICROSOFT\\Windows\\CurrentVersion\\Run", true);
            //Here the link will be deleted
            reg.DeleteValue("CRUD-PROJECT", false);

            //MessageBox.Show("Path has been successfully removed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Controls.Clear();
            //this.InitializeComponent();
            int id = 1;
            button_check = 0;
            con.Open();
            SqlCommand command = new SqlCommand("UPDATE Table_Check SET check_t = '" + button_check + "'  WHERE Id='" + id + "'", con);
            command.ExecuteNonQuery();
            //MessageBox.Show("Upadated");
            con.Close();

        }

        

        private void Settings_Load(object sender, EventArgs e)
        {
            ///
            int id = 1;
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Table_Check WHERE Id='" + id + "'", con);
            //SqlDataAdapter sd = new SqlDataAdapter(command);
            var sd = command.ExecuteReader();
            //var queryResult = command.ExecuteScalar();
            if (sd.HasRows)
            {
                sd.Read();
                string checkYN = sd["check_t"].ToString();
                con.Close();
                if (checkYN == "1")
                {
                    radioButton1.Checked = true;
                    con.Close();
                }
                else if (checkYN == "0")
                {
                    radioButton2.Checked = true;
                    con.Close();
                }
            }
            con.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

using POS_SOFTWARE.Data_Access_Logic;
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

namespace POS_SOFTWARE
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            textPassword.PasswordChar = '•';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static int LoginUserId = 0;
        private void button_login_Click(object sender, EventArgs e)
        {
            if(textUsername.Text!="" && textPassword.Text != "")
            {
                DataTable dt = new DataTable();
                dt = DBAccess.FillDataTable("SELECT * FROM user_tbl WHERE UserName ='"+textUsername.Text.Trim() +"' AND Password = '"+textPassword.Text.Trim() +"' AND IsActive= 1",dt);
                if (dt!=null && dt.Rows.Count>0)
                {
                    
                    try
                    {
                        string Qry = "SELECT * FROM user_tbl WHERE UserName ='" + textUsername.Text.Trim() + "' AND Password = '" + textPassword.Text.Trim() + "' AND IsActive= 1";
                        SqlDataReader dr = DBAccess.ExecuteReader(Qry);

                        while (dr.Read())
                        {
                            
                            LoginUserId = Convert.ToInt32(dr["Id"]);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception : " + ex);
                    }
                    MainWindow mainwin = new MainWindow();
                    mainwin.ShowDialog();
                    //MessageBox.Show("Congrats, Login Successfull", "POS Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Username or Password Incorrect!", "POS Software", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show("Please enter Username or Password", "POS Software", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            textUsername.Text = "Admin";
            textPassword.Text = "1234";
        }
    }
}

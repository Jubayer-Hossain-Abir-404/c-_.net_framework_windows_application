using POS_SOFTWARE.Data_Access_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SOFTWARE
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        string conn = DBAccess.ConnectionString;
        DataRow dr;
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GetState()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand command = new SqlCommand("SELECT Id, StateName from state_tbl", connection))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        dr = dt.NewRow();
                        dr.ItemArray = new object[] { "0", "--Select--" };
                        dt.Rows.InsertAt(dr, 0);

                        ddlState.ValueMember = "Id";
                        ddlState.DisplayMember = "StateName";
                        ddlState.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }

        public void GetCity(int stateId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand command = new SqlCommand("SELECT Id,CityName from city_tbl where StateId='" + stateId + "'", connection))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        dr = dt.NewRow();
                        dr.ItemArray = new object[] { "0", "--Select--" };
                        dt.Rows.InsertAt(dr, 0);

                        ddlCity.ValueMember = "Id";
                        ddlCity.DisplayMember = "CityName";
                        ddlCity.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }

        private void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void ClearText()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPin.Clear();
            ddlState.SelectedValue = 0;
            ddlCity.SelectedValue = 0;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text != "" && txtMobile.Text != "" && txtAddress.Text != "" && txtEmail.Text != "")
                {
                    if (ddlCustomer.SelectedIndex > 0 && chkupdate.Checked)
                    {
                        string qry = "Update customer_tbl Set FirstName='" + txtFirstName.Text.Trim() + "',LastName='" + txtLastName.Text.Trim()
                            + "',MobileNo='" + txtMobile.Text.Trim() + "',Email='" + txtEmail.Text.Trim() + "',StateId=" + ddlState.SelectedIndex
                            + ",CityId=" + ddlCity.SelectedIndex + ",Address='" + txtAddress.Text.Trim() + "',PinCode='" + txtPin.Text.Trim()
                            + "' Where Id=" + ddlCustomer.SelectedValue + "";
                        bool success = DBAccess.ExecuteQuery(qry);
                        if (success)
                        {
                            MessageBox.Show("Congrats! Customer Updated Successfully.", "POS Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearText();
                            return;
                        }
                    }
                    else
                    {

                        int StateID = Convert.ToInt32(ddlState.SelectedValue.ToString());
                        int CityID = Convert.ToInt32(ddlCity.SelectedValue.ToString());

                        string qry = "INSERT INTO customer_tbl(FirstName, LastName, StateId, CityId, MobileNo, Email, Address, PinCode,RegDate) " +
                            "VALUES('" + txtFirstName.Text.Trim() + "', '" + txtLastName.Text.Trim() + "', '"
                            + StateID + "', '" + CityID + "', '" + txtMobile.Text.Trim() + "', '" + txtEmail.Text.Trim() + "', '"
                            + txtAddress.Text.Trim() + "', '" + txtPin.Text.Trim() + "', '" + DateTime.Now + "')";

                        bool success = DBAccess.ExecuteInsertQuery(qry);

                        if (success)
                        {
                            MessageBox.Show("Customer Data Inserted Successfully.", "POS SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearText();
                        }
                        else
                        {
                            MessageBox.Show("Customer Insertion Failed.", "POS SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                   
                    }
                }
                else
                {
                    MessageBox.Show("Mandatory Fields Can not be Empty.", "POS SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }

        private void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlState.SelectedValue.ToString() != null)
                {
                    int StateID = Convert.ToInt32(ddlState.SelectedValue.ToString());
                    if (StateID > 0)
                    {
                        GetCity(StateID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            GetState();
            GetCustomer();
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            EmailValidation();
        }

        void EmailValidation()
        {
            if (txtEmail.Text.Length > 0)
            {
                Regex RegxEmail = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if (!RegxEmail.IsMatch(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Email is not valid, Please provide a valid email.", "POS Software", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }
            }
        }

        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        public void GetCustomer()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand command = new SqlCommand("SELECT Id, FirstName from customer_tbl ", connection))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        dr = dt.NewRow();
                        dr.ItemArray = new object[] { "0", "--Select--" };
                        dt.Rows.InsertAt(dr, 0);

                        ddlCustomer.ValueMember = "Id";
                        ddlCustomer.DisplayMember = "FirstName";
                        ddlCustomer.DataSource = dt;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }

        void GetCustomerDetail(int id)
        {
            try
            {
                string Qry = "Select * from customer_tbl where Id=" + id + "";
                SqlDataReader dr = DBAccess.ExecuteReader(Qry);

                while (dr.Read())
                {
                    //FirstName, LastName, Email, MobileNo, StateId, CityId,Address,PinCode
                    txtFirstName.Text = dr["FirstName"].ToString();
                    txtLastName.Text = dr["LastName"].ToString();
                    txtEmail.Text = dr["Email"].ToString();
                    txtMobile.Text = dr["MobileNo"].ToString();
                    txtAddress.Text = dr["Address"].ToString();
                    ddlState.SelectedValue = Convert.ToInt32(dr["StateId"]);
                    ddlCity.SelectedValue = Convert.ToInt32(dr["CityId"]);
                    txtPin.Text = dr["PinCode"].ToString();

                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }
        
        private void chkupdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkupdate.Checked)
            {
                ddlCustomer.Enabled = true;
                if(Convert.ToInt32(ddlCustomer.SelectedValue)>0)
                {
                    int CustId = Convert.ToInt32(ddlCustomer.SelectedValue);
                    GetCustomerDetail(CustId);
                }
            }
            else
            {
                ddlCustomer.Enabled = false;
                ddlCustomer.SelectedIndex = 0;
            }
        }

        private void ddlCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CustId = Convert.ToInt32(ddlCustomer.SelectedValue);
            if(CustId > 0)
            {
                GetCustomerDetail(CustId);
            }
            else
            {
                ddlCustomer.SelectedValue = 0;
                ClearText();
               
            }
        }
    }
}

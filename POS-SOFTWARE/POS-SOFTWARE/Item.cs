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
    public partial class Item : Form
    {
        public Item()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Item_Load(object sender, EventArgs e)
        {
            GetDepartment();
            GetTax();
            //GetCategory();
        }
        string conn = DBAccess.ConnectionString;
        DataRow dr;
        public void GetDepartment()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand command = new SqlCommand("select Id, DeptName from dept_tbl", connection))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dr = dt.NewRow();
                        dr.ItemArray = new object[] { 0, "--Select--" };
                        dt.Rows.InsertAt(dr, 0);
                        ddlDepartment.ValueMember = "Id";
                        ddlDepartment.DisplayMember = "DeptName";
                        ddlDepartment.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }
        public void GetTax()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand command = new SqlCommand("SELECT Id, Name from tax_tbl", connection))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        dr = dt.NewRow();
                        dr.ItemArray = new object[] { "0", "--Select--" };
                        dt.Rows.InsertAt(dr, 0);

                        ddlTax.ValueMember = "Id";
                        ddlTax.DisplayMember = "Name";
                        ddlTax.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }
        public void GetCategory(int deptId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand command = new SqlCommand("SELECT Id,Category from category_tbl where DeptId='" + deptId + "'", connection))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        dr = dt.NewRow();
                        dr.ItemArray = new object[] { "0", "--Select--" };
                        dt.Rows.InsertAt(dr, 0);

                        ddlCategory.ValueMember = "Id";
                        ddlCategory.DisplayMember = "Category";
                        ddlCategory.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }

        private void ddlDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlDepartment.SelectedValue.ToString() != null)
                {
                    int departmentID = Convert.ToInt32(ddlDepartment.SelectedValue.ToString());
                    if (departmentID > 0)
                    {
                        GetCategory(departmentID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int DeptID = Convert.ToInt32(ddlDepartment.SelectedValue.ToString());
                int CateID = Convert.ToInt32(ddlCategory.SelectedValue.ToString());
                int TaxID = Convert.ToInt32(ddlTax.SelectedValue.ToString());

                string qry = "INSERT INTO item_tbl(LookupCode, ItemName, DeptId, CateId, Cost, Price, Quantity, UOM, Weight, TaxId, IsDiscountItem,EntryDate) " +
                    "VALUES('" + txtLookup.Text.Trim() + "', '" + txtName.Text.Trim() + "', '"
                    + DeptID + "', '" + CateID + "', '" + txtCost.Text.Trim() + "', '" + txtPrice.Text.Trim() + "', '"
                    + txtQty.Text.Trim() + "', '" + txtUOM.Text.Trim() + "', '" + txtWeight.Text.Trim() + "', '" + TaxID + "', '"
                    + chkDiscount.Checked + "','" + DateTime.Now + "')";

                bool success = DBAccess.ExecuteInsertQuery(qry);

                if (success)
                {
                    MessageBox.Show("Item Inserted Successfully.", "POS SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Item Inserted Failed.", "POS SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }
        void ClearText()
        {
            txtLookup.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            txtUOM.Clear();
            txtWeight.Clear();
            txtCost.Clear();
            ddlDepartment.SelectedIndex = 0;
            ddlCategory.SelectedIndex = 0;
            ddlTax.SelectedIndex = 0;
            chkDiscount.Checked = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int DeptID = Convert.ToInt32(ddlDepartment.SelectedValue.ToString());
                int CateID = Convert.ToInt32(ddlCategory.SelectedValue.ToString());
                int TaxID = Convert.ToInt32(ddlTax.SelectedValue.ToString());

                string qry = "INSERT INTO item_tbl(LookupCode, ItemName, DeptId, CateId, Cost, Price, Quantity, UOM, Weight, TaxId, IsDiscountItem,EntryDate) " +
                    "VALUES('" + txtLookup.Text.Trim() + "', '" + txtName.Text.Trim() + "', '" 
                    + DeptID + "', '" + CateID + "', '" + txtCost.Text.Trim() + "', '" + txtPrice.Text.Trim() + "', '" 
                    + txtQty.Text.Trim() + "', '" + txtUOM.Text.Trim() + "', '" + txtWeight.Text.Trim() + "', '" + TaxID + "', '" 
                    + chkDiscount.Checked + "','" + DateTime.Now + "')";

                bool success = DBAccess.ExecuteInsertQuery(qry);

                if (success)
                {
                    MessageBox.Show("Item Inserted Successfully.", "POS SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Item Inserted Failed.", "POS SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}

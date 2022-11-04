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
//using static POS_SOFTWARE.Entities.custom_list;
using POS_SOFTWARE.Entities;

namespace POS_SOFTWARE
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string conn = DBAccess.ConnectionString;
        DataRow dr;
        int UserID = loginForm.LoginUserId;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void button_new_Click(object sender, EventArgs e)
        {
            panelItems.Visible = true;
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            panelItems.Visible = false;
            GetItemList();
            BindDLL();
            GetMaxInvoiceID();
            button_pay.Enabled = false;
        }
        List<custom_list.Item> itemList = new List<custom_list.Item>();
        public void GetItemList()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    
                    using (SqlCommand command = new SqlCommand("Select Id, ItemName, LookupCode, DeptId, CateId, Cost, Price, Quantity, UOM, Weight, TaxId, IsDiscountItem, 0 as Action from item_tbl Where Quantity>0", connection))
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        SqlDataReader reader = command.ExecuteReader();
                        while(reader.Read())
                        {
                            custom_list.Item objItem = new custom_list.Item();
                            objItem.Id = Convert.ToInt32(reader["Id"]);
                            objItem.ItemName = Convert.ToString(reader["ItemName"]);
                            objItem.LookupCode = Convert.ToString(reader["LookupCode"]);
                            objItem.DepartmentI = Convert.ToString(reader["DeptId"]);
                            objItem.CategoryI = Convert.ToString(reader["CateId"]);
                            objItem.Price = Convert.ToDecimal(reader["Price"]);
                            objItem.Quantity = Convert.ToInt32(reader["Quantity"]);
                            objItem.UOM = Convert.ToString(reader["UOM"]);
                            objItem.Weight = Convert.ToDecimal(reader["Weight"]);
                            objItem.Tax = 0.0M;
                            objItem.TaxId = Convert.ToInt32(reader["TaxId"]);
                            objItem.Discount = Convert.ToBoolean(reader["IsDiscountItem"]);
                            objItem.Action = Convert.ToBoolean(reader["Action"]);

                            itemList.Add(objItem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        Item objItem = new Item();
        private void button_items_Click(object sender, EventArgs e)
        {
            //Item objItem = new Item();
            //objItem.Show();
            objItem = new Item();
            objItem.Show(this);
        }

        private void button_customers_Click(object sender, EventArgs e)
        {
            Customer objCustomer = new Customer();
            objCustomer.Show(this);
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button_pay_Click(object sender, EventArgs e)
        {

        }

        int MaxId = 0;
        int InsertedInvId = 0;
        void GetMaxInvoiceID()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand("Select Max(Id) as MaxID from Invoice_tbl", connection))
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            MaxId = Convert.ToInt32(reader["MaxID"]);
                            MaxId = MaxId + 1;
                            label_InvoiceNo.Text = MaxId.ToString();
                        }
                        reader.Close();
                    }
                }
            }
            catch
            {
                MaxId = MaxId + 1;
                label_InvoiceNo.Text = MaxId.ToString();
            }
        }

        void GetInsertedInvoiceID()
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                using (SqlCommand cmd = new SqlCommand("Select Max(Id) as MaxID from Invoice_tbl", connection))
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        InsertedInvId = Convert.ToInt32(reader["MaxID"]);
                    }
                }
            }
        }

        List<custom_list.Tax> taxList = new List<custom_list.Tax>();
        void GetTax()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand("Select Id ,TaxPercentage,Name from tax_tbl", connection))
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            custom_list.Tax objTax = new custom_list.Tax();
                            objTax.Id = Convert.ToInt32(reader["Id"]);
                            objTax.TaxPercentage = Convert.ToDecimal(reader["TaxPercentage"]);
                            objTax.Name = Convert.ToString(reader["Name"]);
                            taxList.Add(objTax);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }

        public void BindDLL()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand command = new SqlCommand("Select Id, ItemName, LookupCode, DeptId, CateId, Cost, Price, Quantity, UOM, Weight, TaxId, IsDiscountItem, 0 as Action from item_tbl Where Quantity>0", connection))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dr = dt.NewRow();
                        dr.ItemArray = new object[] { 0, "--Select--" };
                        dt.Rows.InsertAt(dr, 0);

                        ddlLookup.ValueMember = "Id";
                        ddlLookup.DisplayMember = "LookupCode";
                        ddlLookup.DataSource = dt;

                        ddlItems.ValueMember = "Id";
                        ddlItems.DisplayMember = "ItemName";
                        ddlItems.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }
        List<custom_list.SalesItem> itemSalesList = new List<custom_list.SalesItem>();
        List<custom_list.SalesItem> emptyList = new List<custom_list.SalesItem>();
        private void ddlLookup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int indx = ddlLookup.SelectedIndex;
                if (indx > 0)
                {
                    var item = itemList.FirstOrDefault(x => x.LookupCode.Equals(ddlLookup.Text.Trim()));
                    //MessageBox.Show(item.ToString());
                    if (item != null)
                    {
                        custom_list.SalesItem objItem = new custom_list.SalesItem();

                        objItem.Id = item.Id;
                        objItem.LookupCode = item.LookupCode;
                        objItem.ItemName = item.ItemName;
                        objItem.ItemPrice= item.Price;
                        objItem.Price = item.Price;
                        objItem.Quantity = 1;
                        objItem.TaxId = item.TaxId;
                        objItem.Cost = item.Cost;
                        objItem.Total = item.Price;
                        //MessageBox.Show("objItem.Total:" + objItem.Total.ToString());
                        MessageBox.Show("objItem.Cost:" + objItem.Cost);
                        objItem.Action = false;
                        MessageBox.Show(objItem.ToString());
                        itemSalesList.Add(objItem);

                       dataGridViewSalesItem.DataSource = emptyList;
                       dataGridViewSalesItem.DataSource = itemSalesList;

                       Calculate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }

        private void dataGridViewSalesItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }

        decimal TotalAmt = 0;
        decimal TaxAmt = 0;
        decimal PriceAmt = 0;
        void Calculate()
        {
            try
            {
                decimal SumTotal = itemSalesList.Sum(x => x.Price);
                decimal Price = itemSalesList.Sum(x => x.Price);
                MessageBox.Show(Price.ToString());
                label_amount_text.Text = SumTotal.ToString();
                label_tax_text.Text = "0";

                label_total_text.Text = SumTotal.ToString();

                TotalAmt = SumTotal;
                PriceAmt= Price;
                if(SumTotal > 0)
                {
                    button_pay.Enabled = true;
                    button_pay.BackColor = Color.DarkGreen;
                }
                else
                {
                    button_pay.Enabled = false;
                    button_pay.BackColor = Color.Yellow;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }

        //int SelectedCustomerId = 0;
        /*private void btnCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Customer objCustomer = new Customer();
                frmCustomer objCustomerForm = new frmCustomer();
                objCustomer = objCustomerForm.ShowDialog();
                if (objCustomer.Id > 0)
                {
                    SelectedCustomerId = objCustomer.Id;
                    lblCustId.Text = objCustomer.Id.ToString();
                    lblCustName.Text = objCustomer.FirstName.ToString();
                    lblMobile.Text = objCustomer.MobileNo.ToString();
                    grpCustomer.Visible = true;
                }
                else
                {
                    SelectedCustomerId = 0;
                    lblCustId.Text = "";
                    lblCustName.Text = "";
                    lblMobile.Text = "";
                    grpCustomer.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception btnCustomer_Click " + ex);
            }
        }*/
    }
}

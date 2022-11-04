using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LogInForm1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

            
            
            

            var ghoramiTech = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) +
                             "\\Abir\\Hossain";

            

            var location = Path.Combine(ghoramiTech, "jubayer.md");
            var data = File.ReadAllText(location);

            List<Form1.VALUE> userDataDeserializeObject =
                JsonConvert.DeserializeObject<List<Form1.VALUE>>(data);

            label_gtype.Text = userDataDeserializeObject[0].gType;
            label_sopnoid.Text = userDataDeserializeObject[0].sopnoid;
            label_uemail.Text = userDataDeserializeObject[0].uemail;

            datagridviewdesign();


            var source = new BindingSource();
            source.DataSource = userDataDeserializeObject;
            dataGridView1.DataSource = source;
        }

        private void datagridviewdesign()
        {
            var dg = dataGridView1;

            //Extra Design 
            dg.BorderStyle = BorderStyle.None;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            //dg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dg.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dg.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dg.BackgroundColor = Color.White;
            //dg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //optional
            dg.EnableHeadersVisualStyles = false;
            dg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dg.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            // dg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dg.AutoGenerateColumns = false;
            dg.ColumnCount = 3;
            //POS_GridView.ReadOnly = true;

            dg.Columns[0].HeaderText = @"User ID";
            dg.Columns[0].DataPropertyName = "sopnoid";
            dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dg.Columns[0].ReadOnly = true;

            dg.Columns[1].HeaderText = @"Mobile NUmber";
            dg.Columns[1].DataPropertyName = "umobile";
            dg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dg.Columns[1].ReadOnly = true;

            dg.Columns[2].HeaderText = @"Company Name";
            dg.Columns[2].DataPropertyName = "company";
            dg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dg.Columns[2].ReadOnly = true;


           // add_to_datagridview_check_list();
        }
    }
}

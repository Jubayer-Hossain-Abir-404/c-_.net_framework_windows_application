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
//using Newtonsoft.Json;


namespace LogInForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public class VALUE
        {
            public string gType { get; set; }
            public string sopnoid { get; set; }
            public string uemail { get; set; }
            public string umobile { get; set; }
            public string uname { get; set; }
            public string userpic { get; set; }
            public string phone_verify { get; set; }
            public string company { get; set; }
            public string c_refer { get; set; }
            public string c_id { get; set; }
            public string c_info { get; set; }
            public string cpic { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            try
            {
                string url = "https://ghorami.com/profile/login/api/uinsert.php/";

                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Method = "POST";

                httpRequest.ContentType = "application/x-www-form-urlencoded";

                NameValueCollection outgoingQueryString = HttpUtility.ParseQueryString(String.Empty);
                outgoingQueryString.Add("MobileNumber", textBox1.Text);
                outgoingQueryString.Add("pass", textBox2.Text);
                string data = outgoingQueryString.ToString();
                // var data = "key1=value1&key2=value2";

                //MessageBox.Show(data);

                if (MessageBox.Show(data + "  " + url, "bla bla bla. (OK to copy)", MessageBoxButtons.OKCancel) ==
                    System.Windows.Forms.DialogResult.OK)
                {
                    Clipboard.SetText(data + "  " + url);
                }

                using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
                {
                    streamWriter.Write(data);
                }

                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                
            }
            var ghoramiTech = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) +
                              "\\Abir\\Hossain";

            System.IO.Directory.CreateDirectory(ghoramiTech);

            var location = Path.Combine(ghoramiTech, "jubayer.md");

            if (!File.Exists(location))
            {
                // if (MessageBox.Show(location, "bla bla bla(OK to copy)", MessageBoxButtons.OKCancel) ==
                //     System.Windows.Forms.DialogResult.OK)
                // {
                //     Clipboard.SetText(location);
                // }

                // Create a new file     
                using (FileStream fs = File.Create(location))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes(result);
                    fs.Write(title, 0, title.Length);
                }
            }
            else
            {
                File.WriteAllText(location, result);
                //await File.WriteAllTextAsync(s_path2, code);
            }


            /* var objMain = new MainMenu();
             //var objMain = new mainform_form();
             Hide();
             objMain.Show();*/
            MainMenu frm2 = new MainMenu();
            frm2.Show();


        }

        private void maximize_Click(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }
    }
    
}

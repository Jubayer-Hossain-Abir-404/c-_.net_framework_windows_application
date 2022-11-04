using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace LoginWithAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebRequest request = HttpWebRequest.Create("https://ghorami.com/profile/login/api/uinsert.php?MobileNumber=" + textBox1.Text + "&pass=" + textBox2.Text);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            string json_data = reader.ReadToEnd();

            json_data2 fetch_json = Newtonsoft.Json.JsonConvert.DeserializeObject<json_data2>(json_data);
            MessageBox.Show(fetch_json.value.umobile);

            
        }
    }

    public class Value
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
    public class json_data2
    {
        public string type { get; set; }
        public Value value { get;}
    }

}

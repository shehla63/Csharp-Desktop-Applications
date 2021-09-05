using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;// here import this file to manipulate the XML file
using System.Xml.Linq; // link that file
using System.Net; // use webclient and download data
using System.IO; // to use memeorystreams

namespace weatherApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // here this is the constructor of class form 
            // in which we add the name of cities in combo box
            InitializeComponent();
            this.comboBox1.Items.Add("Duhok");
            this.comboBox1.Items.Add("london");
            this.comboBox1.Items.Add("paris");
            this.comboBox1.Items.Add("New York");
            this.comboBox1.Items.Add("California");
            this.comboBox1.Items.Add("Texas");



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            getData();// when click on proceed button this method will be called
        }

        public void getData() {
            /// if by default select city is there then do nothing
            if (this.comboBox1.SelectedItem.Equals("Select City"))
            {
            }
            else {

                // if user has selected any city from combo box
                //store the basic API url in String.
                String uri = String.Format("http://api.weatherapi.com/v1/current.xml?key=a2e4b199126442ea9c4151727211704&q={0}&aqi=no", this.comboBox1.SelectedItem.ToString());
                
                //load the uri using XDocument class.
                XDocument doc = XDocument.Load(uri);
                // get icon link from xml file.
                String icon = (String)doc.Descendants("icon").FirstOrDefault();
                // create webclient object of get picture whose link is given
                WebClient webC = new WebClient();
                // download that picture or icon in byte data and store it in byte array.
                byte[] image = webC.DownloadData("http:" + icon);
                //extract that data that is in bytes into memorystream to get the actuall picture
                MemoryStream sr = new MemoryStream(image);
                Bitmap bmap = new Bitmap(sr);

                // fetch the basic details from XML file and store them into variables
                String tempC = (String)doc.Descendants("temp_c").FirstOrDefault();// temperature in celecius
                String tempF = (String)doc.Descendants("temp_f").FirstOrDefault();//temperature in fahrenhit
                String cName = (String)doc.Descendants("name").FirstOrDefault();// get City Name

                String cPressure = (String)doc.Descendants("pressure_in").FirstOrDefault();    //get pressure
                String condition = (String)doc.Descendants("text").FirstOrDefault(); // get condition
                String humidity = (String)doc.Descendants("humidity").FirstOrDefault();//humidity
               
                String windSpeed = (String)doc.Descendants("wind_mph").FirstOrDefault(); //get wind speed
                String country = (String)doc.Descendants("country").FirstOrDefault(); //get Country Name
                String date = (String)doc.Descendants("last_updated").FirstOrDefault(); //last Update

                Bitmap iconn = bmap;

                // now paste all the information o =n label control that are used in our application
                this.cityName.Text = cName;
                this.countryName.Text = country;
                this.tempCelsis.Text = tempC + "   `C";
                this.tempFarh.Text = tempF + "   F";
                this.condition.Text = condition;
                this.humidity.Text = humidity;
                this.windSpeed.Text = windSpeed+" mph";
                this.press.Text = cPressure+" in";

                this.date.Text = date;
                this.pictureBox1.Image = iconn;
    
            }

        }
    }
}

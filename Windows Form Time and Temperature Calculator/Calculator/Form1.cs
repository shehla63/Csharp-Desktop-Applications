using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {// here we have define couple of globle variables that 
        // has been used below in code.
        String result2;
        double result;
        double in1,in2;
        String time;
        String Temp;
        int State;
        int status;
        public Form1()
        {
            InitializeComponent();
            result2 = "";
            result = 0;
            in1 = 0;
            in2 = 0;
            State = 0;
            this.label1.Text = "0";
            this.label2.Text = "0";
            status = 1;
            this.label14.Text = "Time";

            //here the equivalent converion are labelized initially
            this.label4.Text = "0 wk";
            this.label6.Text = "0 yr";
            this.label8.Text = "0 d";
            this.label10.Text = "0 s";
            this.label12.Text = "0 ms";

            //here the combo boxes will be occupied
            this.comboBox1.Items.Add("microseconds");
            this.comboBox1.Items.Add("miliseconds");
            this.comboBox1.Items.Add("seconds");
            this.comboBox1.Items.Add("minutes");
            this.comboBox1.Items.Add("hours");


            this.comboBox1.Items.Add("days");
            this.comboBox1.Items.Add("weeks");
            this.comboBox1.Items.Add("years");

            this.comboBox1.SelectedIndex = 5;


            this.comboBox2.Items.Add("microseconds");
            this.comboBox2.Items.Add("miliseconds");
            this.comboBox2.Items.Add("seconds");
            this.comboBox2.Items.Add("minutes");
            this.comboBox2.Items.Add("hours");
            this.comboBox2.Items.Add("days");
            this.comboBox2.Items.Add("weeks");
            this.comboBox2.Items.Add("years");

            this.comboBox2.SelectedIndex = 3;

        }

        private void value(object sender, EventArgs e)
        {
            //this event will be called by clicking the numbered button
            Button btn = (Button)sender;
            result2 += btn.Text;
            this.label1.Text = result2;
            State = 1;
            calculate();
        }
        public void calculate()
        {

            try
            {
                // this function will calculate time and its conversions into different units.
                String from = this.comboBox1.SelectedItem.ToString();
                String to = this.comboBox2.SelectedItem.ToString();
                Label label1 = this.label2;

                in2 = Convert.ToDouble(this.label2.Text);

                in1 = Convert.ToDouble(this.label1.Text);

                if (from == "miliseconds") //this section will convert miliseconds into microseconds,minutes, hours, days,week and year
                {


                    this.label4.Text = (in1 / (604800000)).ToString() + " wk";
                    long a = 31536000000;
                    this.label6.Text = (in1 / a).ToString() + " yr";
                    this.label8.Text = (in1 / (60000 * 60 * 24)).ToString() + " d";
                    this.label10.Text = (in1 / 1000).ToString() + " s";
                    this.label12.Text = (in1 * 1).ToString() + " ms";

                    if (to == "microseconds")
                    {
                        result = in1 * 1000;
                        label1.Text = result.ToString();

                    }
                    else if (to == "miliseconds")
                    {
                        result = in1 * 1;
                        label1.Text = result.ToString();
                    }

                    else if (to == "seconds")
                    {
                        result = in1 / 1000;
                        label1.Text = result.ToString();
                    }

                    else if (to == "minutes")
                    {
                        result = in1 / 60000;
                        label1.Text = result.ToString();
                    }

                    else if (to == "hours")
                    {
                        result = in1 / (60000 * 60);
                        label1.Text = result.ToString();
                    }
                    else if (to == "days")
                    {
                        result = in1 / (60000 * 60 * 24);
                        label1.Text = result.ToString();
                    }
                    else if (to == "weeks")
                    {

                        result = in1 / (604800000);
                        label1.Text = result.ToString();
                    }
                    else if (to == "years")
                    {
                        long a2 = 31536000000;
                        result = in1 / a2;
                        label1.Text = result.ToString();
                    }
                }
                else if (from == "microseconds")  //this section will convert microseconds into miliseconds,seconds,minutes, hours, days,week and year
                {


                    this.label4.Text = (in1 / 604800000000).ToString() + " wk";
                    long a2 = 31536000000000;
                    this.label6.Text = (in1 / a2).ToString() + " yr";

                    this.label8.Text = (in1 / 86400000000).ToString() + " d";

                    this.label10.Text = (in1 / 1000000).ToString() + " s";
                    this.label12.Text = (in1 / 1000).ToString() + " ms";


                    if (to == "microseconds")
                    {
                        result = in1 * 1;
                        label1.Text = result.ToString();
                    }
                    else if (to == "miliseconds")
                    {
                        result = in1 / 1000;
                        label1.Text = result.ToString();
                    }

                    else if (to == "seconds")
                    {
                        result = in1 / 1000000;
                        label1.Text = result.ToString();
                    }

                    else if (to == "minutes")
                    {
                        result = in1 / 60000000;
                        label1.Text = result.ToString();
                    }

                    else if (to == "hours")
                    {
                        result = in1 / 3600000000;
                        label1.Text = result.ToString();
                    }
                    else if (to == "days")
                    {
                        result = in1 / 86400000000;
                        label1.Text = result.ToString();
                    }
                    else if (to == "weeks")
                    {

                        result = in1 / 604800000000;
                        label1.Text = result.ToString();
                    }
                    else if (to == "years")
                    {
                        long a = 31536000000000;
                        result = in1 / a;
                        label1.Text = result.ToString();
                    }
                }
                else if (from == "seconds")//this section will convert seconds into miliseconds,microseconds,minutes, hours, days,week and year
                {

                    this.label4.Text = (in1 / 604800).ToString() + " wk";

                    long a2 = 31536000;
                    this.label6.Text = (in1 / a2).ToString() + " yr";

                    this.label8.Text = (in1 / 86400).ToString() + " d";

                    this.label10.Text = (in1 / 1).ToString() + " s";
                    this.label12.Text = (in1 * 1000).ToString() + " ms";


                    if (to == "microseconds")
                    {
                        result = in1 * 1000000;
                        label1.Text = result.ToString();
                    }
                    else if (to == "miliseconds")
                    {
                        result = in1 * 1000;
                        label1.Text = result.ToString();
                    }

                    else if (to == "seconds")
                    {
                        result = in1 / 1;
                        label1.Text = result.ToString();
                    }

                    else if (to == "minutes")
                    {
                        result = in1 / 60;
                        label1.Text = result.ToString();
                    }

                    else if (to == "hours")
                    {
                        result = in1 / 3600;
                        label1.Text = result.ToString();
                    }
                    else if (to == "days")
                    {
                        result = in1 / 86400;
                        label1.Text = result.ToString();
                    }
                    else if (to == "weeks")
                    {

                        result = in1 / 604800;
                        label1.Text = result.ToString();
                    }
                    else if (to == "years")
                    {
                        long a = 31536000;
                        result = in1 / a;
                        label1.Text = result.ToString();
                    }
                }

                else if (from == "minutes") //this section will convert minutes into miliseconds,seconds,microseconds, hours, days,week and year
                {

                    this.label4.Text = (in1 / 10080).ToString() + " wk";

                    long a2 = 525600;
                    this.label6.Text = (in1 / a2).ToString() + " yr";

                    this.label8.Text = (in1 / 1440).ToString() + " d";

                    this.label10.Text = (in1 * 60).ToString() + " s";
                    this.label12.Text = (in1 * 60000).ToString() + " ms";

                    if (to == "microseconds")
                    {
                        result = in1 * 60000000;
                        label1.Text = result.ToString();
                    }
                    else if (to == "miliseconds")
                    {
                        result = in1 * 60000;
                        label1.Text = result.ToString();
                    }

                    else if (to == "seconds")
                    {
                        result = in1 * 60;
                        label1.Text = result.ToString();
                    }

                    else if (to == "minutes")
                    {
                        result = in1 / 1;
                        label1.Text = result.ToString();
                    }

                    else if (to == "hours")
                    {
                        result = in1 / 60;
                        label1.Text = result.ToString();
                    }
                    else if (to == "days")
                    {
                        result = in1 / 1440;
                        label1.Text = result.ToString();
                    }
                    else if (to == "weeks")
                    {

                        result = in1 / 10080;
                        label1.Text = result.ToString();
                    }
                    else if (to == "years")
                    {
                        long a = 525600;
                        result = in1 / a;
                        label1.Text = result.ToString();
                    }
                }

                else if (from == "hours") //this section will convert hours into miliseconds,seconds,minutes,microseconds , days,week and year
                {

                    this.label4.Text = (in1 / 168).ToString() + " wk";

                    long a2 = 8760;
                    this.label6.Text = (in1 / a2).ToString() + " yr";

                    this.label8.Text = (in1 / 24).ToString() + " d";

                    this.label10.Text = (in1 * 3600).ToString() + " s";
                    this.label12.Text = (in1 * 3600000).ToString() + " ms";

                    if (to == "microseconds")
                    {
                        result = in1 * 3600000000;
                        label1.Text = result.ToString();
                    }
                    else if (to == "miliseconds")
                    {
                        result = in1 * 3600000;
                        label1.Text = result.ToString();
                    }

                    else if (to == "seconds")
                    {
                        result = in1 * 3600;
                        label1.Text = result.ToString();
                    }

                    else if (to == "minutes")
                    {
                        result = in1 * 60;
                        label1.Text = result.ToString();
                    }

                    else if (to == "hours")
                    {
                        result = in1 / 1;
                        label1.Text = result.ToString();
                    }
                    else if (to == "days")
                    {
                        result = in1 / 24;
                        label1.Text = result.ToString();
                    }
                    else if (to == "weeks")
                    {

                        result = in1 / 168;
                        label1.Text = result.ToString();
                    }
                    else if (to == "years")
                    {
                        long a = 8760;
                        result = in1 / a;
                        label1.Text = result.ToString();
                    }
                }
                else if (from == "days") //this section will convert days into miliseconds,seconds,minutes,microseconds , hours,week and year
                {

                    this.label4.Text = (in1 / 7).ToString() + " wk";

                    long a2 = 365;
                    this.label6.Text = (in1 / a2).ToString() + " yr";

                    this.label8.Text = (in1 / 1).ToString() + " d";

                    this.label10.Text = (in1 * 8640).ToString() + " s";
                    this.label12.Text = (in1 * 86400000).ToString() + " ms";

                    if (to == "microseconds")
                    {
                        result = in1 * 86400000000;
                        label1.Text = result.ToString();
                    }
                    else if (to == "miliseconds")
                    {
                        result = in1 * 86400000;
                        label1.Text = result.ToString();
                    }

                    else if (to == "seconds")
                    {
                        result = in1 * 86400;
                        label1.Text = result.ToString();
                    }

                    else if (to == "minutes")
                    {
                        result = in1 * 1440;
                        label1.Text = result.ToString();
                    }

                    else if (to == "hours")
                    {
                        result = in1 * 24;
                        label1.Text = result.ToString();
                    }
                    else if (to == "days")
                    {
                        result = in1 / 1;
                        label1.Text = result.ToString();
                    }
                    else if (to == "weeks")
                    {

                        result = in1 / 7;
                        label1.Text = result.ToString();
                    }
                    else if (to == "years")
                    {
                        long a = 365;
                        result = in1 / a;
                        label1.Text = result.ToString();
                    }
                }
                else if (from == "weeks") //this section will convert weeks into miliseconds,seconds,minutes,microseconds , days,hours and year

                {

                    this.label4.Text = (in1 / 1).ToString() + " wk";

                    Double a2 = 52.143;
                    this.label6.Text = (in1 / a2).ToString() + " yr";

                    this.label8.Text = (in1 * 7).ToString() + " d";

                    this.label10.Text = (in1 * 604800).ToString() + " s";
                    this.label12.Text = (in1 * 604800000).ToString() + " ms";

                    if (to == "microseconds")
                    {
                        result = in1 * 604800000000;
                        label1.Text = result.ToString();
                    }
                    else if (to == "miliseconds")
                    {
                        result = in1 * 604800000;
                        label1.Text = result.ToString();
                    }

                    else if (to == "seconds")
                    {
                        result = in1 * 604800;
                        label1.Text = result.ToString();
                    }

                    else if (to == "minutes")
                    {
                        result = in1 * 10080;
                        label1.Text = result.ToString();
                    }

                    else if (to == "hours")
                    {
                        result = in1 * 168;
                        label1.Text = result.ToString();
                    }
                    else if (to == "days")
                    {
                        result = in1 * 7;
                        label1.Text = result.ToString();
                    }
                    else if (to == "weeks")
                    {

                        result = in1 / 1;
                        label1.Text = result.ToString();
                    }
                    else if (to == "years")
                    {
                        double a = 52.143;
                        result = in1 * a;
                        label1.Text = result.ToString();
                    }
                }
                else if (from == "years") //this section will convert years into miliseconds,seconds,minutes,microseconds , days,week and hours

                {
                    this.label4.Text = (in1 * 52.143).ToString() + " wk";

                    Double a2 = 1;
                    this.label6.Text = (in1 / a2).ToString() + " yr";

                    this.label8.Text = (in1 * 365).ToString() + " d";

                    this.label10.Text = (in1 * 31540000).ToString() + " s";
                    this.label12.Text = (in1 * 31540000000).ToString() + " ms";

                    if (to == "microseconds")
                    {
                        result = in1 * 31540000000000;
                        label1.Text = result.ToString();
                    }
                    else if (to == "miliseconds")
                    {
                        result = in1 * 31540000000;
                        label1.Text = result.ToString();
                    }

                    else if (to == "seconds")
                    {
                        result = in1 * 31540000;
                        label1.Text = result.ToString();
                    }

                    else if (to == "minutes")
                    {
                        result = in1 * 525600;
                        label1.Text = result.ToString();
                    }

                    else if (to == "hours")
                    {
                        result = in1 * 8760;
                        label1.Text = result.ToString();
                    }
                    else if (to == "days")
                    {
                        result = in1 * 365;
                        label1.Text = result.ToString();
                    }
                    else if (to == "weeks")
                    {

                        result = in1 * 52.143;
                        label1.Text = result.ToString();
                    }
                    else if (to == "years")
                    {
                        double a = 1;
                        result = in1 * a;
                        label1.Text = result.ToString();
                    }
                }
            }
            catch (Exception ae) { }


        }
        private void button11_Click(object sender, EventArgs e)
        {
            //this method will reinitialize the all values
            this.label1.Text = "0";
            this.label2.Text = "0";
            this.label4.Text = "0";
            this.label6.Text = "0";
            this.label8.Text = "0";
            this.label10.Text = "0";
            this.label12.Text = "0";
            result2 = "";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (State==0) {
                State = 1;
            }else
            calculate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //0-hide
            if (status == 0)
            {
                this.panel1.Width = 1;
                status = 1;
            }
            else {
                this.panel1.Width = 237;
                status = 0;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (State == 0)
            {
                State = 1;
            }
            else
                calculate();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //here we are removing or deleting the last character or digit 
            result2 = result2.Remove(result2.Length - 1, 1);
            this.label1.Text = result2;
            if (result2.Length == 0)
            {
                this.label1.Text = "0";
                calculate();
            }
            else {
                calculate();
            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //here the temperature form will be called by hiding the current one.
            this.label14.Text = "Temperature";
            Temperature tempForm = new Temperature();
            
            tempForm.Show();
            this.Hide();
        }
    }
}

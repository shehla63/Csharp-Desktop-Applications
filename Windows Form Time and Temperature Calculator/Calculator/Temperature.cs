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
    public partial class Temperature : Form
    {
        // here we have define couple of globle variables that 
        // has been used below in code.
        int status;
        double in1;
        double result;
        String result2;
        double in2;
        String time;
        String Temp;
        bool gate;
        int State;
        
        public Temperature()
        {
            InitializeComponent();

            status = 1;
            result = 0;
            in1 = 0;
            State = 0;
            gate = true;
            this.label14.Text = "Temperature";
            //here the combo boxes have been asigned values.
            this.comboBox1.Items.Add("celsius");
            this.comboBox1.Items.Add("fahrenheit");
            this.comboBox1.Items.Add("kelvin");
            //default index value for combo box 
            this.comboBox1.SelectedIndex = 1;

            //here the combo boxes 2 have been asigned values.
            this.comboBox2.Items.Add("celsius");
            this.comboBox2.Items.Add("fahrenheit");
            this.comboBox2.Items.Add("kelvin");
            //default index value for combo box 
            this.comboBox2.SelectedIndex = 0;


        }

        private void Temperature_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            // here in this function we will shift towards From1 that is for timer
            
            Form1 obj = new Form1();
           
            obj.Show();//show method to show form
            this.Hide();// hide method used to find the current form
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //here we are checking whether the panel for timer  and temperature selection is
            //shown or hidden
            if (status==1) {
                this.panel1.Width = 1;
                status = 0;
            }
            else {
                this.panel1.Width = 237;
                status = 1;
            }
        }

        public void calculate() {

            //here in this method or function we are calculating the temperature
            // according to user selction of degree

            String from = this.comboBox1.SelectedItem.ToString();
            String to = this.comboBox2.SelectedItem.ToString();
            Label label1 = this.label2;

            in1 = Convert.ToDouble(this.label1.Text); // first get the text and then convert it into double for manipulation


            if (from == "celsius")//this section will convert celsius to fahrenheit and kelvin
            {
                this.label4.Text = (in1 + 273.15).ToString()+" k";

                if (to == "celsius")
                {
                    result = in1;
                    this.label2.Text = result + "";
                }
                else if (to == "fahrenheit")
                {
                    result = (in1 * 1.8) + 32;
                    this.label2.Text = result + "";
                }
                else if (to == "kelvin")
                {
                    result = in1 + 273.15;
                    this.label2.Text = result + "";
                }
            }
            else if (from == "fahrenheit")//this section will convert farhenheit to celsuis and kelvin
            {
                this.label4.Text = (((in1 - 32) * (0.555555555555555555555555556)) + 273.15).ToString()+" k";

                if (to == "celsius")
                {
                    result = (in1 - 32) * (0.555555555555555555555555556);
                    this.label2.Text = result + "";
                }
                else if (to == "fahrenheit")
                {
                    result = in1;
                    this.label2.Text = result + "";
                }
                else if (to == "kelvin")
                {

                    result = ((in1 - 32) * (0.555555555555555555555555556)) + 273.15;
                    this.label2.Text = result + "";
                }

            }
            else if (from == "kelvin")//this section will convert kelvin to fahrenheit and celsius
            {
                this.label4.Text = (in1).ToString()+" k";

                if (to == "celsius")
                {
                    result = (in1 - 273.15);
                    this.label2.Text = result + "";
                }
                else if (to == "fahrenheit")
                {
                    result = (in1 - 273.15) * (1.8) + 32;
                    this.label2.Text = result + "";
                }
                else if (to == "kelvin")
                {
                    result = in1;
                    this.label2.Text = result + "";
                }

            }
        }


        private void Value(object sender, EventArgs e)
        {
            //here is the event that will be called by clicking the number buttons and
            // will be labelized.
            
            Button btn = (Button)sender;
            result2 += btn.Text;
            this.label1.Text = result2;
            calculate();
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

        private void button11_Click(object sender, EventArgs e)
        {
            // here is the method on cancel button that will restore the information
            this.label1.Text = "0";
            this.label2.Text = "0";
            this.label4.Text = "0 "+"k";
            result2 = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (State == 0)
            {
                State = 1;
            }
            else
                calculate();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //this will calculate the -ve temperature
            if (gate)
            {
                result2 = "-" + result2;
                this.label1.Text = result2;
                calculate();
                gate = false;
            }
            else {
                result2 = result2.Replace("-","");
                this.label1.Text = result2;
                calculate();
                gate = true;
            }
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
            else
            {
                calculate();
            }

        }
    }
}

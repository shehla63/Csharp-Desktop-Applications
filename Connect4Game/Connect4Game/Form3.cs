namespace Connect4Game
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Form3 : Form
    {
        private Form1 form1;
        private Form2 form2;
        private string choice = "NO";
        
        public Form3()
        {
        }

        public Form3(string winner, Form2 form2, Form1 form1) 
        {
            this.InitializeComponent();
            this.winnerLabel.Text = winner;
            this.form1 = form1;
            this.form2 = form2;
        }

        public string GetChoice()
        {
            return this.choice;
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            this.choice = "YES";
            this.form2.Show();
            this.form1.Hide();
            this.Hide();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.form2.Hide();
            this.form1.Show();
            this.choice = "NO";
        }
    }
}

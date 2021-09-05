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
   
   
    public partial class Form1 : Form
    {
        public Form1()
        { 
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void OnStartButtonListener(object sender, EventArgs e)
        {
            Form2 gameForm = new Form2(this);
            gameForm.SetCredentials(Convert.ToInt32(this.numberOfRows.Value), Convert.ToInt32(this.numberOfColumns.Value), this.p1.Text, this.p2.Text);
            this.Hide();
            gameForm.Show();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.p2.Enabled = true;
                this.p2.Text = string.Empty;
            }
            else
            {
                this.p2.Enabled = false;
                this.p2.Text = "Computer";
            }
        }
    }
}

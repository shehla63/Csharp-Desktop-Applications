using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            this.progressBar1.Value = startpoint;
            if (this.progressBar1.Value == 100) {
                this.progressBar1.Value = 0;
                timer1.Stop();
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }

        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

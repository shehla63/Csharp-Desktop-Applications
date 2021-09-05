using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FawadIjazAssigt
{
    //Partial Class to Load Form for Single Player Details
    public partial class frmSinglePlayerInfo : Form
    {
        public frmSinglePlayerInfo()
        {
            InitializeComponent();
        }

        //Player vs Computer Form Loads when Start Button Clicked after Entering Player Name and Score.
        private void btn_Start_Click(object sender, EventArgs e)
        {
            new frmComputer(txbxPlayer1.Text, int.Parse(txbxSetScore.Text)).Show();
            this.Hide();
        }
    }
}
//Fawad Ijaz
//St#: 3316042
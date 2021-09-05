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
    //Partial Class used to Load Form for 2 Player Details
    public partial class frmPlayersInfo : Form
    {
        public frmPlayersInfo()
        {
            InitializeComponent();
        }


        //Loads in 2 Players Information Form
        private void lblEnterInfo_Click(object sender, EventArgs e)
        {

        }

        //If Start Button clicked after Info Entered; loads in the Main Game Form for the User
        private void btn_Start_Click(object sender, EventArgs e)
        {
            new frmMainGame(txbxPlayer1.Text, txbxPlayer2.Text, Convert.ToInt32(txbxSetScore.Text)).Show();
            this.Hide();
        }

    }
}
//Fawad Ijaz
//St#: 3316042
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
    public partial class frmPlayerMode : Form
    {
        public frmPlayerMode()
        {
            InitializeComponent();
        }

        //Method to Load Player Mode Form
        private void Player_Mode_Load(object sender, EventArgs e)
        {

        }

        //If Double Player Button Clicked
        //Displays 2 Players Info Form
        //Hiding this Form as per Click
        private void button2_Click(object sender, EventArgs e)
        {
            new frmPlayersInfo().Show();
            this.Hide();
        }

        //If Play With Computer Button Clicked
        //Displays 1 Player Info Form
        //Hiding this Form as per Click
        private void button1_Click(object sender, EventArgs e)
        {
            new frmSinglePlayerInfo().Show();
            this.Hide();
        }
    }
}
//Fawad Ijaz
//St#: 3316042
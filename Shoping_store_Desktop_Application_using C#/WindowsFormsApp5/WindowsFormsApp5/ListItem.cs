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
    public partial class ListItem : UserControl
    {
        private String title, prize1;
        public Button buyBtn;
        public Image icon;
        public ListItem()
        {
            InitializeComponent();
            buyBtn = this.buyItem;
        }

        public String Title {

            get {
                return title;
            }
            set {
                title = value;
                this.Name.Text = value;
            }

        }

        public String Prize2 {

            get {
                return prize1;
            }
            set {
                prize1 = value;
                this.Prize.Text = value; 
            }
        
        }

        public Image PICBOX {
            get
            {
                return icon;
            }
            set
            {
                icon = value;
                pictureBox1.Image = value;
            }
        }




        

    }
}

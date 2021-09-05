using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieOutBreak
{
    public partial class Form1 : Form
    {
        // here are some global variables that are used for different purposes.
        int x = 0; // it sets the location of rows
        int y = 0; // it defines the height or columns
        int q = 0;
        int gate = 1; // it allows to insert multiple columns in a single row. 
        int gen = 0; // it changes with the next generation. used for file names.

        List<Button> list = new List<Button>(); // list basically store the reference of all the buttons populated on form. 

        public Form1()
        {
            InitializeComponent();
            int[,] array = readFile("1.txt"); // here we call the readFile method to read data from and returns an array. 
            createLayout(array); // here we call the createLayout method that takes an array and populate that on form.
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void createLayout(int[,] a)
        {

            int i, j;
            int rowsOrHeight = a.GetLength(0); // get the number of rows and columns from an array.
            int colsOrWidth = a.GetLength(1);

            Console.WriteLine(rowsOrHeight);
            Console.WriteLine(colsOrWidth);

            String dirPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath); // get the path of cuurent directory
            String picturePath = "";

            /* output each array element's value */
            for (i = 0; i < rowsOrHeight; i++) // loops for rows 
            {

                for (j = 0; j < colsOrWidth; j++) // loop for number of column in each row
                {
                    Button dynamicButton = new Button(); // create a new button.

                    // Set Button properties
                    if (rowsOrHeight >= 0 && rowsOrHeight <= 10) // here set the layout according to the size of  2d  aaray.
                    {
                        dynamicButton.Height = 70; // set the height of newly created button.
                        dynamicButton.Width = 70; // set width of button.
                        x += 70;
                        q = 70;
                    }
                    else if (rowsOrHeight > 10 && rowsOrHeight <= 20)
                    {
                        dynamicButton.Height = 40;
                        dynamicButton.Width = 40;
                        x += 40;
                        q = 40;
                    }
                    else if (rowsOrHeight > 20 && rowsOrHeight <= 30)
                    {
                        dynamicButton.Height = 28;
                        dynamicButton.Width = 28;
                        x += 28;
                        q = 28;
                    }

                    if (gate == 1)
                    {
                        x = 0; // here set it on the first row
                        gate = 0;
                    }


                    // check the items in array and label the images accordingly 
                    if (a[i, j] == 0)
                    {
                        picturePath = dirPath + "\\0.jpg";
                    }
                    else if (a[i, j] == 1)
                    {
                        picturePath = dirPath + "\\1.jpg";
                    }
                    else if (a[i, j] == 2)
                    {
                        picturePath = dirPath + "\\2.png";
                    }
                    else if (a[i, j] == 3)
                    {
                        picturePath = dirPath + "\\3.png";
                    }




                    dynamicButton.Location = new Point(x, y);// set the location of button
                  
                    dynamicButton.BackgroundImage = Image.FromFile(picturePath); // set background image on button
                    dynamicButton.BackgroundImageLayout = ImageLayout.Zoom;// set backgroundlayout to fit the image on button.
                    

                    dynamicButton.ForeColor = Color.Blue; // set color og text on button


                    dynamicButton.Name = "DynamicButton"; // set button Name

                    dynamicButton.Font = new Font("Georgia", 16); // set the font size and style(family)
                    
                    list.Add(dynamicButton); // add the button into list

                    this.Controls.Add(dynamicButton); // show button control on form
                }

                //set the height and width of the form
                this.Height += 30;
                this.Width += 30;

              
                this.panel1.Left = this.Width-302; // set the location of left side given panel that label the images.
                y += q;
                x = 0;

                gate = 1;

            }


            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // here the readFile method takes file name and read itdata from it and store it in an array.
        public int[,] readFile(String f)
        {



            String dirPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);// get the path of cuurent director.
            String file = dirPath +"\\"+f;
            
            

            String input = File.ReadAllText(file); // File is an static class that has method ReadAllLines that read the whole file and store it into string

            int i = 0, j = 0;


            foreach (var row in input.Split('\n')) // count he number of rows and columns
            {
                Console.WriteLine(row);
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    j++;    
                }
                i++;
            }

            Console.WriteLine(i+" "+j);

            int[,] result = new int[i, j];

            i = 0;
            j = 0;


            // split the string and get the data from it.
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                   
                    result[i, j] = int.Parse(col.Trim());
                   
                    j++;
                }
                i++;
            }
            // return the array that has data.
            return result;
        }


        // here this method invokes whenever next generation button is cliked that repopulate the buttons according to data in array.

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            foreach (Button b in list ) {
                this.Controls.Remove(b);
            }
            */
            int c = 0;

            String dirPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            String picturePath = "";

            gen += 5; // read all file with the gap of 5 files.
            int[,] array = readFile(gen+".txt");

            int rowsOrHeight = array.GetLength(0);
            int colsOrWidth = array.GetLength(1);

            for (int s =0;s<rowsOrHeight;s++) {
                for (int t=0;t<colsOrWidth;t++) {

                    if (array[s, t] == 0)
                    {
                        picturePath = dirPath + "\\0.jpg";
                    }
                    else if (array[s, t] == 1)
                    {
                        picturePath = dirPath + "\\1.jpg";
                    }
                    else if (array[s, t] == 2)
                    {
                        picturePath = dirPath + "\\2.png";
                    }
                    else if (array[s, t] == 3)
                    {
                        picturePath = dirPath + "\\3.png";
                    }

                    list.ElementAt(c).BackgroundImage = Image.FromFile(picturePath);// access the reference of each button from list and change images on them.
                    list.ElementAt(c).BackgroundImageLayout = ImageLayout.Zoom;


                    c += 1;
                }
            }

            



        }
    }
}

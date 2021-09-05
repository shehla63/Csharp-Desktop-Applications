using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace studentManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_Student_Submit(object sender, EventArgs e)
        {
            Student std = new Student();

            std.setFirstName(this.textBox2.Text);
            std.setLastName(this.textBox3.Text);
            std.setStudenttNumber(this.textBox1.Text);

            this.listBox1.Items.Add(std.getStudentNumber() + "        " + std.getFirstName() + "        " + std.getLastName());

            readFromFile("student.txt", this.listBox1, 0, std.getStudentNumber(), std.getFirstName(), std.getLastName());

            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";

        }

        private void btn_Course_Submit(object sender, EventArgs e)
        {
            Courses cr = new Courses();

            cr.setCoursetNumber(this.textBox4.Text);
            cr.setCoded(this.textBox5.Text);
            cr.setTitle(this.textBox6.Text);

            this.listBox2.Items.Add(cr.getCoded() + "        " + cr.getCourseNumber() + "        " + cr.getTitle());

            readFromFile("courses.txt", this.listBox2, 0, cr.getCoded(), cr.getCourseNumber(), cr.getTitle());

            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";

        }

        private void btn_Notes_Submit(object sender, EventArgs e)
        {
           
        }


        private void btn_check_Student(object sender, EventArgs e)
        {
            String input, grade="";
            input = this.textBox10.Text;

            String filePath = Environment.CurrentDirectory + "//notes.txt";
            //List<string> lines = new List<string>();
            String [] lines = File.ReadAllLines(filePath);

            foreach (String l in lines) {
                string std_no = l.Split(' ')[0];

                if (std_no.Trim().Equals(input.Trim())) {
                    grade += l.Split(' ')[8] + "  " + l.Split(' ')[16];
                }
            }


            string[] arr = new string[this.listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                arr[i] = listBox1.Items[i].ToString();
            }

            foreach (String line in arr)
            {
                string current = line.Split(' ')[0];

                Console.WriteLine(current);
                Console.WriteLine(line);
                Console.WriteLine(input);

                if (current.Trim().Equals(input.Trim()))
                {

                    MessageBox.Show("First Name is: " + line.Split(' ')[8] + "\n" + "Last Name is: " + line.Split(' ')[16]+"\n"+"Grades: "+"\n"+grade);
                    for (int i = 0; i < line.Split(' ').Length; i++)
                    {
                        Console.WriteLine(line.Split(' ')[i]);
                    }
                    break;
                }
            }


            /*    int index = System.Convert.ToInt32(this.listBox1.FindString(input));
            // If index variable will not be equal to the Items inside of the ListBox it will display "Item is found"

            if (index != ListBox.NoMatches)
            {
                MessageBox.Show("Item is found!");
            }
            //otherwise, it will display "not found".
            else
            {
                MessageBox.Show("Item not found!");
            }
        */
        }


        public void readFromFile(String fileName, ListBox rb, int message, String arg1, String arg2, String arg3)
        {


            String filePath = Environment.CurrentDirectory + "//" + fileName;
            Console.WriteLine(filePath);
            //                    String[] lines = File.ReadAllLines(filePath);

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            if (message == 1)
            {
                foreach (String line in lines)
                {
                    rb.Items.Add(line+ "\n");
                }
            }
            else if (message == 0)
            {
                lines.Add(arg1 + "        " + arg2 + "        " + arg3);
                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Inserted!");
            }


            /*
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.InitialDirectory = "c:\\";
        openFileDialog.Filter = "txt files (*.txt) | *.txt | All files (*.*) | *.*";
        openFileDialog.FilterIndex = 2;

        if (openFileDialog.ShowDialog() == DialogResult.OK) {

            try {



            }
            catch (Exception e) {
                MessageBox.Show("Got an Error");
            }

        }
            */

        }

        private void show_student_data(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            readFromFile("student.txt", this.listBox1, 1, "", "", "");
        }

        private void show_course_data(object sender, EventArgs e)
        {
            this.listBox2.Items.Clear();
            readFromFile("courses.txt", this.listBox2, 1, "", "", "");
        }

        private void show_notes_data(object sender, EventArgs e)
        {
           
        }

        private void show_grades_data(object sender, EventArgs e)
        {
            this.listBox3.Items.Clear();
            readFromFile("notes.txt", this.listBox3, 1, "", "", "");
        }

        private void btn_grades_Submit(object sender, EventArgs e)
        {
                Notes nt = new Notes();

                nt.setCourseNumber(this.textBox7.Text);
                nt.setStudenttNumber(this.textBox8.Text);
                nt.setNote(this.textBox9.Text);
                this.listBox3.Items.Add(nt.getStudentNumber() + "        " + nt.getCourseNumber() + "        " + nt.getNote());

                readFromFile("notes.txt", this.listBox3, 0, nt.getCourseNumber(), nt.getStudentNumber(), nt.getNote());

                this.textBox7.Text = "";
                this.textBox8.Text = "";
                this.textBox9.Text = "";
            

        }
    }

}
using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Student_Databse_App
{
    public partial class Form1 : Form
    {
        static String connectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
    
            command.CommandText = "SELECT * FROM Student_Table";
            SqlDataReader reader=command.ExecuteReader();

            while (reader.Read()) {

                studentList.Items.Add(reader.GetString(0));
            }
            reader.Close();
            connection.Close();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            String fname, lname, student_city, student_state, student_nationality;
            
            fname = firstName.Text;
            lname = lastName.Text;
            student_city = city.Text;
            student_state = state.Text;
            student_nationality = nationality.Text;
            foreach (String item in studentList.Items) {
                if (item.ToString().Equals(fname)) {
                    MessageBox.Show("Please Select Other First name");
                    return;
                }
            }
            if (fname.Length == 0 || lname.Length == 0 || student_city.Length == 0 || student_state.Length == 0 || student_nationality.Length == 0) {
                MessageBox.Show("All fields required!");
                return;
            }
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            connection.Open();
            command.Connection = connection;

            command.CommandText = "INSERT into Student_Table(FirstName,LastName,City,State,Nationality) VALUES('"+fname+"','"+lname+"','"+student_city+"','"+student_state+"','"+student_nationality+"')";
            command.ExecuteNonQuery();
            connection.Close();
            studentList.Items.Add(fname);
            MessageBox.Show("Record Added!");
            ClearFileds();
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            String fname, lname, student_city, student_state, student_nationality;

            fname = firstName.Text;
            lname = lastName.Text;
            student_city = city.Text;
            student_state = state.Text;
            student_nationality = nationality.Text;


            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "UPDATE Student_Table SET FirstName='" + fname + "',LastName='" + lname + "',City='" + student_city + "',State='" + student_state + "',Nationality='" + student_nationality +"' WHERE FirstName='"+studentList.SelectedItem.ToString()+"'";
            command.ExecuteNonQuery();
            connection.Close();

            studentList.Items.Clear();
            command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            
            command.CommandText = "SELECT * FROM Student_Table";
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                studentList.Items.Add(reader.GetString(0));
            }
            reader.Close();
            connection.Close();
            MessageBox.Show("Record Updated!");
        
        }
   
        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "DELETE FROM Student_Table WHERE FirstName='" + studentList.SelectedItem.ToString() + "'";
            command.ExecuteNonQuery();
            connection.Close();

            studentList.Items.Clear();
            command = new SqlCommand();
            connection.Open();
            command.Connection = connection;

            command.CommandText = "SELECT * FROM Student_Table";
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                studentList.Items.Add(reader.GetString(0));
            }
            reader.Close();
            connection.Close();
            MessageBox.Show("Record DELETED!");

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFileds();
        }
        public void ClearFileds() {

            firstName.Clear();
            lastName.Clear();
            state.Clear();
            nationality.Clear();
            city.Clear();
        }

        private void studentList_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Student_Table WHERE FirstName='"+studentList.SelectedItem.ToString()+"'";
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                firstName.Text=reader.GetString(0);
                lastName.Text= reader.GetString(1);
                city.Text = reader.GetString(2);
                state.Text = reader.GetString(3);
                nationality.Text = reader.GetString(4);
            }
            reader.Close();
            connection.Close();
        }
    }
}

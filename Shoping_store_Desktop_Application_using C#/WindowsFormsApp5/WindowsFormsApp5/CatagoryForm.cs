using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp5
{
    public partial class CatagoryForm : Form
    {
        String error = "This ID already Exists";
        public CatagoryForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=breeze_store_db;Integrated Security=True;Connect Timeout=30");   
        private void addCat_Click(object sender, EventArgs e)
        {
            try {

                if (this.catID.Text == "" || this.catName.Text == "" || this.catDes.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {

                    conn.Open();
                    String query = "INSERT INTO CatagoryTbl VALUES(" + this.catID.Text + ",'" + this.catName.Text + "','" + catDes.Text + "')";
                    SqlCommand sql = new SqlCommand(query, conn);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Catagory Added Successfully!");

                    conn.Close();
                    ClearFields();
                    Populate();
                }
            } catch (Exception ex) {
                MessageBox.Show(error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Populate() {

            conn.Open();
            String query = "SELECT * FROM CatagoryTbl";
            SqlDataAdapter SDA = new SqlDataAdapter(query,conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(SDA);
            var ds = new DataSet();
            SDA.Fill(ds);
            catDGV.DataSource = ds.Tables[0];
            conn.Close();
            

        }
        private void CatagoryForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void catDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.catID.Text = this.catDGV.SelectedRows[0].Cells[0].Value.ToString();
            this.catName.Text = this.catDGV.SelectedRows[0].Cells[1].Value.ToString();
            this.catDes.Text = this.catDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        public void ClearFields() {
            this.catID.Text = "";
            this.catName.Text = "";
            this.catDes.Text = "";
        }

        private void deleteCat_Click(object sender, EventArgs e)
        {
            try {
                if (this.catID.Text == "")
                {
                    MessageBox.Show("Please Select Catagory");
                }
                else {

                    conn.Open();
                    String query = "DELETE FROM CatagoryTbl WHERE CatID="+this.catID.Text+"";
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Catagory Deleted Successfully");
                    conn.Close();
                    ClearFields();
                    Populate();

                }
            
            }catch (Exception ex) {
                MessageBox.Show(error); 
            }
        }

        private void editCat_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.catID.Text == "" || this.catName.Text == "" || this.catDes.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {

                    conn.Open();
                    String query = "UPDATE CatagoryTbl SET CatName='"+this.catName.Text+"', CatDes='"+this.catDes.Text+"' WHERE CatID=" + this.catID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Catagory Updated Successfully");
                    conn.Close();
                    ClearFields();
                    Populate();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductsForm prodForm = new ProductsForm();
            prodForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

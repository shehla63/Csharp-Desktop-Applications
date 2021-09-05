using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class SellerForm : Form
    {
        String error = "Already exists";
        private PictureBox sellerPicture;
        public SellerForm()
        {
            InitializeComponent();
            sellerPicture = this.sellerImage;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=breeze_store_db;Integrated Security=True;Connect Timeout=30");
        private void sellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.sID.Text = this.sellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            this.sName.Text = this.sellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            this.sPhone.Text = this.sellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            this.sAge.Text = this.sellerDGV.SelectedRows[0].Cells[2].Value.ToString();

            try
            {
                conn.Open();
                String query = "SELECT SellerImage FROM SellerTbl";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable("SellerTbl");
                SDA.Fill(dt);
                DataRow row = dt.Rows[e.RowIndex];
                byte[] img = (byte[])row[0];

                try
                {
                    MemoryStream ms = new MemoryStream(img);
                    this.sellerPicture.Image = Image.FromStream(ms);
                }
                catch(Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                SDA.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.sID.Text == "" || this.sName.Text == "" || this.sAge.Text == "" || this.sPhone.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {

                    conn.Open();
                    MemoryStream ms = new MemoryStream();
                    sellerPicture.Image.Save(ms,sellerPicture.Image.RawFormat);
                    byte[] imgs = ms.ToArray();
                    
                    String query = "INSERT INTO SellerTbl VALUES(" + this.sID.Text + ",'" + this.sName.Text + "','" + this.sAge.Text + "','" + this.sPhone.Text + "',@imgs,'" + this.password.Text +"')";
                    
                    SqlCommand sql = new SqlCommand(query,conn);
                    sql.Parameters.Add(new SqlParameter("@imgs",imgs));
                   

                    sql.ExecuteNonQuery();
                    MessageBox.Show("Seller Added Successfully!");
              
                    conn.Close();

                   ClearFields();
                   Populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.sID.Text == "" || this.sName.Text == "" || this.sAge.Text == "" || this.sPhone.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {


                    conn.Open();
                    
                    MemoryStream ms = new MemoryStream();
                    sellerPicture.Image.Save(ms, sellerPicture.Image.RawFormat);
                    byte[] imgs = ms.ToArray();

                    String query = "UPDATE SellerTbl SET SellerName= '" + this.sName.Text + "', SellerAge= '" +this.sAge.Text + "',SellerPhone='" +this.sPhone.Text+ "',SellerPassword='" + this.password.Text + "', SellerImage=@imgs  WHERE SellerID=" + this.sID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add(new SqlParameter("@imgs", imgs));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated Successfully");
                   
                    conn.Close();
                  ClearFields();
                    Populate();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.sID.Text == "")
                {
                    MessageBox.Show("Please Select Seller");
                }
                else
                {

                    conn.Open();
                    String query = "DELETE FROM SellerTbl WHERE SellerID=" + this.sID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");
                    conn.Close();
                    ClearFields();
                    Populate();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Populate()
        {
            try
            {
                conn.Open();
                String query = "SELECT SellerID,SellerName,SellerAge,SellerPhone,SellerPassword  FROM SellerTbl";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable("SellerTbl");
                SDA.Fill(dt);
                sellerDGV.DataSource = dt;
                SDA.Dispose();
                conn.Close();
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ClearFields() {
            this.sID.Text = "";
            this.sName.Text = "";
            this.sPhone.Text = "";
            this.sAge.Text = "";
            this.password.Text = "";
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        String imageLocation;
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                if (openFileDialog.ShowDialog()==System.Windows.Forms.DialogResult.OK) {
                    imageLocation = openFileDialog.FileName;
                    sellerPicture.ImageLocation = imageLocation;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CatagoryForm catagoryForm = new CatagoryForm();
            catagoryForm.Show();
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

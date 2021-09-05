using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp5
{
    public partial class ProductsForm : Form
    {
        String error = "Already Exists";
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Additem_Click(object sender, EventArgs e)
        {

        }

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=breeze_store_db;Integrated Security=True;Connect Timeout=30");

        private void FillCombo() {
            conn.Open();
            SqlCommand sql = new SqlCommand("SELECT CatName FROM CatagoryTbl",conn);
            SqlDataReader rdr;
            rdr = sql.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName",typeof(String));

            dt.Load(rdr);
            catCombo.ValueMember = "catName";
            catCombo.DataSource = dt;

            comboBox2.ValueMember = "catName";
            comboBox2.DataSource = dt;
            Console.WriteLine("Hello");
            rdr.Close();
            conn.Close();
        
        }
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            FillCombo();
            Populate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CatagoryForm catForm = new CatagoryForm();
            catForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.pID.Text == "" || this.pName.Text == "" || this.pQuantity.Text == "" || this.pSize.Text == "" ||
                    this.pPrize.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {

                    try
                    {
                        conn.Open();

                        MemoryStream ms = new MemoryStream();
                        this.ItemImage.Image.Save(ms, this.ItemImage.Image.RawFormat);
                        byte[] imgs = ms.ToArray();

                        String query = "INSERT INTO ProductTbl VALUES(" + this.pID.Text + ",'" + this.pName.Text + "','" + pQuantity.Text + "','" + this.pSize.Text + "','" + this.pPrize.Text + "','" + this.catCombo.SelectedValue.ToString() + "',@imgs)";
                        SqlCommand sql = new SqlCommand(query, conn);
                        sql.Parameters.Add(new SqlParameter("@imgs", imgs));

                        sql.ExecuteNonQuery();

                        MessageBox.Show("Product Added Successfully!");

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(error);
            }
        }

        private void Populate()
        {
            try {
                conn.Open();
                String query = "SELECT ProdID,ProdName,ProdQty,ProdSize,ProdPrize,ProdCat FROM ProductTbl";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(SDA);
                var ds = new DataSet();
                SDA.Fill(ds);
                pdDGV.DataSource = ds.Tables[0];
                SDA.Dispose();
                conn.Close();
            }
            catch (Exception ae) {
                MessageBox.Show(ae.Message);
            }
            
        }

        private void pdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.pID.Text = this.pdDGV.SelectedRows[0].Cells[0].Value.ToString();
            this.pName.Text = this.pdDGV.SelectedRows[0].Cells[1].Value.ToString();
            this.pQuantity.Text = this.pdDGV.SelectedRows[0].Cells[2].Value.ToString();
            this.pSize.Text = this.pdDGV.SelectedRows[0].Cells[3].Value.ToString();
            this.pPrize.Text = this.pdDGV.SelectedRows[0].Cells[4].Value.ToString();
            this.catCombo.SelectedValue= this.pdDGV.SelectedRows[0].Cells[5].Value.ToString();


            try
            {
                conn.Open();
                String query = "SELECT ProdImage FROM ProductTbl";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable("ProductTbl");
                SDA.Fill(dt);
                DataRow row = dt.Rows[e.RowIndex];
                byte[] img = (byte[])row[0];
                try {
                    MemoryStream ms = new MemoryStream(img);
                    this.ItemImage.Image = Image.FromStream(ms);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                
                SDA.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        byte[] imgs;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.pID.Text == "" || this.pName.Text == "" || this.pQuantity.Text == "" || this.pSize.Text == "" ||
                  this.pPrize.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {

                    conn.Open();
                    
                    try {
                        MemoryStream ms = new MemoryStream();
                        this.ItemImage.Image.Save(ms, this.ItemImage.Image.RawFormat);
                        imgs = ms.ToArray();
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                    
                    

                    String query = "UPDATE ProductTbl SET ProdName= '" + this.pName.Text + "', ProdQty= '" + pQuantity.Text + "',ProdSize='" + this.pSize.Text + "',ProdPrize='" + this.pPrize.Text + "',ProdCat='" + this.catCombo.SelectedValue.ToString() + "',ProdImage='" +imgs+ "' WHERE ProdID=" + this.pID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully");
                    conn.Close();
                   

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(error);
            }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.pID.Text == "")
                {
                    MessageBox.Show("Please Select Product");
                }
                else
                {

                    conn.Open();
                    String query = "DELETE FROM ProductTbl WHERE ProdID=" + this.pID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CleanData() {
            this.pID.Text = "";
            this.pName.Text = "";
            this.pQuantity.Text = "";
            this.pSize.Text = "";
            this.pPrize.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    String imageLocation = openFileDialog.FileName;
                    ItemImage.ImageLocation = imageLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CleanData();
            Populate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
            this.Hide();
        }

        private void catCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
           

        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            conn.Close();
            try
            {
                conn.Open();
                String query = "SELECT ProdID,ProdName,ProdQty,ProdSize,ProdPrize,ProdCat FROM ProductTbl WHERE ProdCat='" + this.comboBox2.SelectedValue.ToString() + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(SDA);
                var ds = new DataSet();
                SDA.Fill(ds);
                pdDGV.DataSource = ds.Tables[0];
                SDA.Dispose();
                conn.Close();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

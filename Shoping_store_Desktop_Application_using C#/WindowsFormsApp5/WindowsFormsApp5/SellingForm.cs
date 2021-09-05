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
using System.IO;

namespace WindowsFormsApp5
{
    public partial class SellingForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=breeze_store_db;Integrated Security=True;Connect Timeout=30");
        int n = 0;
        int totalSum = 0;
        int GrdTotal = 0;
        public SellingForm()
        {
            InitializeComponent();
        }

        private void Populate()
        {

            conn.Open();
            String query = "SELECT ProdID,ProdName,ProdPrize,ProdCat FROM ProductTbl";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(SDA);
            var ds = new DataSet();
            SDA.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            SDA.Dispose();
            conn.Close();
        }

        private void PopulateBill()
        {

            conn.Open();
            String query = "SELECT * FROM BillTbl";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(SDA);
            var ds = new DataSet();
            SDA.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            SDA.Dispose();
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.pID.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.pName.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.pPrize.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            this.catCombo.SelectedValue = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            try
            {
                conn.Open();
                String query = "SELECT ProdImage FROM ProductTbl";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable("ProductTbl");
                SDA.Fill(dt);
                DataRow row = dt.Rows[e.RowIndex];
                byte[] img = (byte[])row[0];
                try
                {
                    MemoryStream ms = new MemoryStream(img);
                    this.ItemImage.Image = Image.FromStream(ms);
                }
                catch (Exception ex)
                {
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

        private void SellingForm_Load(object sender, EventArgs e)
        {
            Populate();
            FillCombo();
            PopulateBill();
            this.sellerNamelbl.Text = Form1.sellerName;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Date.Text = DateTime.Today.Day.ToString()+"/"+ DateTime.Today.Month.ToString() + "/"+DateTime.Today.Year.ToString();
        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            if (this.pQuantity.Text == "")
            {
                MessageBox.Show("Please Mention Quantity");
            }
            else
            {
                n++;
                totalSum=Convert.ToInt32(this.pPrize.Text) * Convert.ToInt32(this.pQuantity.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(sellingDGV);
                newRow.Cells[0].Value = n;
                newRow.Cells[1].Value = this.pName.Text;
                newRow.Cells[2].Value = this.pPrize.Text;
                newRow.Cells[3].Value = this.pQuantity.Text;
                newRow.Cells[4].Value = totalSum;
                sellingDGV.Rows.Add(newRow);
                GrdTotal += totalSum;
                this.Amount.Text = GrdTotal.ToString();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.pQuantity.Text=="")
                {
                    MessageBox.Show("Missing Quantity");
                }
                else
                {


                    conn.Open();
                    string query = String.Format("INSERT INTO BillTbl VALUES({0},'{1}','{2}',{3})",n, sellerNamelbl.Text, Date.Text, Convert.ToInt32(Amount.Text));
                    SqlCommand sql = new SqlCommand(query, conn);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Order Placed Successfully!");
                    conn.Close();
                    PopulateBill();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("BREEZESHOPPINGCENTER",new Font("Century Gothic",25,FontStyle.Bold),Brushes.Red,new Point(230));
            e.Graphics.DrawString("Bill Recipt", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Black, new Point(330,70));
            e.Graphics.DrawString("Bill_ID : "+this.dataGridView2.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100,150));
            e.Graphics.DrawString("Name : "+ this.dataGridView2.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 200));
            e.Graphics.DrawString("Date : " + this.dataGridView2.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 250));
            e.Graphics.DrawString("Total Amount : " + this.dataGridView2.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 300));
            e.Graphics.DrawString("CodeSpace ", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.Blue, new Point(100, 400));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK) {
                printDocument1.Print();
            }
        }
        private void FillCombo()
        {
            conn.Open();
            SqlCommand sql = new SqlCommand("SELECT CatName FROM CatagoryTbl", conn);
            SqlDataReader rdr;
            rdr = sql.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(String));
            dt.Load(rdr);
            catCombo.ValueMember = "catName";
            catCombo.DataSource = dt;
            rdr.Close();
            conn.Close();

        }

        private void catCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String query = "SELECT ProdID,ProdName,ProdPrize,ProdCat FROM ProductTbl WHERE ProdCat='" + this.catCombo.SelectedValue.ToString() + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(SDA);
                var ds = new DataSet();
                SDA.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                    conn.Open();
                    String query = "DELETE FROM BillTbl";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Deleted Successfully");
                    conn.Close();
                    PopulateBill();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sellingDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class Form1 : Form
    {
        public static string sellerName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=breeze_store_db;Integrated Security=True;Connect Timeout=30");
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (this.userNametxtBox.Text == "" || this.passwordtxtBox.Text == "")
            {
                MessageBox.Show("Please Enter userName and Password");
            }
            else
            {
                if (this.selectRole.SelectedIndex > -1) {

                    if (this.selectRole.SelectedItem.ToString() == "ADMIN")
                    {
                        if (this.userNametxtBox.Text == "Admin" && this.passwordtxtBox.Text == "Admin")
                        {
                            ProductsForm prod = new ProductsForm();
                            prod.Show();
                            this.Hide();
                        }
                        else
                            MessageBox.Show("Please Enter Correct INFO!");
                    }
                    else if (this.selectRole.SelectedItem.ToString() == "SELLER")
                    {
                        //MessageBox.Show("You are Seller");
                        conn.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select count(8) FROM SellerTbl WHERE SellerName='"+this.userNametxtBox.Text+"' and SellerPassword='"+this.passwordtxtBox.Text+"'",conn);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            sellerName = this.userNametxtBox.Text;
                            SellingForm sell = new SellingForm();
                            sell.Show();
                            this.Hide();
                            conn.Close();
                        }
                        else
                            MessageBox.Show("Wrong Password And UserName");
                        conn.Close();



                    } 
                }
                else
                    MessageBox.Show("Please, Select Role");

            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.userNametxtBox.Text = "";
            this.passwordtxtBox.Text = "";
        }
    }
}

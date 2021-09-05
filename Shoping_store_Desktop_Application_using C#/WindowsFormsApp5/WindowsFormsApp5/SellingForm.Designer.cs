
namespace WindowsFormsApp5
{
    partial class SellingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddToCart = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sellingDGV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemImage = new System.Windows.Forms.PictureBox();
            this.catCombo = new System.Windows.Forms.ComboBox();
            this.pPrize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sellerNamelbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.logOut = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddToCart);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.sellingDGV);
            this.panel1.Controls.Add(this.ItemImage);
            this.panel1.Controls.Add(this.catCombo);
            this.panel1.Controls.Add(this.pPrize);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pQuantity);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.sellerNamelbl);
            this.panel1.Location = new System.Drawing.Point(138, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 595);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(334, 459);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.DividerHeight = 1;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(581, 98);
            this.dataGridView2.TabIndex = 36;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(338, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Selling List";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Amount.Location = new System.Drawing.Point(830, 431);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(35, 25);
            this.Amount.TabIndex = 34;
            this.Amount.Text = "Rs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(749, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Amount";
            // 
            // AddToCart
            // 
            this.AddToCart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddToCart.Location = new System.Drawing.Point(7, 180);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(300, 31);
            this.AddToCart.TabIndex = 32;
            this.AddToCart.Text = "Add To Cart";
            this.AddToCart.UseVisualStyleBackColor = false;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Date.Location = new System.Drawing.Point(806, 9);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(53, 25);
            this.Date.TabIndex = 31;
            this.Date.Text = "Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DividerHeight = 1;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(307, 340);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(180, 217);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 29);
            this.button5.TabIndex = 29;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(751, 560);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 29);
            this.button4.TabIndex = 28;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(835, 560);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 29);
            this.button3.TabIndex = 27;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(667, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 29);
            this.button2.TabIndex = 26;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sellingDGV
            // 
            this.sellingDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellingDGV.BackgroundColor = System.Drawing.Color.White;
            this.sellingDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sellingDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sellingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellingDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.Prize,
            this.Quantity,
            this.Total});
            this.sellingDGV.Location = new System.Drawing.Point(334, 308);
            this.sellingDGV.Name = "sellingDGV";
            this.sellingDGV.ReadOnly = true;
            this.sellingDGV.RowHeadersVisible = false;
            this.sellingDGV.RowHeadersWidth = 51;
            this.sellingDGV.RowTemplate.DividerHeight = 1;
            this.sellingDGV.RowTemplate.Height = 24;
            this.sellingDGV.RowTemplate.ReadOnly = true;
            this.sellingDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sellingDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellingDGV.Size = new System.Drawing.Size(579, 120);
            this.sellingDGV.TabIndex = 23;
            this.sellingDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellingDGV_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ProdID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "ProdName";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Prize
            // 
            this.Prize.HeaderText = "Prize";
            this.Prize.MinimumWidth = 6;
            this.Prize.Name = "Prize";
            this.Prize.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // ItemImage
            // 
            this.ItemImage.Image = ((System.Drawing.Image)(resources.GetObject("ItemImage.Image")));
            this.ItemImage.Location = new System.Drawing.Point(334, 50);
            this.ItemImage.Name = "ItemImage";
            this.ItemImage.Size = new System.Drawing.Size(579, 252);
            this.ItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ItemImage.TabIndex = 21;
            this.ItemImage.TabStop = false;
            // 
            // catCombo
            // 
            this.catCombo.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.catCombo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.catCombo.FormattingEnabled = true;
            this.catCombo.Location = new System.Drawing.Point(3, 218);
            this.catCombo.Name = "catCombo";
            this.catCombo.Size = new System.Drawing.Size(171, 28);
            this.catCombo.TabIndex = 18;
            this.catCombo.Text = "Select Catagory";
            this.catCombo.SelectionChangeCommitted += new System.EventHandler(this.catCombo_SelectionChangeCommitted);
            // 
            // pPrize
            // 
            this.pPrize.Enabled = false;
            this.pPrize.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.pPrize.Location = new System.Drawing.Point(136, 146);
            this.pPrize.Name = "pPrize";
            this.pPrize.Size = new System.Drawing.Size(171, 28);
            this.pPrize.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Highlight;
            this.label10.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(9, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "Prize";
            // 
            // pQuantity
            // 
            this.pQuantity.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.pQuantity.Location = new System.Drawing.Point(136, 112);
            this.pQuantity.Name = "pQuantity";
            this.pQuantity.Size = new System.Drawing.Size(171, 28);
            this.pQuantity.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(9, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Quantity";
            // 
            // pName
            // 
            this.pName.Enabled = false;
            this.pName.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.pName.Location = new System.Drawing.Point(136, 78);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(171, 28);
            this.pName.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(9, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Prod_Name";
            // 
            // pID
            // 
            this.pID.Enabled = false;
            this.pID.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.pID.Location = new System.Drawing.Point(136, 44);
            this.pID.Name = "pID";
            this.pID.Size = new System.Drawing.Size(171, 28);
            this.pID.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(9, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bill_ID";
            // 
            // sellerNamelbl
            // 
            this.sellerNamelbl.AutoSize = true;
            this.sellerNamelbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.sellerNamelbl.Font = new System.Drawing.Font("Californian FB", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerNamelbl.ForeColor = System.Drawing.SystemColors.Control;
            this.sellerNamelbl.Location = new System.Drawing.Point(6, 0);
            this.sellerNamelbl.Name = "sellerNamelbl";
            this.sellerNamelbl.Size = new System.Drawing.Size(85, 38);
            this.sellerNamelbl.TabIndex = 6;
            this.sellerNamelbl.Text = "Seller";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(1028, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 28);
            this.label4.TabIndex = 36;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // logOut
            // 
            this.logOut.AutoSize = true;
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logOut.Location = new System.Drawing.Point(25, 603);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(77, 25);
            this.logOut.TabIndex = 37;
            this.logOut.Text = "LogOut";
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 643);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView sellingDGV;
        private System.Windows.Forms.PictureBox ItemImage;
        private System.Windows.Forms.ComboBox catCombo;
        private System.Windows.Forms.TextBox pPrize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sellerNamelbl;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label logOut;
    }
}
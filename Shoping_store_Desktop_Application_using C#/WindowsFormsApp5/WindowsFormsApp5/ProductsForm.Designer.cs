
namespace WindowsFormsApp5
{
    partial class ProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pdDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ItemImage = new System.Windows.Forms.PictureBox();
            this.catCombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pPrize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pSize = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.pdDGV);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ItemImage);
            this.panel1.Controls.Add(this.catCombo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pPrize);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pSize);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pQuantity);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(140, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 601);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(817, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 29);
            this.button5.TabIndex = 29;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(212, 361);
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
            this.button3.Location = new System.Drawing.Point(116, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 29);
            this.button3.TabIndex = 27;
            this.button3.Text = "EDIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(20, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 29);
            this.button2.TabIndex = 26;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.comboBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.comboBox2.Location = new System.Drawing.Point(644, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(167, 28);
            this.comboBox2.TabIndex = 25;
            this.comboBox2.Text = "Select Catagory";
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // pdDGV
            // 
            this.pdDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pdDGV.BackgroundColor = System.Drawing.Color.White;
            this.pdDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pdDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.pdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pdDGV.Location = new System.Drawing.Point(292, 100);
            this.pdDGV.Name = "pdDGV";
            this.pdDGV.ReadOnly = true;
            this.pdDGV.RowHeadersVisible = false;
            this.pdDGV.RowHeadersWidth = 51;
            this.pdDGV.RowTemplate.DividerHeight = 1;
            this.pdDGV.RowTemplate.Height = 24;
            this.pdDGV.RowTemplate.ReadOnly = true;
            this.pdDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pdDGV.Size = new System.Drawing.Size(621, 498);
            this.pdDGV.TabIndex = 23;
            this.pdDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pdDGV_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(68, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 26);
            this.button1.TabIndex = 22;
            this.button1.Text = "Upload Image";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ItemImage
            // 
            this.ItemImage.Image = ((System.Drawing.Image)(resources.GetObject("ItemImage.Image")));
            this.ItemImage.Location = new System.Drawing.Point(57, 417);
            this.ItemImage.Name = "ItemImage";
            this.ItemImage.Size = new System.Drawing.Size(214, 143);
            this.ItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ItemImage.TabIndex = 21;
            this.ItemImage.TabStop = false;
            // 
            // catCombo
            // 
            this.catCombo.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.catCombo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.catCombo.FormattingEnabled = true;
            this.catCombo.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.catCombo.Location = new System.Drawing.Point(104, 290);
            this.catCombo.Name = "catCombo";
            this.catCombo.Size = new System.Drawing.Size(167, 28);
            this.catCombo.TabIndex = 18;
            this.catCombo.Text = "Select Catagory";
            this.catCombo.SelectionChangeCommitted += new System.EventHandler(this.catCombo_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Highlight;
            this.label11.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(13, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "Catagory";
            // 
            // pPrize
            // 
            this.pPrize.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.pPrize.Location = new System.Drawing.Point(100, 243);
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
            this.label10.Location = new System.Drawing.Point(13, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "Prize";
            // 
            // pSize
            // 
            this.pSize.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.pSize.Location = new System.Drawing.Point(100, 202);
            this.pSize.Name = "pSize";
            this.pSize.Size = new System.Drawing.Size(171, 28);
            this.pSize.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Highlight;
            this.label9.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(13, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "Size";
            // 
            // pQuantity
            // 
            this.pQuantity.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.pQuantity.Location = new System.Drawing.Point(100, 163);
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
            this.label8.Location = new System.Drawing.Point(13, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Quantity";
            // 
            // pName
            // 
            this.pName.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.pName.Location = new System.Drawing.Point(100, 129);
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
            this.label7.Location = new System.Drawing.Point(13, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Name";
            // 
            // pID
            // 
            this.pID.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.pID.Location = new System.Drawing.Point(100, 97);
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
            this.label6.Location = new System.Drawing.Point(13, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Californian FB", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(393, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 38);
            this.label5.TabIndex = 6;
            this.label5.Text = "Manage Store";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(1028, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Font = new System.Drawing.Font("Californian FB", 13.8F);
            this.button6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button6.Location = new System.Drawing.Point(12, 94);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 39);
            this.button6.TabIndex = 30;
            this.button6.Text = "Sellers";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Font = new System.Drawing.Font("Californian FB", 13.8F);
            this.button7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button7.Location = new System.Drawing.Point(12, 151);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 39);
            this.button7.TabIndex = 31;
            this.button7.Text = "Catagory";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // logOut
            // 
            this.logOut.AutoSize = true;
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logOut.Location = new System.Drawing.Point(30, 605);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(77, 25);
            this.logOut.TabIndex = 38;
            this.logOut.Text = "LogOut";
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 643);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsForm";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pPrize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox catCombo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView pdDGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ItemImage;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label logOut;
    }
}
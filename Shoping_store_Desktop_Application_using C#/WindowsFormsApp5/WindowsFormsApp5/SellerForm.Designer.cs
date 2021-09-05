
namespace WindowsFormsApp5
{
    partial class SellerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sellerDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.sellerImage = new System.Windows.Forms.PictureBox();
            this.sPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.sellerDGV);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.sellerImage);
            this.panel1.Controls.Add(this.sPhone);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.sAge);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.sName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.sID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(140, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 601);
            this.panel1.TabIndex = 1;
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
            // sellerDGV
            // 
            this.sellerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellerDGV.BackgroundColor = System.Drawing.Color.White;
            this.sellerDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sellerDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sellerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellerDGV.Location = new System.Drawing.Point(296, 64);
            this.sellerDGV.Name = "sellerDGV";
            this.sellerDGV.RowHeadersVisible = false;
            this.sellerDGV.RowHeadersWidth = 51;
            this.sellerDGV.RowTemplate.DividerHeight = 1;
            this.sellerDGV.RowTemplate.Height = 24;
            this.sellerDGV.RowTemplate.ReadOnly = true;
            this.sellerDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sellerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellerDGV.Size = new System.Drawing.Size(607, 528);
            this.sellerDGV.TabIndex = 23;
            this.sellerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellerDGV_CellContentClick);
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
            // sellerImage
            // 
            this.sellerImage.Image = ((System.Drawing.Image)(resources.GetObject("sellerImage.Image")));
            this.sellerImage.Location = new System.Drawing.Point(57, 417);
            this.sellerImage.Name = "sellerImage";
            this.sellerImage.Size = new System.Drawing.Size(214, 143);
            this.sellerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sellerImage.TabIndex = 21;
            this.sellerImage.TabStop = false;
            // 
            // sPhone
            // 
            this.sPhone.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.sPhone.Location = new System.Drawing.Point(100, 202);
            this.sPhone.Name = "sPhone";
            this.sPhone.Size = new System.Drawing.Size(171, 28);
            this.sPhone.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Highlight;
            this.label9.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(13, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "Phone";
            // 
            // sAge
            // 
            this.sAge.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.sAge.Location = new System.Drawing.Point(100, 163);
            this.sAge.Name = "sAge";
            this.sAge.Size = new System.Drawing.Size(171, 28);
            this.sAge.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(13, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Age";
            // 
            // sName
            // 
            this.sName.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.sName.Location = new System.Drawing.Point(100, 129);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(171, 28);
            this.sName.TabIndex = 10;
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
            // sID
            // 
            this.sID.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.sID.Location = new System.Drawing.Point(100, 97);
            this.sID.Name = "sID";
            this.sID.Size = new System.Drawing.Size(171, 28);
            this.sID.TabIndex = 8;
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
            this.label5.Size = new System.Drawing.Size(201, 38);
            this.label5.TabIndex = 6;
            this.label5.Text = "Manage Sellers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(1028, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Font = new System.Drawing.Font("Californian FB", 13.8F);
            this.button6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button6.Location = new System.Drawing.Point(12, 127);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 39);
            this.button6.TabIndex = 31;
            this.button6.Text = "Products";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Font = new System.Drawing.Font("Californian FB", 13.8F);
            this.button7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button7.Location = new System.Drawing.Point(12, 185);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 39);
            this.button7.TabIndex = 32;
            this.button7.Text = "Catagories";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.password.Location = new System.Drawing.Point(100, 236);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(171, 28);
            this.password.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Password";
            // 
            // logOut
            // 
            this.logOut.AutoSize = true;
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logOut.Location = new System.Drawing.Point(36, 606);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(77, 25);
            this.logOut.TabIndex = 40;
            this.logOut.Text = "LogOut";
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // SellerForm
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
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView sellerDGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox sellerImage;
        private System.Windows.Forms.TextBox sPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label logOut;
    }
}
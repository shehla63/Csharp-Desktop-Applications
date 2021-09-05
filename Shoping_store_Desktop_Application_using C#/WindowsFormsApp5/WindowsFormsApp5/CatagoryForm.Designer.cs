
namespace WindowsFormsApp5
{
    partial class CatagoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteCat = new System.Windows.Forms.Button();
            this.editCat = new System.Windows.Forms.Button();
            this.addCat = new System.Windows.Forms.Button();
            this.catDGV = new System.Windows.Forms.DataGridView();
            this.catDes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.catName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.catID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.deleteCat);
            this.panel1.Controls.Add(this.editCat);
            this.panel1.Controls.Add(this.addCat);
            this.panel1.Controls.Add(this.catDGV);
            this.panel1.Controls.Add(this.catDes);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.catName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.catID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(146, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 601);
            this.panel1.TabIndex = 2;
            // 
            // deleteCat
            // 
            this.deleteCat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteCat.Location = new System.Drawing.Point(45, 485);
            this.deleteCat.Name = "deleteCat";
            this.deleteCat.Size = new System.Drawing.Size(258, 29);
            this.deleteCat.TabIndex = 28;
            this.deleteCat.Text = "DELETE";
            this.deleteCat.UseVisualStyleBackColor = false;
            this.deleteCat.Click += new System.EventHandler(this.deleteCat_Click);
            // 
            // editCat
            // 
            this.editCat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editCat.Location = new System.Drawing.Point(45, 450);
            this.editCat.Name = "editCat";
            this.editCat.Size = new System.Drawing.Size(258, 29);
            this.editCat.TabIndex = 27;
            this.editCat.Text = "EDIT";
            this.editCat.UseVisualStyleBackColor = false;
            this.editCat.Click += new System.EventHandler(this.editCat_Click);
            // 
            // addCat
            // 
            this.addCat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addCat.Location = new System.Drawing.Point(45, 415);
            this.addCat.Name = "addCat";
            this.addCat.Size = new System.Drawing.Size(258, 29);
            this.addCat.TabIndex = 26;
            this.addCat.Text = "ADD";
            this.addCat.UseVisualStyleBackColor = false;
            this.addCat.Click += new System.EventHandler(this.addCat_Click);
            // 
            // catDGV
            // 
            this.catDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.catDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.catDGV.BackgroundColor = System.Drawing.Color.White;
            this.catDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.catDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.catDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.catDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catDGV.Location = new System.Drawing.Point(325, 72);
            this.catDGV.Name = "catDGV";
            this.catDGV.RowHeadersVisible = false;
            this.catDGV.RowHeadersWidth = 51;
            this.catDGV.RowTemplate.DividerHeight = 1;
            this.catDGV.RowTemplate.Height = 24;
            this.catDGV.RowTemplate.ReadOnly = true;
            this.catDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.catDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.catDGV.Size = new System.Drawing.Size(578, 520);
            this.catDGV.TabIndex = 23;
            this.catDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catDGV_CellContentClick);
            // 
            // catDes
            // 
            this.catDes.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.catDes.Location = new System.Drawing.Point(107, 194);
            this.catDes.Multiline = true;
            this.catDes.Name = "catDes";
            this.catDes.Size = new System.Drawing.Size(181, 52);
            this.catDes.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(3, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Description";
            // 
            // catName
            // 
            this.catName.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.catName.Location = new System.Drawing.Point(107, 156);
            this.catName.Name = "catName";
            this.catName.Size = new System.Drawing.Size(171, 28);
            this.catName.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(13, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Name";
            // 
            // catID
            // 
            this.catID.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.catID.Location = new System.Drawing.Point(107, 122);
            this.catID.Name = "catID";
            this.catID.Size = new System.Drawing.Size(171, 28);
            this.catID.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(16, 122);
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
            this.label5.Location = new System.Drawing.Point(307, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 38);
            this.label5.TabIndex = 6;
            this.label5.Text = "Manage Catagories";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(1034, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 28);
            this.label4.TabIndex = 31;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Font = new System.Drawing.Font("Californian FB", 13.8F);
            this.button6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button6.Location = new System.Drawing.Point(12, 152);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 39);
            this.button6.TabIndex = 32;
            this.button6.Text = "Sellers";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Californian FB", 13.8F);
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(12, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 39);
            this.button1.TabIndex = 33;
            this.button1.Text = "Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logOut
            // 
            this.logOut.AutoSize = true;
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logOut.Location = new System.Drawing.Point(39, 597);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(77, 25);
            this.logOut.TabIndex = 39;
            this.logOut.Text = "LogOut";
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // CatagoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 643);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatagoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatagoryForm";
            this.Load += new System.EventHandler(this.CatagoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteCat;
        private System.Windows.Forms.Button editCat;
        private System.Windows.Forms.Button addCat;
        private System.Windows.Forms.DataGridView catDGV;
        private System.Windows.Forms.TextBox catDes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox catName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox catID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label logOut;
    }
}
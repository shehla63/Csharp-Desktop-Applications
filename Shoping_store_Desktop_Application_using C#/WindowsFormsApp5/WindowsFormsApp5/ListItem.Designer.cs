
namespace WindowsFormsApp5
{
    partial class ListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListItem));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Name = new System.Windows.Forms.Label();
            this.Prize = new System.Windows.Forms.Label();
            this.sizeCombo = new System.Windows.Forms.ComboBox();
            this.buyItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(128, 17);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(56, 17);
            this.Name.TabIndex = 1;
            this.Name.Text = "ListItem";
            // 
            // Prize
            // 
            this.Prize.AutoSize = true;
            this.Prize.Location = new System.Drawing.Point(128, 69);
            this.Prize.Name = "Prize";
            this.Prize.Size = new System.Drawing.Size(40, 17);
            this.Prize.TabIndex = 2;
            this.Prize.Text = "Prize";
            // 
            // sizeCombo
            // 
            this.sizeCombo.FormattingEnabled = true;
            this.sizeCombo.Location = new System.Drawing.Point(131, 41);
            this.sizeCombo.Name = "sizeCombo";
            this.sizeCombo.Size = new System.Drawing.Size(121, 24);
            this.sizeCombo.TabIndex = 3;
            this.sizeCombo.Text = "Size";
            // 
            // buyItem
            // 
            this.buyItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buyItem.Location = new System.Drawing.Point(308, 69);
            this.buyItem.Name = "buyItem";
            this.buyItem.Size = new System.Drawing.Size(163, 24);
            this.buyItem.TabIndex = 4;
            this.buyItem.Text = "Add to Cart";
            this.buyItem.UseVisualStyleBackColor = false;
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buyItem);
            this.Controls.Add(this.sizeCombo);
            this.Controls.Add(this.Prize);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.pictureBox1);
            this.Name.Text = "ListItem";
            this.Size = new System.Drawing.Size(474, 106);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Prize;
        private System.Windows.Forms.ComboBox sizeCombo;
        private System.Windows.Forms.Button buyItem;
    }
}

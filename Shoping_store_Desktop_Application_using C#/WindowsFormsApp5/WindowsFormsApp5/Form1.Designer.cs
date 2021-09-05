
namespace WindowsFormsApp5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userNametxtBox = new System.Windows.Forms.TextBox();
            this.passwordtxtBox = new System.Windows.Forms.TextBox();
            this.selectRole = new System.Windows.Forms.ComboBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 560);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 303);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(90, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Breeze store";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(42, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Welcome to the";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(322, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(457, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(469, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // userNametxtBox
            // 
            this.userNametxtBox.Font = new System.Drawing.Font("Californian FB", 13.8F);
            this.userNametxtBox.Location = new System.Drawing.Point(578, 247);
            this.userNametxtBox.Multiline = true;
            this.userNametxtBox.Name = "userNametxtBox";
            this.userNametxtBox.Size = new System.Drawing.Size(342, 35);
            this.userNametxtBox.TabIndex = 4;
            // 
            // passwordtxtBox
            // 
            this.passwordtxtBox.Font = new System.Drawing.Font("Californian FB", 13.8F);
            this.passwordtxtBox.Location = new System.Drawing.Point(578, 303);
            this.passwordtxtBox.Multiline = true;
            this.passwordtxtBox.Name = "passwordtxtBox";
            this.passwordtxtBox.Size = new System.Drawing.Size(342, 34);
            this.passwordtxtBox.TabIndex = 5;
            // 
            // selectRole
            // 
            this.selectRole.Font = new System.Drawing.Font("Californian FB", 13.8F);
            this.selectRole.ForeColor = System.Drawing.SystemColors.Highlight;
            this.selectRole.FormattingEnabled = true;
            this.selectRole.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.selectRole.Location = new System.Drawing.Point(578, 186);
            this.selectRole.Name = "selectRole";
            this.selectRole.Size = new System.Drawing.Size(342, 35);
            this.selectRole.TabIndex = 6;
            this.selectRole.Text = "Select Role";
            // 
            // loginBtn
            // 
            this.loginBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loginBtn.Location = new System.Drawing.Point(756, 357);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(164, 37);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // clear
            // 
            this.clear.AutoSize = true;
            this.clear.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.Highlight;
            this.clear.Location = new System.Drawing.Point(856, 397);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(64, 28);
            this.clear.TabIndex = 8;
            this.clear.Text = "Clear";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(960, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.selectRole);
            this.Controls.Add(this.passwordtxtBox);
            this.Controls.Add(this.userNametxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userNametxtBox;
        private System.Windows.Forms.TextBox passwordtxtBox;
        private System.Windows.Forms.ComboBox selectRole;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label clear;
        private System.Windows.Forms.Label label6;
    }
}


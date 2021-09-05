
namespace weatherApplication
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cityName = new System.Windows.Forms.Label();
            this.tempCelsis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.windSpeed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.tempFarh = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.countryName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pressure = new System.Windows.Forms.Label();
            this.press = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Select City";
            // 
            // cityName
            // 
            this.cityName.AutoSize = true;
            this.cityName.BackColor = System.Drawing.Color.Transparent;
            this.cityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityName.ForeColor = System.Drawing.Color.SandyBrown;
            this.cityName.Location = new System.Drawing.Point(274, 79);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(167, 39);
            this.cityName.TabIndex = 1;
            this.cityName.Text = "CityName";
            // 
            // tempCelsis
            // 
            this.tempCelsis.AutoSize = true;
            this.tempCelsis.BackColor = System.Drawing.Color.Transparent;
            this.tempCelsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempCelsis.ForeColor = System.Drawing.Color.White;
            this.tempCelsis.Location = new System.Drawing.Point(460, 194);
            this.tempCelsis.Name = "tempCelsis";
            this.tempCelsis.Size = new System.Drawing.Size(259, 48);
            this.tempCelsis.TabIndex = 2;
            this.tempCelsis.Text = "Temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(253, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Condition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(253, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "humidity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(253, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Wind Speed";
            // 
            // condition
            // 
            this.condition.AutoSize = true;
            this.condition.BackColor = System.Drawing.Color.Transparent;
            this.condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condition.ForeColor = System.Drawing.Color.LawnGreen;
            this.condition.Location = new System.Drawing.Point(514, 341);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(28, 26);
            this.condition.TabIndex = 6;
            this.condition.Text = "C";
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.BackColor = System.Drawing.Color.Transparent;
            this.humidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidity.ForeColor = System.Drawing.Color.LawnGreen;
            this.humidity.Location = new System.Drawing.Point(514, 376);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(28, 26);
            this.humidity.TabIndex = 7;
            this.humidity.Text = "C";
            // 
            // windSpeed
            // 
            this.windSpeed.AutoSize = true;
            this.windSpeed.BackColor = System.Drawing.Color.Transparent;
            this.windSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeed.ForeColor = System.Drawing.Color.LawnGreen;
            this.windSpeed.Location = new System.Drawing.Point(514, 451);
            this.windSpeed.Name = "windSpeed";
            this.windSpeed.Size = new System.Drawing.Size(28, 26);
            this.windSpeed.TabIndex = 8;
            this.windSpeed.Text = "C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(253, 543);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Last Update on:";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.LawnGreen;
            this.date.Location = new System.Drawing.Point(397, 543);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(119, 20);
            this.date.TabIndex = 10;
            this.date.Text = "Date and Time";
            // 
            // tempFarh
            // 
            this.tempFarh.AutoSize = true;
            this.tempFarh.BackColor = System.Drawing.Color.Transparent;
            this.tempFarh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempFarh.ForeColor = System.Drawing.Color.Yellow;
            this.tempFarh.Location = new System.Drawing.Point(503, 242);
            this.tempFarh.Name = "tempFarh";
            this.tempFarh.Size = new System.Drawing.Size(39, 29);
            this.tempFarh.TabIndex = 11;
            this.tempFarh.Text = "`C";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::weatherApplication.Properties.Resources._6f4adf551b05fda7db635aecddd560a0;
            this.pictureBox1.Location = new System.Drawing.Point(281, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // countryName
            // 
            this.countryName.AutoSize = true;
            this.countryName.BackColor = System.Drawing.Color.Transparent;
            this.countryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryName.ForeColor = System.Drawing.Color.White;
            this.countryName.Location = new System.Drawing.Point(286, 131);
            this.countryName.Name = "countryName";
            this.countryName.Size = new System.Drawing.Size(83, 26);
            this.countryName.TabIndex = 13;
            this.countryName.Text = "country";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(13, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.BackColor = System.Drawing.Color.Transparent;
            this.pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressure.ForeColor = System.Drawing.Color.White;
            this.pressure.Location = new System.Drawing.Point(253, 414);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(96, 26);
            this.pressure.TabIndex = 15;
            this.pressure.Text = "pressure";
            // 
            // press
            // 
            this.press.AutoSize = true;
            this.press.BackColor = System.Drawing.Color.Transparent;
            this.press.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.press.ForeColor = System.Drawing.Color.LawnGreen;
            this.press.Location = new System.Drawing.Point(514, 414);
            this.press.Name = "press";
            this.press.Size = new System.Drawing.Size(28, 26);
            this.press.TabIndex = 16;
            this.press.Text = "C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::weatherApplication.Properties.Resources.photo_1528818955841_a7f1425131b5;
            this.ClientSize = new System.Drawing.Size(1136, 666);
            this.Controls.Add(this.press);
            this.Controls.Add(this.pressure);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.countryName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tempFarh);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.windSpeed);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tempCelsis);
            this.Controls.Add(this.cityName);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label cityName;
        private System.Windows.Forms.Label tempCelsis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label windSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label tempFarh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label countryName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Label press;
    }
}


namespace Student_Databse_App
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
            this.studentList = new System.Windows.Forms.ListBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.nationality = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentList
            // 
            this.studentList.FormattingEnabled = true;
            this.studentList.Location = new System.Drawing.Point(32, 49);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(178, 316);
            this.studentList.TabIndex = 0;
            this.studentList.SelectedIndexChanged += new System.EventHandler(this.studentList_SelectedIndexChanged);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(260, 48);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(269, 20);
            this.firstName.TabIndex = 1;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(260, 91);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(269, 20);
            this.lastName.TabIndex = 2;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(260, 127);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(269, 20);
            this.city.TabIndex = 3;
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(260, 165);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(269, 20);
            this.state.TabIndex = 4;
            // 
            // nationality
            // 
            this.nationality.Location = new System.Drawing.Point(260, 211);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(269, 20);
            this.nationality.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(261, 270);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 41);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add new Record";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(409, 270);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(120, 41);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(261, 322);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(120, 41);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(409, 322);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 41);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 415);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nationality);
            this.Controls.Add(this.state);
            this.Controls.Add(this.city);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.studentList);
            this.Name = "Form1";
            this.Text = "Noman_Aijaz_Student_Management_App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.TextBox nationality;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
    }
}



namespace Connect4Game
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
            this.Players = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.Label();
            this.boardSize = new System.Windows.Forms.Label();
            this.Rows = new System.Windows.Forms.Label();
            this.columns = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.numberOfRows = new System.Windows.Forms.NumericUpDown();
            this.numberOfColumns = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // Players
            // 
            this.Players.AutoSize = true;
            this.Players.Location = new System.Drawing.Point(124, 30);
            this.Players.Name = "Players";
            this.Players.Size = new System.Drawing.Size(55, 17);
            this.Players.TabIndex = 0;
            this.Players.Text = "Players";
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Location = new System.Drawing.Point(218, 78);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(56, 17);
            this.player1.TabIndex = 1;
            this.player1.Text = "Player1";
            // 
            // boardSize
            // 
            this.boardSize.AutoSize = true;
            this.boardSize.Location = new System.Drawing.Point(124, 242);
            this.boardSize.Name = "boardSize";
            this.boardSize.Size = new System.Drawing.Size(77, 17);
            this.boardSize.TabIndex = 3;
            this.boardSize.Text = "Board Size";
            // 
            // Rows
            // 
            this.Rows.AutoSize = true;
            this.Rows.Location = new System.Drawing.Point(218, 297);
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(42, 17);
            this.Rows.TabIndex = 4;
            this.Rows.Text = "Rows";
            // 
            // columns
            // 
            this.columns.AutoSize = true;
            this.columns.Location = new System.Drawing.Point(395, 299);
            this.columns.Name = "columns";
            this.columns.Size = new System.Drawing.Size(62, 17);
            this.columns.TabIndex = 5;
            this.columns.Text = "Columns";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(179, 364);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(401, 43);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.OnStartButtonListener);
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(349, 75);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(179, 22);
            this.p1.TabIndex = 7;
            // 
            // p2
            // 
            this.p2.Enabled = false;
            this.p2.Location = new System.Drawing.Point(349, 121);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(179, 22);
            this.p2.TabIndex = 8;
            this.p2.Text = "Computer";
            // 
            // numberOfRows
            // 
            this.numberOfRows.Location = new System.Drawing.Point(278, 297);
            this.numberOfRows.Name = "numberOfRows";
            this.numberOfRows.Size = new System.Drawing.Size(71, 22);
            this.numberOfRows.TabIndex = 9;
            // 
            // numberOfColumns
            // 
            this.numberOfColumns.Location = new System.Drawing.Point(457, 295);
            this.numberOfColumns.Name = "numberOfColumns";
            this.numberOfColumns.Size = new System.Drawing.Size(71, 22);
            this.numberOfColumns.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(196, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Player2";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numberOfColumns);
            this.Controls.Add(this.numberOfRows);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.columns);
            this.Controls.Add(this.Rows);
            this.Controls.Add(this.boardSize);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.Players);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfColumns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Players;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label boardSize;
        private System.Windows.Forms.Label Rows;
        private System.Windows.Forms.Label columns;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.NumericUpDown numberOfRows;
        private System.Windows.Forms.NumericUpDown numberOfColumns;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


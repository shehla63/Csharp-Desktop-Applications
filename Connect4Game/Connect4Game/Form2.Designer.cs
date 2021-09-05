
namespace Connect4Game
{
    partial class Form2
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
            this.p1 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.player1Soce = new System.Windows.Forms.Label();
            this.player2Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Location = new System.Drawing.Point(12, 25);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(60, 17);
            this.p1.TabIndex = 0;
            this.p1.Text = "Player1:";
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Location = new System.Drawing.Point(151, 25);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(60, 17);
            this.p2.TabIndex = 1;
            this.p2.Text = "Player2:";
            // 
            // player1Soce
            // 
            this.player1Soce.AutoSize = true;
            this.player1Soce.Location = new System.Drawing.Point(78, 25);
            this.player1Soce.Name = "player1Soce";
            this.player1Soce.Size = new System.Drawing.Size(16, 17);
            this.player1Soce.TabIndex = 2;
            this.player1Soce.Text = "0";
            // 
            // player2Score
            // 
            this.player2Score.AutoSize = true;
            this.player2Score.Location = new System.Drawing.Point(217, 25);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(16, 17);
            this.player2Score.TabIndex = 3;
            this.player2Score.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.player1Soce);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label player1Soce;
        private System.Windows.Forms.Label player2Score;
    }
}
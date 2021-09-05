namespace FawadIjazAssigt
{
    partial class frmPlayersInfo
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
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblSetScore = new System.Windows.Forms.Label();
            this.txbxSetScore = new System.Windows.Forms.TextBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.txbxPlayer2 = new System.Windows.Forms.TextBox();
            this.txbxPlayer1 = new System.Windows.Forms.TextBox();
            this.lblEnterInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.IndianRed;
            this.btnStartGame.Font = new System.Drawing.Font("Kristen ITC", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.Yellow;
            this.btnStartGame.Location = new System.Drawing.Point(184, 376);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(180, 42);
            this.btnStartGame.TabIndex = 16;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lblSetScore
            // 
            this.lblSetScore.AutoSize = true;
            this.lblSetScore.BackColor = System.Drawing.Color.IndianRed;
            this.lblSetScore.ForeColor = System.Drawing.Color.Yellow;
            this.lblSetScore.Location = new System.Drawing.Point(124, 308);
            this.lblSetScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSetScore.Name = "lblSetScore";
            this.lblSetScore.Size = new System.Drawing.Size(94, 17);
            this.lblSetScore.TabIndex = 15;
            this.lblSetScore.Text = "Set the Score";
            // 
            // txbxSetScore
            // 
            this.txbxSetScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbxSetScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbxSetScore.Location = new System.Drawing.Point(240, 307);
            this.txbxSetScore.Margin = new System.Windows.Forms.Padding(4);
            this.txbxSetScore.MaxLength = 4;
            this.txbxSetScore.Name = "txbxSetScore";
            this.txbxSetScore.Size = new System.Drawing.Size(192, 22);
            this.txbxSetScore.TabIndex = 14;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.Color.IndianRed;
            this.lblPlayer2.ForeColor = System.Drawing.Color.Yellow;
            this.lblPlayer2.Location = new System.Drawing.Point(120, 239);
            this.lblPlayer2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(101, 17);
            this.lblPlayer2.TabIndex = 13;
            this.lblPlayer2.Text = "Player 2 Name";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.Color.IndianRed;
            this.lblPlayer1.ForeColor = System.Drawing.Color.Yellow;
            this.lblPlayer1.Location = new System.Drawing.Point(120, 198);
            this.lblPlayer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(101, 17);
            this.lblPlayer1.TabIndex = 12;
            this.lblPlayer1.Text = "Player 1 Name";
            // 
            // txbxPlayer2
            // 
            this.txbxPlayer2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbxPlayer2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbxPlayer2.Location = new System.Drawing.Point(240, 239);
            this.txbxPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.txbxPlayer2.MaxLength = 8;
            this.txbxPlayer2.Name = "txbxPlayer2";
            this.txbxPlayer2.Size = new System.Drawing.Size(192, 22);
            this.txbxPlayer2.TabIndex = 11;
            // 
            // txbxPlayer1
            // 
            this.txbxPlayer1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbxPlayer1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbxPlayer1.Location = new System.Drawing.Point(240, 198);
            this.txbxPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.txbxPlayer1.MaxLength = 8;
            this.txbxPlayer1.Name = "txbxPlayer1";
            this.txbxPlayer1.Size = new System.Drawing.Size(192, 22);
            this.txbxPlayer1.TabIndex = 10;
            // 
            // lblEnterInfo
            // 
            this.lblEnterInfo.AutoSize = true;
            this.lblEnterInfo.BackColor = System.Drawing.Color.IndianRed;
            this.lblEnterInfo.Font = new System.Drawing.Font("Kristen ITC", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterInfo.ForeColor = System.Drawing.Color.Yellow;
            this.lblEnterInfo.Location = new System.Drawing.Point(129, 119);
            this.lblEnterInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterInfo.Name = "lblEnterInfo";
            this.lblEnterInfo.Size = new System.Drawing.Size(275, 36);
            this.lblEnterInfo.TabIndex = 17;
            this.lblEnterInfo.Text = "Enter Information";
            this.lblEnterInfo.Click += new System.EventHandler(this.lblEnterInfo_Click);
            // 
            // frmPlayersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 451);
            this.Controls.Add(this.lblEnterInfo);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblSetScore);
            this.Controls.Add(this.txbxSetScore);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.txbxPlayer2);
            this.Controls.Add(this.txbxPlayer1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPlayersInfo";
            this.Text = "The Game of Groans: Player Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblSetScore;
        private System.Windows.Forms.TextBox txbxSetScore;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.TextBox txbxPlayer2;
        private System.Windows.Forms.TextBox txbxPlayer1;
        private System.Windows.Forms.Label lblEnterInfo;
    }
}
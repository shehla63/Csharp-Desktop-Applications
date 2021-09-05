namespace FawadIjazAssigt
{
    partial class frmMainGame
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
            this.btnKeepTurn = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.ProgressList = new System.Windows.Forms.ListBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.txbxPlayer1Score = new System.Windows.Forms.TextBox();
            this.txbxPlayer2Score = new System.Windows.Forms.TextBox();
            this.lblDice1 = new System.Windows.Forms.Label();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.txbxDice1 = new System.Windows.Forms.TextBox();
            this.txbxDice2 = new System.Windows.Forms.TextBox();
            this.lblTargetScore = new System.Windows.Forms.Label();
            this.lblSetScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.activePlayer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKeepTurn
            // 
            this.btnKeepTurn.BackColor = System.Drawing.Color.IndianRed;
            this.btnKeepTurn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeepTurn.ForeColor = System.Drawing.Color.Yellow;
            this.btnKeepTurn.Location = new System.Drawing.Point(573, 416);
            this.btnKeepTurn.Margin = new System.Windows.Forms.Padding(4);
            this.btnKeepTurn.Name = "btnKeepTurn";
            this.btnKeepTurn.Size = new System.Drawing.Size(173, 37);
            this.btnKeepTurn.TabIndex = 6;
            this.btnKeepTurn.Text = "Keep the Turn";
            this.btnKeepTurn.UseVisualStyleBackColor = false;
            this.btnKeepTurn.Click += new System.EventHandler(this.btn_Keep_Click);
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.IndianRed;
            this.btnPass.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPass.ForeColor = System.Drawing.Color.Yellow;
            this.btnPass.Location = new System.Drawing.Point(588, 357);
            this.btnPass.Margin = new System.Windows.Forms.Padding(4);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(133, 36);
            this.btnPass.TabIndex = 7;
            this.btnPass.Text = "Pass ON";
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.btn_Pass_Click);
            // 
            // ProgressList
            // 
            this.ProgressList.BackColor = System.Drawing.SystemColors.Control;
            this.ProgressList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProgressList.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProgressList.FormattingEnabled = true;
            this.ProgressList.ItemHeight = 16;
            this.ProgressList.Location = new System.Drawing.Point(12, 317);
            this.ProgressList.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressList.Name = "ProgressList";
            this.ProgressList.Size = new System.Drawing.Size(459, 226);
            this.ProgressList.TabIndex = 8;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(537, 246);
            this.lblPlayer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(0, 25);
            this.lblPlayer1.TabIndex = 9;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.SystemColors.Control;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(711, 246);
            this.lblPlayer2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(0, 25);
            this.lblPlayer2.TabIndex = 10;
            // 
            // txbxPlayer1Score
            // 
            this.txbxPlayer1Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxPlayer1Score.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxPlayer1Score.Location = new System.Drawing.Point(508, 284);
            this.txbxPlayer1Score.Margin = new System.Windows.Forms.Padding(4);
            this.txbxPlayer1Score.Name = "txbxPlayer1Score";
            this.txbxPlayer1Score.Size = new System.Drawing.Size(131, 28);
            this.txbxPlayer1Score.TabIndex = 11;
            this.txbxPlayer1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbxPlayer2Score
            // 
            this.txbxPlayer2Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxPlayer2Score.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxPlayer2Score.Location = new System.Drawing.Point(683, 284);
            this.txbxPlayer2Score.Margin = new System.Windows.Forms.Padding(4);
            this.txbxPlayer2Score.Name = "txbxPlayer2Score";
            this.txbxPlayer2Score.Size = new System.Drawing.Size(131, 28);
            this.txbxPlayer2Score.TabIndex = 12;
            this.txbxPlayer2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDice1
            // 
            this.lblDice1.BackColor = System.Drawing.Color.LightCoral;
            this.lblDice1.Location = new System.Drawing.Point(139, 107);
            this.lblDice1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(67, 61);
            this.lblDice1.TabIndex = 13;
            // 
            // lblDice2
            // 
            this.lblDice2.BackColor = System.Drawing.Color.LightCoral;
            this.lblDice2.Location = new System.Drawing.Point(261, 71);
            this.lblDice2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(67, 61);
            this.lblDice2.TabIndex = 14;
            // 
            // txbxDice1
            // 
            this.txbxDice1.BackColor = System.Drawing.Color.LightCoral;
            this.txbxDice1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxDice1.Font = new System.Drawing.Font("Kristen ITC", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxDice1.ForeColor = System.Drawing.Color.Yellow;
            this.txbxDice1.Location = new System.Drawing.Point(161, 172);
            this.txbxDice1.Margin = new System.Windows.Forms.Padding(4);
            this.txbxDice1.Name = "txbxDice1";
            this.txbxDice1.Size = new System.Drawing.Size(47, 46);
            this.txbxDice1.TabIndex = 15;
            // 
            // txbxDice2
            // 
            this.txbxDice2.BackColor = System.Drawing.Color.LightCoral;
            this.txbxDice2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxDice2.Font = new System.Drawing.Font("Kristen ITC", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxDice2.ForeColor = System.Drawing.Color.Yellow;
            this.txbxDice2.Location = new System.Drawing.Point(283, 136);
            this.txbxDice2.Margin = new System.Windows.Forms.Padding(4);
            this.txbxDice2.Name = "txbxDice2";
            this.txbxDice2.Size = new System.Drawing.Size(45, 46);
            this.txbxDice2.TabIndex = 16;
            // 
            // lblTargetScore
            // 
            this.lblTargetScore.AutoSize = true;
            this.lblTargetScore.BackColor = System.Drawing.Color.IndianRed;
            this.lblTargetScore.Font = new System.Drawing.Font("Kristen ITC", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetScore.ForeColor = System.Drawing.Color.Yellow;
            this.lblTargetScore.Location = new System.Drawing.Point(552, 71);
            this.lblTargetScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTargetScore.Name = "lblTargetScore";
            this.lblTargetScore.Size = new System.Drawing.Size(201, 36);
            this.lblTargetScore.TabIndex = 19;
            this.lblTargetScore.Text = "Target Score";
            // 
            // lblSetScore
            // 
            this.lblSetScore.AutoSize = true;
            this.lblSetScore.Font = new System.Drawing.Font("Kristen ITC", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetScore.Location = new System.Drawing.Point(642, 116);
            this.lblSetScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSetScore.Name = "lblSetScore";
            this.lblSetScore.Size = new System.Drawing.Size(0, 36);
            this.lblSetScore.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(510, 485);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 36);
            this.label1.TabIndex = 21;
            this.label1.Text = "Running Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(782, 485);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 36);
            this.label2.TabIndex = 22;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Active player=>";
            // 
            // activePlayer
            // 
            this.activePlayer.AutoSize = true;
            this.activePlayer.BackColor = System.Drawing.Color.LightCoral;
            this.activePlayer.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activePlayer.ForeColor = System.Drawing.Color.Yellow;
            this.activePlayer.Location = new System.Drawing.Point(209, 9);
            this.activePlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.activePlayer.Name = "activePlayer";
            this.activePlayer.Size = new System.Drawing.Size(75, 28);
            this.activePlayer.TabIndex = 41;
            this.activePlayer.Text = "player";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(665, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 36);
            this.button1.TabIndex = 42;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(772, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 36);
            this.button2.TabIndex = 43;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(13, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 28);
            this.label4.TabIndex = 44;
            this.label4.Text = "player1\'s wining";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.IndianRed;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(13, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 28);
            this.label5.TabIndex = 45;
            this.label5.Text = "player2\'s wining ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(259, 243);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 28);
            this.label6.TabIndex = 46;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(259, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 28);
            this.label7.TabIndex = 47;
            this.label7.Text = "0";
            // 
            // frmMainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(875, 554);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.activePlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSetScore);
            this.Controls.Add(this.lblTargetScore);
            this.Controls.Add(this.txbxDice2);
            this.Controls.Add(this.txbxDice1);
            this.Controls.Add(this.lblDice2);
            this.Controls.Add(this.lblDice1);
            this.Controls.Add(this.txbxPlayer2Score);
            this.Controls.Add(this.txbxPlayer1Score);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.ProgressList);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnKeepTurn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainGame";
            this.Text = "The Game of Groans!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKeepTurn;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.ListBox ProgressList;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.TextBox txbxPlayer1Score;
        private System.Windows.Forms.TextBox txbxPlayer2Score;
        private System.Windows.Forms.Label lblDice1;
        private System.Windows.Forms.Label lblDice2;
        private System.Windows.Forms.TextBox txbxDice1;
        private System.Windows.Forms.TextBox txbxDice2;
        private System.Windows.Forms.Label lblTargetScore;
        private System.Windows.Forms.Label lblSetScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label activePlayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}


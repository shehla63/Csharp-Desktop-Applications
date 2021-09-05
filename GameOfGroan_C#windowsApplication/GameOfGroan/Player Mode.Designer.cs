namespace FawadIjazAssigt
{
    partial class frmPlayerMode
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
            this.btnComputerPlay = new System.Windows.Forms.Button();
            this.btnDoublePlayer = new System.Windows.Forms.Button();
            this.lblPlayerMode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComputerPlay
            // 
            this.btnComputerPlay.BackColor = System.Drawing.Color.IndianRed;
            this.btnComputerPlay.Font = new System.Drawing.Font("Kristen ITC", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputerPlay.ForeColor = System.Drawing.Color.Gold;
            this.btnComputerPlay.Location = new System.Drawing.Point(149, 241);
            this.btnComputerPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnComputerPlay.Name = "btnComputerPlay";
            this.btnComputerPlay.Size = new System.Drawing.Size(228, 64);
            this.btnComputerPlay.TabIndex = 0;
            this.btnComputerPlay.Text = "Play With Computer";
            this.btnComputerPlay.UseVisualStyleBackColor = false;
            this.btnComputerPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDoublePlayer
            // 
            this.btnDoublePlayer.BackColor = System.Drawing.Color.IndianRed;
            this.btnDoublePlayer.Font = new System.Drawing.Font("Kristen ITC", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoublePlayer.ForeColor = System.Drawing.Color.Gold;
            this.btnDoublePlayer.Location = new System.Drawing.Point(149, 169);
            this.btnDoublePlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoublePlayer.Name = "btnDoublePlayer";
            this.btnDoublePlayer.Size = new System.Drawing.Size(228, 64);
            this.btnDoublePlayer.TabIndex = 1;
            this.btnDoublePlayer.Text = "Double Player";
            this.btnDoublePlayer.UseVisualStyleBackColor = false;
            this.btnDoublePlayer.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblPlayerMode
            // 
            this.lblPlayerMode.AutoSize = true;
            this.lblPlayerMode.BackColor = System.Drawing.Color.LightSalmon;
            this.lblPlayerMode.Font = new System.Drawing.Font("Kristen ITC", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayerMode.Location = new System.Drawing.Point(141, 108);
            this.lblPlayerMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerMode.Name = "lblPlayerMode";
            this.lblPlayerMode.Size = new System.Drawing.Size(240, 45);
            this.lblPlayerMode.TabIndex = 18;
            this.lblPlayerMode.Text = "Player Mode";
            // 
            // frmPlayerMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 451);
            this.Controls.Add(this.lblPlayerMode);
            this.Controls.Add(this.btnDoublePlayer);
            this.Controls.Add(this.btnComputerPlay);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPlayerMode";
            this.Text = "Groans: Player Mode";
            this.Load += new System.EventHandler(this.Player_Mode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComputerPlay;
        private System.Windows.Forms.Button btnDoublePlayer;
        private System.Windows.Forms.Label lblPlayerMode;
    }
}
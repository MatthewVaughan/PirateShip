namespace Project02
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNumPirates = new System.Windows.Forms.Label();
            this.lblNumGold = new System.Windows.Forms.Label();
            this.lblJackShare = new System.Windows.Forms.Label();
            this.lblCrewShare = new System.Windows.Forms.Label();
            this.lblMateShare = new System.Windows.Forms.Label();
            this.lblPBF = new System.Windows.Forms.Label();
            this.txtNumPirates = new System.Windows.Forms.TextBox();
            this.txtNumCoins = new System.Windows.Forms.TextBox();
            this.txtMateShare = new System.Windows.Forms.TextBox();
            this.txtJackShare = new System.Windows.Forms.TextBox();
            this.txtPBF = new System.Windows.Forms.TextBox();
            this.txtCrewShare = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblNumPirates
            // 
            this.lblNumPirates.AutoSize = true;
            this.lblNumPirates.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumPirates.Location = new System.Drawing.Point(33, 118);
            this.lblNumPirates.Name = "lblNumPirates";
            this.lblNumPirates.Size = new System.Drawing.Size(159, 17);
            this.lblNumPirates.TabIndex = 1;
            this.lblNumPirates.Text = "Total number of pirates:";
            // 
            // lblNumGold
            // 
            this.lblNumGold.AutoSize = true;
            this.lblNumGold.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumGold.Location = new System.Drawing.Point(33, 152);
            this.lblNumGold.Name = "lblNumGold";
            this.lblNumGold.Size = new System.Drawing.Size(149, 17);
            this.lblNumGold.TabIndex = 2;
            this.lblNumGold.Text = "Total number of coins:";
            // 
            // lblJackShare
            // 
            this.lblJackShare.AutoSize = true;
            this.lblJackShare.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJackShare.Location = new System.Drawing.Point(33, 260);
            this.lblJackShare.Name = "lblJackShare";
            this.lblJackShare.Size = new System.Drawing.Size(93, 17);
            this.lblJackShare.TabIndex = 3;
            this.lblJackShare.Text = "Jack\'s Share:";
            // 
            // lblCrewShare
            // 
            this.lblCrewShare.AutoSize = true;
            this.lblCrewShare.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCrewShare.Location = new System.Drawing.Point(33, 311);
            this.lblCrewShare.Name = "lblCrewShare";
            this.lblCrewShare.Size = new System.Drawing.Size(186, 17);
            this.lblCrewShare.TabIndex = 4;
            this.lblCrewShare.Text = "Each Crew Member\'s Share:";
            // 
            // lblMateShare
            // 
            this.lblMateShare.AutoSize = true;
            this.lblMateShare.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMateShare.Location = new System.Drawing.Point(33, 283);
            this.lblMateShare.Name = "lblMateShare";
            this.lblMateShare.Size = new System.Drawing.Size(95, 17);
            this.lblMateShare.TabIndex = 5;
            this.lblMateShare.Text = "Mate\'s Share:";
            // 
            // lblPBF
            // 
            this.lblPBF.AutoSize = true;
            this.lblPBF.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPBF.Location = new System.Drawing.Point(33, 339);
            this.lblPBF.Name = "lblPBF";
            this.lblPBF.Size = new System.Drawing.Size(170, 17);
            this.lblPBF.TabIndex = 6;
            this.lblPBF.Text = "Pirate\'s Benevolent Fund:";
            // 
            // txtNumPirates
            // 
            this.txtNumPirates.Location = new System.Drawing.Point(248, 118);
            this.txtNumPirates.Name = "txtNumPirates";
            this.txtNumPirates.Size = new System.Drawing.Size(100, 22);
            this.txtNumPirates.TabIndex = 7;
            // 
            // txtNumCoins
            // 
            this.txtNumCoins.Location = new System.Drawing.Point(248, 152);
            this.txtNumCoins.Name = "txtNumCoins";
            this.txtNumCoins.Size = new System.Drawing.Size(100, 22);
            this.txtNumCoins.TabIndex = 8;
            // 
            // txtMateShare
            // 
            this.txtMateShare.Location = new System.Drawing.Point(248, 283);
            this.txtMateShare.Name = "txtMateShare";
            this.txtMateShare.Size = new System.Drawing.Size(100, 22);
            this.txtMateShare.TabIndex = 9;
            // 
            // txtJackShare
            // 
            this.txtJackShare.Location = new System.Drawing.Point(248, 255);
            this.txtJackShare.Name = "txtJackShare";
            this.txtJackShare.Size = new System.Drawing.Size(100, 22);
            this.txtJackShare.TabIndex = 10;
            // 
            // txtPBF
            // 
            this.txtPBF.Location = new System.Drawing.Point(248, 339);
            this.txtPBF.Name = "txtPBF";
            this.txtPBF.Size = new System.Drawing.Size(100, 22);
            this.txtPBF.TabIndex = 11;
            // 
            // txtCrewShare
            // 
            this.txtCrewShare.Location = new System.Drawing.Point(248, 311);
            this.txtCrewShare.Name = "txtCrewShare";
            this.txtCrewShare.Size = new System.Drawing.Size(100, 22);
            this.txtCrewShare.TabIndex = 12;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(103, 200);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(184, 34);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Calculate Shares";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(406, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(929, 432);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtCrewShare);
            this.Controls.Add(this.txtPBF);
            this.Controls.Add(this.txtJackShare);
            this.Controls.Add(this.txtMateShare);
            this.Controls.Add(this.txtNumCoins);
            this.Controls.Add(this.txtNumPirates);
            this.Controls.Add(this.lblPBF);
            this.Controls.Add(this.lblMateShare);
            this.Controls.Add(this.lblCrewShare);
            this.Controls.Add(this.lblJackShare);
            this.Controls.Add(this.lblNumGold);
            this.Controls.Add(this.lblNumPirates);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Coin Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblNumPirates;
        private System.Windows.Forms.Label lblNumGold;
        private System.Windows.Forms.Label lblJackShare;
        private System.Windows.Forms.Label lblCrewShare;
        private System.Windows.Forms.Label lblMateShare;
        private System.Windows.Forms.Label lblPBF;
        private System.Windows.Forms.TextBox txtNumPirates;
        private System.Windows.Forms.TextBox txtNumCoins;
        private System.Windows.Forms.TextBox txtMateShare;
        private System.Windows.Forms.TextBox txtJackShare;
        private System.Windows.Forms.TextBox txtPBF;
        private System.Windows.Forms.TextBox txtCrewShare;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


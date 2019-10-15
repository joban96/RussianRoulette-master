namespace RussianRoulette
{
    partial class RussianRoulette
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRandom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBulletsFired = new System.Windows.Forms.Label();
            this.lblAway = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKill = new System.Windows.Forms.Label();
            this.btnPointAway2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(24, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(77, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Losses";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.ForeColor = System.Drawing.Color.Red;
            this.lblWins.Location = new System.Drawing.Point(24, 301);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(18, 20);
            this.lblWins.TabIndex = 2;
            this.lblWins.Text = "0";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosses.ForeColor = System.Drawing.Color.Red;
            this.lblLosses.Location = new System.Drawing.Point(86, 301);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(18, 20);
            this.lblLosses.TabIndex = 3;
            this.lblLosses.Text = "0";
            // 
            // btnShoot
            // 
            this.btnShoot.BackColor = System.Drawing.Color.Blue;
            this.btnShoot.Enabled = false;
            this.btnShoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShoot.Location = new System.Drawing.Point(28, 99);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(136, 44);
            this.btnShoot.TabIndex = 4;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = false;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.Blue;
            this.btnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSpin.Location = new System.Drawing.Point(29, 26);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(135, 46);
            this.btnSpin.TabIndex = 6;
            this.btnSpin.Text = "Spin Chamber";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(498, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Random Number";
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandom.ForeColor = System.Drawing.Color.Red;
            this.lblRandom.Location = new System.Drawing.Point(510, 301);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(0, 13);
            this.lblRandom.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(361, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bullets Fired";
            // 
            // lblBulletsFired
            // 
            this.lblBulletsFired.AutoSize = true;
            this.lblBulletsFired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBulletsFired.ForeColor = System.Drawing.Color.Red;
            this.lblBulletsFired.Location = new System.Drawing.Point(382, 301);
            this.lblBulletsFired.Name = "lblBulletsFired";
            this.lblBulletsFired.Size = new System.Drawing.Size(18, 20);
            this.lblBulletsFired.TabIndex = 10;
            this.lblBulletsFired.Text = "0";
            // 
            // lblAway
            // 
            this.lblAway.AutoSize = true;
            this.lblAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAway.ForeColor = System.Drawing.Color.Red;
            this.lblAway.Location = new System.Drawing.Point(246, 301);
            this.lblAway.Name = "lblAway";
            this.lblAway.Size = new System.Drawing.Size(18, 20);
            this.lblAway.TabIndex = 11;
            this.lblAway.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(226, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Point Away";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RussianRoulette.Resource1.Revolver;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(292, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 206);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(146, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(146, 301);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 20);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblKill);
            this.panel1.Controls.Add(this.btnPointAway2);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblAway);
            this.panel1.Controls.Add(this.lblBulletsFired);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblRandom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSpin);
            this.panel1.Controls.Add(this.btnShoot);
            this.panel1.Controls.Add(this.lblLosses);
            this.panel1.Controls.Add(this.lblWins);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 370);
            this.panel1.TabIndex = 16;
            // 
            // lblKill
            // 
            this.lblKill.AutoSize = true;
            this.lblKill.Location = new System.Drawing.Point(289, 191);
            this.lblKill.Name = "lblKill";
            this.lblKill.Size = new System.Drawing.Size(10, 13);
            this.lblKill.TabIndex = 17;
            this.lblKill.Text = " ";
            this.lblKill.Visible = false;
            // 
            // btnPointAway2
            // 
            this.btnPointAway2.BackColor = System.Drawing.Color.Blue;
            this.btnPointAway2.Enabled = false;
            this.btnPointAway2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPointAway2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPointAway2.Location = new System.Drawing.Point(28, 174);
            this.btnPointAway2.Name = "btnPointAway2";
            this.btnPointAway2.Size = new System.Drawing.Size(136, 46);
            this.btnPointAway2.TabIndex = 16;
            this.btnPointAway2.Text = "Point Away";
            this.btnPointAway2.UseVisualStyleBackColor = false;
            this.btnPointAway2.Click += new System.EventHandler(this.btnPointAway2_Click);
            // 
            // RussianRoulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(697, 406);
            this.Controls.Add(this.panel1);
            this.Name = "RussianRoulette";
            this.Text = "Russian Roulette";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Button btnShoot;
        //private System.Windows.Forms.Button btnPointAway;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBulletsFired;
        private System.Windows.Forms.Label lblAway;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPointAway2;
        private System.Windows.Forms.Label lblKill;
    }
}


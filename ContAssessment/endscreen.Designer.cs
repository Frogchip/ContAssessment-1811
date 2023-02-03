
namespace ContAssessment
{
    partial class endscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(endscreen));
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnLead = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBronze = new System.Windows.Forms.Label();
            this.lblFailed = new System.Windows.Forms.Label();
            this.lblSilver = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblPlat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.AutoSize = true;
            this.btnQuit.BackColor = System.Drawing.Color.Crimson;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(248, 292);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(120, 51);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLead
            // 
            this.btnLead.BackColor = System.Drawing.Color.Crimson;
            this.btnLead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLead.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLead.Location = new System.Drawing.Point(640, 401);
            this.btnLead.Name = "btnLead";
            this.btnLead.Size = new System.Drawing.Size(157, 46);
            this.btnLead.TabIndex = 1;
            this.btnLead.Text = "Leaderboards";
            this.btnLead.UseVisualStyleBackColor = false;
            this.btnLead.Click += new System.EventHandler(this.btnLead_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(255)))), ((int)(((byte)(195)))));
            this.lblScore.Location = new System.Drawing.Point(394, 386);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(126, 38);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(439, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblBronze
            // 
            this.lblBronze.AutoSize = true;
            this.lblBronze.BackColor = System.Drawing.Color.Transparent;
            this.lblBronze.Font = new System.Drawing.Font("OCR A Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBronze.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblBronze.Location = new System.Drawing.Point(150, 180);
            this.lblBronze.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBronze.Name = "lblBronze";
            this.lblBronze.Size = new System.Drawing.Size(567, 34);
            this.lblBronze.TabIndex = 6;
            this.lblBronze.Text = "Bronze trophy achieved!";
            // 
            // lblFailed
            // 
            this.lblFailed.AutoSize = true;
            this.lblFailed.BackColor = System.Drawing.Color.Transparent;
            this.lblFailed.Font = new System.Drawing.Font("OCR A Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFailed.ForeColor = System.Drawing.Color.Red;
            this.lblFailed.Location = new System.Drawing.Point(275, 180);
            this.lblFailed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFailed.Name = "lblFailed";
            this.lblFailed.Size = new System.Drawing.Size(279, 34);
            this.lblFailed.TabIndex = 7;
            this.lblFailed.Text = "QUIZ FAILED";
            this.lblFailed.Click += new System.EventHandler(this.lblFailed_Click);
            // 
            // lblSilver
            // 
            this.lblSilver.AutoSize = true;
            this.lblSilver.BackColor = System.Drawing.Color.Transparent;
            this.lblSilver.Font = new System.Drawing.Font("OCR A Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSilver.ForeColor = System.Drawing.Color.Silver;
            this.lblSilver.Location = new System.Drawing.Point(150, 180);
            this.lblSilver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSilver.Name = "lblSilver";
            this.lblSilver.Size = new System.Drawing.Size(567, 34);
            this.lblSilver.TabIndex = 8;
            this.lblSilver.Text = "Silver trophy achieved!";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.BackColor = System.Drawing.Color.Transparent;
            this.lblGold.Font = new System.Drawing.Font("OCR A Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGold.ForeColor = System.Drawing.Color.Yellow;
            this.lblGold.Location = new System.Drawing.Point(198, 180);
            this.lblGold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(519, 34);
            this.lblGold.TabIndex = 9;
            this.lblGold.Text = "Gold trophy achieved!";
            this.lblGold.Click += new System.EventHandler(this.lblGold_Click);
            // 
            // lblPlat
            // 
            this.lblPlat.AutoSize = true;
            this.lblPlat.BackColor = System.Drawing.Color.Transparent;
            this.lblPlat.Font = new System.Drawing.Font("OCR A Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPlat.Location = new System.Drawing.Point(115, 180);
            this.lblPlat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlat.Name = "lblPlat";
            this.lblPlat.Size = new System.Drawing.Size(615, 34);
            this.lblPlat.TabIndex = 10;
            this.lblPlat.Text = "Platinum trophy achieved!";
            this.lblPlat.Click += new System.EventHandler(this.lblPlat_Click);
            // 
            // endscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlat);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblSilver);
            this.Controls.Add(this.lblFailed);
            this.Controls.Add(this.lblBronze);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnLead);
            this.Controls.Add(this.btnQuit);
            this.Name = "endscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "endscreen";
            this.Load += new System.EventHandler(this.endscreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnLead;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBronze;
        private System.Windows.Forms.Label lblFailed;
        private System.Windows.Forms.Label lblSilver;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblPlat;
    }
}
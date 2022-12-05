
namespace ContAssessment
{
    partial class difficulty
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
            this.cbEasy = new System.Windows.Forms.CheckBox();
            this.cbNormal = new System.Windows.Forms.CheckBox();
            this.cbHard = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblnocheck = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEasy
            // 
            this.cbEasy.BackColor = System.Drawing.Color.Transparent;
            this.cbEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEasy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbEasy.Location = new System.Drawing.Point(21, 108);
            this.cbEasy.Margin = new System.Windows.Forms.Padding(5);
            this.cbEasy.Name = "cbEasy";
            this.cbEasy.Size = new System.Drawing.Size(93, 39);
            this.cbEasy.TabIndex = 0;
            this.cbEasy.Text = "Easy";
            this.cbEasy.UseVisualStyleBackColor = false;
            this.cbEasy.CheckedChanged += new System.EventHandler(this.cbEasy_CheckedChanged);
            this.cbEasy.Click += new System.EventHandler(this.cbEasy_Click);
            // 
            // cbNormal
            // 
            this.cbNormal.BackColor = System.Drawing.Color.Transparent;
            this.cbNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbNormal.Location = new System.Drawing.Point(21, 289);
            this.cbNormal.Margin = new System.Windows.Forms.Padding(5);
            this.cbNormal.Name = "cbNormal";
            this.cbNormal.Size = new System.Drawing.Size(93, 37);
            this.cbNormal.TabIndex = 1;
            this.cbNormal.Text = "Normal";
            this.cbNormal.UseVisualStyleBackColor = false;
            this.cbNormal.CheckedChanged += new System.EventHandler(this.cbNormal_CheckedChanged);
            this.cbNormal.Click += new System.EventHandler(this.cbNormal_Click);
            // 
            // cbHard
            // 
            this.cbHard.BackColor = System.Drawing.Color.Transparent;
            this.cbHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHard.ForeColor = System.Drawing.Color.Red;
            this.cbHard.Location = new System.Drawing.Point(21, 459);
            this.cbHard.Margin = new System.Windows.Forms.Padding(5);
            this.cbHard.Name = "cbHard";
            this.cbHard.Size = new System.Drawing.Size(93, 39);
            this.cbHard.TabIndex = 2;
            this.cbHard.Text = "Hard";
            this.cbHard.UseVisualStyleBackColor = false;
            this.cbHard.CheckedChanged += new System.EventHandler(this.cbHard_CheckedChanged);
            this.cbHard.Click += new System.EventHandler(this.cbHard_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkRed;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(436, 472);
            this.btnStart.Margin = new System.Windows.Forms.Padding(5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(243, 77);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblnocheck
            // 
            this.lblnocheck.AutoSize = true;
            this.lblnocheck.BackColor = System.Drawing.Color.Transparent;
            this.lblnocheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnocheck.Location = new System.Drawing.Point(666, 412);
            this.lblnocheck.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblnocheck.Name = "lblnocheck";
            this.lblnocheck.Size = new System.Drawing.Size(269, 25);
            this.lblnocheck.TabIndex = 4;
            this.lblnocheck.Text = "You must select a difficulty";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.BackColor = System.Drawing.Color.Transparent;
            this.lblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblRules.Location = new System.Drawing.Point(525, 150);
            this.lblRules.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(0, 29);
            this.lblRules.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContAssessment.Properties.Resources.difficulty_screen_FINAL;
            this.pictureBox1.Location = new System.Drawing.Point(-16, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1107, 580);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Crimson;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(12, 496);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(133, 56);
            this.btnSignOut.TabIndex = 7;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Crimson;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(887, 494);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(156, 56);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            // 
            // difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ContAssessment.Properties.Resources.difficulty_screen_FINAL;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1069, 562);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblnocheck);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbHard);
            this.Controls.Add(this.cbNormal);
            this.Controls.Add(this.cbEasy);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "difficulty";
            this.Text = "difficulty";
            this.Load += new System.EventHandler(this.difficulty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbEasy;
        private System.Windows.Forms.CheckBox cbNormal;
        private System.Windows.Forms.CheckBox cbHard;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblnocheck;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnQuit;
    }
}
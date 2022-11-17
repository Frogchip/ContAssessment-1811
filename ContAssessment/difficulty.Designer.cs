
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
            this.SuspendLayout();
            // 
            // cbEasy
            // 
            this.cbEasy.AutoSize = true;
            this.cbEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEasy.Location = new System.Drawing.Point(21, 97);
            this.cbEasy.Margin = new System.Windows.Forms.Padding(5);
            this.cbEasy.Name = "cbEasy";
            this.cbEasy.Size = new System.Drawing.Size(60, 22);
            this.cbEasy.TabIndex = 0;
            this.cbEasy.Text = "Easy";
            this.cbEasy.UseVisualStyleBackColor = true;
            this.cbEasy.CheckedChanged += new System.EventHandler(this.cbEasy_CheckedChanged);
            this.cbEasy.Click += new System.EventHandler(this.cbEasy_Click);
            // 
            // cbNormal
            // 
            this.cbNormal.AutoSize = true;
            this.cbNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNormal.Location = new System.Drawing.Point(21, 219);
            this.cbNormal.Margin = new System.Windows.Forms.Padding(5);
            this.cbNormal.Name = "cbNormal";
            this.cbNormal.Size = new System.Drawing.Size(76, 22);
            this.cbNormal.TabIndex = 1;
            this.cbNormal.Text = "Normal";
            this.cbNormal.UseVisualStyleBackColor = true;
            this.cbNormal.CheckedChanged += new System.EventHandler(this.cbNormal_CheckedChanged);
            this.cbNormal.Click += new System.EventHandler(this.cbNormal_Click);
            // 
            // cbHard
            // 
            this.cbHard.AutoSize = true;
            this.cbHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHard.Location = new System.Drawing.Point(21, 343);
            this.cbHard.Margin = new System.Windows.Forms.Padding(5);
            this.cbHard.Name = "cbHard";
            this.cbHard.Size = new System.Drawing.Size(59, 22);
            this.cbHard.TabIndex = 2;
            this.cbHard.Text = "Hard";
            this.cbHard.UseVisualStyleBackColor = true;
            this.cbHard.CheckedChanged += new System.EventHandler(this.cbHard_CheckedChanged);
            this.cbHard.Click += new System.EventHandler(this.cbHard_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(298, 352);
            this.btnStart.Margin = new System.Windows.Forms.Padding(5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(175, 60);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblnocheck
            // 
            this.lblnocheck.AutoSize = true;
            this.lblnocheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnocheck.Location = new System.Drawing.Point(522, 388);
            this.lblnocheck.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblnocheck.Name = "lblnocheck";
            this.lblnocheck.Size = new System.Drawing.Size(228, 24);
            this.lblnocheck.TabIndex = 4;
            this.lblnocheck.Text = "You must select a difficulty";
            this.lblnocheck.Click += new System.EventHandler(this.lblnocheck_Click);
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Location = new System.Drawing.Point(594, 130);
            this.lblRules.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(0, 17);
            this.lblRules.TabIndex = 5;
            // 
            // difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblnocheck);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbHard);
            this.Controls.Add(this.cbNormal);
            this.Controls.Add(this.cbEasy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "difficulty";
            this.Text = "difficulty";
            this.Load += new System.EventHandler(this.difficulty_Load);
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
    }
}
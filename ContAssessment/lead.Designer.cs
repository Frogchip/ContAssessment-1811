
namespace ContAssessment
{
    partial class lead
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
            this.dgLead = new System.Windows.Forms.DataGridView();
            this.btnUsername = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnDiff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLead)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLead
            // 
            this.dgLead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLead.Location = new System.Drawing.Point(129, 113);
            this.dgLead.Name = "dgLead";
            this.dgLead.Size = new System.Drawing.Size(505, 325);
            this.dgLead.TabIndex = 0;
            // 
            // btnUsername
            // 
            this.btnUsername.Location = new System.Drawing.Point(69, 48);
            this.btnUsername.Name = "btnUsername";
            this.btnUsername.Size = new System.Drawing.Size(75, 23);
            this.btnUsername.TabIndex = 1;
            this.btnUsername.Text = "Username";
            this.btnUsername.UseVisualStyleBackColor = true;
            this.btnUsername.Click += new System.EventHandler(this.btnUsername_Click);
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(330, 48);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(75, 23);
            this.btnScore.TabIndex = 2;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnDiff
            // 
            this.btnDiff.Location = new System.Drawing.Point(619, 48);
            this.btnDiff.Name = "btnDiff";
            this.btnDiff.Size = new System.Drawing.Size(75, 23);
            this.btnDiff.TabIndex = 3;
            this.btnDiff.Text = "Difficulty";
            this.btnDiff.UseVisualStyleBackColor = true;
            // 
            // lead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDiff);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnUsername);
            this.Controls.Add(this.dgLead);
            this.Name = "lead";
            this.Text = "lead";
            this.Load += new System.EventHandler(this.lead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLead;
        private System.Windows.Forms.Button btnUsername;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnDiff;
    }
}

namespace ContAssessment
{
    partial class easybomb
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(easybomb));
            this.picBomb = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBomb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBomb
            // 
            this.picBomb.BackColor = System.Drawing.Color.Transparent;
            this.picBomb.Image = global::ContAssessment.Properties.Resources.bomb_2_final;
            this.picBomb.Location = new System.Drawing.Point(1029, 510);
            this.picBomb.Name = "picBomb";
            this.picBomb.Size = new System.Drawing.Size(38, 35);
            this.picBomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBomb.TabIndex = 0;
            this.picBomb.TabStop = false;
            this.picBomb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBomb_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(500, 89);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 37);
            this.lblTime.TabIndex = 1;
            // 
            // lblBomb
            // 
            this.lblBomb.AutoSize = true;
            this.lblBomb.BackColor = System.Drawing.Color.Transparent;
            this.lblBomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBomb.ForeColor = System.Drawing.Color.Red;
            this.lblBomb.Location = new System.Drawing.Point(320, -1);
            this.lblBomb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBomb.Name = "lblBomb";
            this.lblBomb.Size = new System.Drawing.Size(0, 73);
            this.lblBomb.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(178, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(703, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // easybomb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::ContAssessment.Properties.Resources.Dolphin_Emulator_Screenshot_2022_01_16___17_17_23_21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 547);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBomb);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picBomb);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "easybomb";
            this.Text = "easybomb";
            this.Load += new System.EventHandler(this.easybomb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBomb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBomb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
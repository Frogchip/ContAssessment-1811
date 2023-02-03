
namespace ContAssessment
{
    partial class normalbomb
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
            this.picBomb = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBomb)).BeginInit();
            this.SuspendLayout();
            // 
            // picBomb
            // 
            this.picBomb.BackColor = System.Drawing.Color.Transparent;
            this.picBomb.Image = global::ContAssessment.Properties.Resources.bomb_2_final;
            this.picBomb.Location = new System.Drawing.Point(1358, 609);
            this.picBomb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBomb.Name = "picBomb";
            this.picBomb.Size = new System.Drawing.Size(66, 66);
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
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(643, 110);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 55);
            this.lblTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(423, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 91);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spot the bomb!";
            // 
            // normalbomb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ContAssessment.Properties.Resources.Dolphin_Emulator_Screenshot_2022_01_16___17_17_23_21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1421, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picBomb);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "normalbomb";
            this.Text = "normalbomb";
            this.Load += new System.EventHandler(this.normalbomb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBomb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBomb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
    }
}
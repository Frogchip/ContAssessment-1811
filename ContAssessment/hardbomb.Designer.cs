
namespace ContAssessment
{
    partial class hardbomb
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
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBomb)).BeginInit();
            this.SuspendLayout();
            // 
            // picBomb
            // 
            this.picBomb.BackColor = System.Drawing.Color.Transparent;
            this.picBomb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBomb.Image = global::ContAssessment.Properties.Resources.bomb_2_final;
            this.picBomb.Location = new System.Drawing.Point(1033, 512);
            this.picBomb.Name = "picBomb";
            this.picBomb.Size = new System.Drawing.Size(33, 33);
            this.picBomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBomb.TabIndex = 0;
            this.picBomb.TabStop = false;
            this.picBomb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBomb_MouseClick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(471, 73);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 37);
            this.lblTime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(282, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(482, 73);
            this.label2.TabIndex = 2;
            this.label2.Text = "Spot the bomb!";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hardbomb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ContAssessment.Properties.Resources.Dolphin_Emulator_Screenshot_2022_01_16___17_17_23_21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 547);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picBomb);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "hardbomb";
            this.Text = "hardbomb";
            this.Load += new System.EventHandler(this.hardbomb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBomb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBomb;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}
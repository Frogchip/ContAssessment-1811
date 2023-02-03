using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContAssessment
{
    public partial class easyCB : Form
    {
        string[] questionPartsArray;
        string cbselected;
        public easyCB()
        {
            InitializeComponent();
        }

        private void easyCB_Load(object sender, EventArgs e)
        {
            if (globaldata.ELife == 1)
            {
                Health1.Visible = false;
                Health2.Visible = true;
            }
            if (globaldata.ELife == 2)
            {
                Health1.Visible = false;
                Health2.Visible = false;
                Health3.Visible = true;
            }
            if (globaldata.ELife == 3)
            {
                Health1.Visible = false;
                Health2.Visible = false;
                Health3.Visible = false;
                Health4.Visible = true;
            }
            if (globaldata.ELife == 4)
            {
                Health1.Visible = false;
                Health2.Visible = false;
                Health3.Visible = false;
                Health4.Visible = false;
                Health5.Visible = true;
            }
            if (globaldata.Admin == 1)
            {
                globaldata.ELife = 99999;
                if (lblans1.Text == questionPartsArray[7])
                {
                    lblans1.ForeColor = Color.Green;
                }
                if (lblans2.Text == questionPartsArray[7])
                {
                    lblans2.ForeColor = Color.Green;
                }
                if (lblans3.Text == questionPartsArray[7])
                {
                    lblans3.ForeColor = Color.Green;
                }
                if (lblans4.Text == questionPartsArray[7])
                {
                    lblans4.ForeColor = Color.Green;
                }
            }
            if (globaldata.Admin != 1)
            {

                timer1.Enabled = true;
                timer1.Start();
                lblTime.Visible = true;
            }
            else
            {
                lblTime.Text = "∞";
            }
            lblEQCount.Text = globaldata.ECount + "/20";
            lblTime.Text = globaldata.ETimeLeft + "";
            lblEScore.Text = globaldata.Score + "";
        }

        internal void ShowQuestion(string ShowQdata)
        {
            questionPartsArray = ShowQdata.Split(',');
            lblQuestion.Text = questionPartsArray[1];
            lblans1.Text = questionPartsArray[2];
            lblans2.Text = questionPartsArray[3];
            lblans3.Text = questionPartsArray[4];
            lblans4.Text = questionPartsArray[5];

        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            cbselected = "1";
        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            cbselected = "2";
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            cbselected = "3";
        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
            cbselected = "4";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!cb1.Checked && !cb2.Checked && !cb3.Checked && !cb4.Checked)
            {
                MessageBox.Show("Please select an answer.");
                return;
            }
            // Logic to work out if they selected the correct answer
            if (cbselected != questionPartsArray[6])
            {
                timer1.Stop();
                lblTime.Visible = false;
                MessageBox.Show("Incorrect!");
                globaldata.Score--;
                this.Hide();
                globaldata.ELife = globaldata.ELife + 1;
                if (globaldata.ELife == 1)
                {
                    Health1.Visible = false;
                }
                if (globaldata.ELife == 2)
                {
                    Health2.Visible = false;
                }
                if (globaldata.ELife == 3)
                {
                    Health3.Visible = false;
                }
                if (globaldata.ELife == 4)
                {
                    Health4.Visible = false;
                }
                if (globaldata.ELife == 5)
                {
                    timer1.Stop();
                    this.Hide();
                }
            }
            else
            {
                timer1.Stop();
                globaldata.ECount++;
                globaldata.Score++;
                lblTime.Visible = false;
                MessageBox.Show("Good job!");
                this.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            globaldata.ETimeLeft = globaldata.ETimeLeft - 1;
            if (globaldata.ETimeLeft == 5)
            {
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"OneDrive - C2k/Y13SSD/sfx/Countdown/atomchick_five22.wav");
                //player.Play();
            }
            if (globaldata.ETimeLeft == 4)
            {
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"/OneDrive - C2k/Y13SSD/sfx/Countdown/atomchick_four22.wav");
                //player.Play();
            }
            if (globaldata.ETimeLeft == 3)
            {
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"/OneDrive - C2k/Y13SSD/sfx/Countdown/atomchick_three2.wav");
                //player.Play();
            }
            if (globaldata.ETimeLeft == 2)
            {
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"/OneDrive - C2k/Y13SSD/sfx/Countdown/atomchick_two22_.wav");
                //player.Play();
            }
            if (globaldata.ETimeLeft == 1)
            {
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"/OneDrive - C2k/Y13SSD/sfx/Countdown/atomchick_one22_.wav");
                //player.Play();
            }
            if (globaldata.ETimeLeft == 0)
            {
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"/OneDrive - C2k/Y13SSD/sfx/Countdown/atomchick_zero22.wav");
                //player.Play();
                lblTime.Visible = false;
                globaldata.ECount++;
                timer1.Stop();
                MessageBox.Show("Out of time!");
                this.Hide();
                globaldata.ELife++;
                globaldata.Score--;
                if (globaldata.ELife == 5)
                {
                    globaldata.EQCount = 0;
                    timer1.Stop();
                    endscreen end1 = new endscreen();
                    this.Hide();
                    end1.Show();
                }
            }
        }

        private void lblans2_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = false;
            cb2.Checked = true;
            cb3.Checked = false;
            cb4.Checked = false;
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = false;
            cb2.Checked = true;
            cb3.Checked = false;
            cb4.Checked = false;
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = true;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = false;
        }

        private void lblans1_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = true;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = false;
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = true;
            cb4.Checked = false;
        }

        private void lblans3_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = true;
            cb4.Checked = false;
        }

        private void lblans4_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = true;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            globaldata.ELife = 0;
            globaldata.Score = 0;
            difficulty diff1 = new difficulty();
            this.Hide();
            diff1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

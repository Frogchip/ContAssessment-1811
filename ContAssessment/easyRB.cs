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
using System.Media;
namespace ContAssessment
{
    public partial class easyRB : Form
    {
        string[] questionPartsArray;
        string rbselected;
        public easyRB()
        {
            InitializeComponent();
        }

        private void easy_Load(object sender, EventArgs e)
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
            lblEScore.Text = globaldata.Score + "";
            lblEQCount.Text = "";
            globaldata.ETimeLeft = 16;
            lblTime.Visible = true;
            timer1.Start();
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

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            rbselected = "1";
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            rbselected = "2";
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            rbselected = "3";
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            rbselected = "4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!rb1.Checked && !rb2.Checked && !rb3.Checked && !rb4.Checked)
            {
                MessageBox.Show("Please select an answer.");
                return;
            }
            // Logic to work out if they selected the correct answer
            if (rbselected != questionPartsArray[6])
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
                lblTime.Visible = false;
                MessageBox.Show("Good job!");
                this.Hide();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblEQCount.Text = globaldata.ECount + "/20";
            lblEScore.Text = globaldata.Score + "";
            lblTime.Visible = true;
            timer1.Start();
            globaldata.ETimeLeft = globaldata.ETimeLeft - 1;
            lblTime.Text = globaldata.ETimeLeft + "";
            if (globaldata.ETimeLeft == 5)
            {
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                //player.Play();
            }
            if (globaldata.ETimeLeft == 0)
            {
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
                //player.Play();
                lblTime.Visible = false;
                globaldata.ECount++;
                MessageBox.Show("Out of time!");
                timer1.Stop();
                this.Hide();
                globaldata.ELife = globaldata.ELife + 1;
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

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            rb1.Checked = true;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = true;
            rb3.Checked = false;
            rb4.Checked = false;
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = true;
            rb4.Checked = false;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = true;
        }

        private void lblans1_MouseClick(object sender, MouseEventArgs e)
        {
            rb1.Checked = true;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
        }

        private void lblans2_MouseClick(object sender, MouseEventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = true;
            rb3.Checked = false;
            rb4.Checked = false;
        }

        private void lblans3_MouseClick(object sender, MouseEventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = true;
            rb4.Checked = false;
        }

        private void lblans4_MouseClick(object sender, MouseEventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            globaldata.Score = 0;
            globaldata.ELife = 0;
            difficulty diff1 = new difficulty();
            this.Hide();
            diff1.Show();
        }

        private void Health1_Click(object sender, EventArgs e)
        {

        }
    }
}

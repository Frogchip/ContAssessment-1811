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
    public partial class hardRB : Form
    {
        string[] questionPartsArray;
        string rbselected;
        public hardRB()
        {
            InitializeComponent();
        }

        private void hard_Load(object sender, EventArgs e)
        {
            if (globaldata.HLife == 1)
            {
                Health1.Visible = false;
                Health2.Visible = true;
            }
            lblHScore.Text = globaldata.Score + "";
            globaldata.HTimeLeft = 11;
            lblTime.Visible = true;
            timer1.Start();
            if (globaldata.Admin == 1)
            {
                globaldata.HTimeLeft = 99999;
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            globaldata.HTimeLeft = globaldata.HTimeLeft - 1;
            lblTime.Text = globaldata.HTimeLeft + "";
            lblHQCount.Text = globaldata.HCount + "/20";
            if (globaldata.HTimeLeft == 0)
            {
                timer1.Stop();
                lblTime.Visible = false;
                globaldata.HCount++;
                MessageBox.Show("Out of time!");
                globaldata.HLife -= 2;
                this.Hide();
                globaldata.HLife = globaldata.HLife + 1;
                if (globaldata.HLife == 1)
                {
                    Health1.Visible = false;
                    Health2.Visible = true;
                }
                if (globaldata.HLife == 2)
                {
                    timer1.Stop();
                    this.Hide();
                }
            }
        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            rbselected = "4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kick out if they haven't selected an answer yet.

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
                globaldata.HLife = globaldata.HLife + 1;
                if (globaldata.HLife == 1)
                {
                    Health1.Visible = false;
                    Health2.Visible = true;
                }
                if (globaldata.HLife == 2)
                {
                    this.Hide();
                }
            }
            else
            {
                timer1.Stop();
                lblTime.Visible = false;
                MessageBox.Show("Good job!");
                globaldata.HCount++;
                this.Hide();
            }
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = true;
            rb3.Checked = false;
            rb4.Checked = false;            
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            rb1.Checked = true;
            rb2.Checked = false;
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

        private void lblans2_MouseClick(object sender, MouseEventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = true;
            rb3.Checked = false;
            rb4.Checked = false;
        }

        private void lblans1_MouseClick(object sender, MouseEventArgs e)
        {
            rb1.Checked = true;
            rb2.Checked = false;
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}

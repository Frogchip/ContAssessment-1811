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
    public partial class normalRB : Form
    {
        string[] questionPartsArray;
        string rbselected;
        public normalRB()
        {
            InitializeComponent();
        }

        private void normal_Load(object sender, EventArgs e)
        {
            if (globaldata.NLife == 1)
            {
                Health1.Visible = false;
                Health2.Visible = true;
            }
            if (globaldata.NLife == 2)
            {
                Health1.Visible = false;
                Health2.Visible = false;
                Health3.Visible = true;
            }
            lblNScore.Text = globaldata.Score + "";
            globaldata.NTimeLeft = 13;
            lblNTime.Visible = true;
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
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
                lblNTime.Visible = false;
                MessageBox.Show("Incorrect!");
                globaldata.Score--;
                this.Hide();

                globaldata.NLife = globaldata.NLife + 1;
                if (globaldata.NLife == 1)
                {
                    Health1.Visible = false;
                    Health2.Visible = true;
                }
                if (globaldata.NLife == 2)
                {
                    Health1.Visible = false;
                    Health2.Visible = false;
                    Health3.Visible = true;
                }
                if (globaldata.NLife == 3)
                {
                    timer1.Stop();
                    this.Hide();
                }
            }
            else
            {
                timer1.Stop();
                lblNTime.Visible = false;
                MessageBox.Show("Good job!");
                globaldata.NCount++;
                this.Hide();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rbselected = "2";
        }

        private void lblans3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rbselected = "1";
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
            globaldata.NTimeLeft = globaldata.NTimeLeft - 1;
            lblNQCount.Text = globaldata.NCount + "/20";
            lblNTime.Text = globaldata.NTimeLeft + "";
            if (globaldata.NTimeLeft == 0)
            {
                lblNTime.Visible = false;
                MessageBox.Show("Out of time!");
                timer1.Stop();
                this.Hide();
                globaldata.NLife = globaldata.NLife + 1;
                globaldata.Score -= 2;
                if (globaldata.NLife == 1)
                {
                    Health1.Visible = false;
                    Health2.Visible = true;
                }
                if (globaldata.NLife == 2)
                {
                    Health1.Visible = false;
                    Health2.Visible = false;
                    Health3.Visible = true;
                }
                if (globaldata.NLife == 3)
                {
                    globaldata.NQCount = 0;
                    timer1.Stop();
                    this.Hide();
                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            rb1.Checked = true;
            rb2.Checked = false;
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

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = true;
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

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = true;
            rb4.Checked = false;
        }
        private void lblans3_MouseClick(object sender, MouseEventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = true;
            rb4.Checked = false;
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = true;
        }
        private void lblans4_MouseClick(object sender, MouseEventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            globaldata.Score = 0;
            globaldata.NLife = 0;
            difficulty diff1 = new difficulty();
            this.Hide();
            diff1.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

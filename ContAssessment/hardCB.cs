using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContAssessment
{
    public partial class hardCB : Form
    {
        string[] questionPartsArray;
        string rbselected;
        public hardCB()
        {
            InitializeComponent();
        }

        private void hardCB_Load(object sender, EventArgs e)
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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            rbselected = "1";
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            rbselected = "3";
        }
        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            rbselected = "2";
        }
        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
            rbselected = "4";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHScore.Text = globaldata.Score + "";
            globaldata.HTimeLeft = globaldata.HTimeLeft - 1;
            lblTime.Text = globaldata.HTimeLeft + "";
            lblHQCount.Text = globaldata.HCount + "";
            if (globaldata.HTimeLeft == 0)
            {
                lblTime.Visible = false;
                MessageBox.Show("Out of time!");
                timer1.Stop();
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
                    endscreen end1 = new endscreen();
                    end1.Show();
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Kick out if they haven't selected an answer yet.

            if (!cb1.Checked && !cb2.Checked && !cb3.Checked && !cb4.Checked)
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
                globaldata.Score-=2;
                globaldata.HLife = globaldata.HLife + 1;
                this.Hide();
                if (globaldata.HLife == 1)
                {
                    Health1.Visible = false;
                    Health2.Visible = true;
                }
                if (globaldata.HLife == 2)
                {
                    endscreen end1 = new endscreen();
                    this.Hide();
                    end1.Show();
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

        private void cb1_Click(object sender, EventArgs e)
        {
            cb1.Checked = true;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = false;
        }

        private void cb2_Click(object sender, EventArgs e)
        {
            cb1.Checked = false;
            cb2.Checked = true;
            cb3.Checked = false;
            cb4.Checked = false;
        }

        private void cb3_Click(object sender, EventArgs e)
        {
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = true;
            cb4.Checked = false;
        }

        private void cb4_Click(object sender, EventArgs e)
        {
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = true;
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = true;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = false;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = false;
            cb2.Checked = true;
            cb3.Checked = false;
            cb4.Checked = false;
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = true;
            cb4.Checked = false;
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = true;
        }

        private void lblans4_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = true;
        }

        private void lblans1_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = false;
            cb2.Checked = true;
            cb3.Checked = false;
            cb4.Checked = false;
        }

        private void lblans2_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = true;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = false;
        }

        private void lblans3_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = true;
            cb4.Checked = false;
        }
    }
}

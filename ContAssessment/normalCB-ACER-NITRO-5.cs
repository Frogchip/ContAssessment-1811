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
    public partial class normalCB : Form
    {
        string[] questionPartsArray;
        string cbselected;
        public normalCB()
        {
            InitializeComponent();
        }

        private void normalCB_Load(object sender, EventArgs e)
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
            if (globaldata.NLife == 3)
            {
                this.Hide();
            }
            if (globaldata.Admin == 1)
            {
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
            lblNScore.Text = globaldata.Score + "";
            lblNQCount.Text = "";
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
                globaldata.NLife = globaldata.NLife + 1;
                if (globaldata.NLife == 1)
                {
                    Health1.Visible = false;
                }
                if (globaldata.NLife == 2)
                {
                    Health2.Visible = false;
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
                globaldata.NCount++;
                lblTime.Visible = false;
                MessageBox.Show("Good job!");
                this.Hide();
            }
        }

        private void Health3_Click(object sender, EventArgs e)
        {

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNQCount.Text = globaldata.NCount + "/20";
            lblNScore.Text = globaldata.Score + "";
            lblTime.Visible = true;
            timer1.Start();
            globaldata.NTimeLeft = globaldata.NTimeLeft - 1;
            lblTime.Text = globaldata.NTimeLeft + "";
            if (globaldata.NTimeLeft == 0)
            {
                lblTime.Visible = false;
                globaldata.NCount++;
                MessageBox.Show("Out of time!");
                timer1.Stop();
                this.Hide();
                globaldata.NLife = globaldata.NLife + 1;
                globaldata.Score -= 2;
                if (globaldata.NLife == 3)
                {
                    globaldata.NQCount = 0;
                    timer1.Stop();
                    this.Hide();
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = true;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = false;
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = false;
            cb2.Checked = true;
            cb3.Checked = false;
            cb4.Checked = false;
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
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

        private void lblans1_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = true;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = false;
        }

        private void lblans2_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = false;
            cb2.Checked = true;
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

        private void lblans4_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            globaldata.Score = 0;
            globaldata.NLife = 0;
            difficulty diff1 = new difficulty();
            this.Hide();
            diff1.Show();
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void lblNQCount_Click(object sender, EventArgs e)
        {

        }
    }
}

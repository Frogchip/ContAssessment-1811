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
            //lblEQCount.Text = globaldata.Score;
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
                MessageBox.Show("Incorrect!");
                globaldata.ELife = globaldata.ELife + 1;
                if (globaldata.ELife == 5)
                {
                    timer1.Stop();
                    endscreen end1 = new endscreen();
                    end1.Show();
                    this.Hide();
                }
            }
            else
            {
                timer1.Stop();
                lblTime.Visible = false;
                MessageBox.Show("Good job!");
                this.Hide();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            globaldata.ETimeLeft = globaldata.ETimeLeft - 1;
            lblTime.Text = globaldata.ETimeLeft + "";
            if (globaldata.ETimeLeft == 0)
            {
                lblTime.Visible = false;
                MessageBox.Show("Out of time!");
                timer1.Stop();
                this.Hide();
                globaldata.ELife = globaldata.ELife + 1;
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

        private void lblans1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class hard : Form
    {
        string[] linesArray;
        string[] questionPartsArray;
        string rbselected;
        public hard()
        {
            InitializeComponent();
        }

        private void hard_Load(object sender, EventArgs e)
        {
            linesArray = File.ReadAllLines("QuizQuestions.txt");
            Random rand = new Random();
            int qcount = linesArray.Count();
            int num = rand.Next(1, qcount);
            questionPartsArray = linesArray[num].Split(',');
            lblQuestion.Text = questionPartsArray[1];
            lblans1.Text = questionPartsArray[2];
            lblans2.Text = questionPartsArray[3];
            lblans3.Text = questionPartsArray[4];
            lblans4.Text = questionPartsArray[5];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Kick out if they haven't selected an answer yet.

            if (!rb1.Checked && !rb2.Checked && !rb3.Checked && !rb4.Checked)
            {
                MessageBox.Show("Please select an answer!");
                return;
            }
            // Logic to work out if they selected the correct answer
            if (rbselected != questionPartsArray[6])
            {
                MessageBox.Show("Oooh unlucky.  Fool....");
                return;
            }
            else
            {
                MessageBox.Show("You got it!");
                return;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblans3_Click(object sender, EventArgs e)
        {

        }
    }
}

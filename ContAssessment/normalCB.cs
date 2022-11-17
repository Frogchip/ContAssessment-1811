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
        string rbselected;
        public normalCB()
        {
            InitializeComponent();
        }

        private void normalCB_Load(object sender, EventArgs e)
        {
            globaldata.NTimeLeft = 13;
            //lblTime.Visible = true;
            timer1.Start();
           // linesArray = File.ReadAllLines("QuizQuestionsNormal.txt");
           // Random rand = new Random();
           // int qcount = linesArray.Count();
          //  int num = rand.Next(0, qcount);
           // questionPartsArray = linesArray[num].Split(',');
            lblQuestion.Text = questionPartsArray[1];
            lblans1.Text = questionPartsArray[2];
            lblans2.Text = questionPartsArray[3];
            lblans3.Text = questionPartsArray[4];
            lblans4.Text = questionPartsArray[5];
        }
    }
}

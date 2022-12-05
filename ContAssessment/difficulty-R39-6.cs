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
    public partial class difficulty : Form
    {
        public difficulty()
        {
            InitializeComponent();
            lblnocheck.Visible = false;
        }

        private void cbEasy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbNormal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbHard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbEasy.Checked == false || cbNormal.Checked == false || cbHard.Checked == false)
            {
                lblnocheck.Visible = true;
            }
            if (cbEasy.Checked == true)
            {
                var rando = new Random();
                var linesarray = File.ReadAllLines("QuizQuestionsEasy.txt");
                Random rand = new Random();

                string[] random = linesarray.OrderBy(x => rand.Next()).ToArray();

                globaldata.EQCount = 10;
                for (int i = 0; i < globaldata.EQCount; i++)
                {
                    if (globaldata.ELife == 5)
                    {
                        break;
                    }
                    var b = rando.Next(1, 3);
                    if (b == 1)
                    {
                        easyRB RB1 = new easyRB();
                        this.Hide();
                        RB1.ShowQuestion(random[i]);
                        RB1.ShowDialog();
                        globaldata.ETimeLeft = 16;
                        globaldata.Score += 1;
                    }
                    if (b == 2)
                    {
                        easyCB CB1 = new easyCB();
                        this.Hide();
                        CB1.ShowQuestion(random[i]);
                        CB1.ShowDialog();
                        globaldata.ETimeLeft = 16;
                        globaldata.Score += 1;
                    }
                }
                endscreen end1 = new endscreen();
                end1.Show();
                this.Hide();
            }
            if (cbNormal.Checked == true)
            {
                var rando = new Random();
                var linesarray = File.ReadAllLines("QuizQuestionsNormal.txt");
                Random rand = new Random();

                string[] random = linesarray.OrderBy(x => rand.Next()).ToArray();

                globaldata.NQCount = 10;
                for (int i = 0; i < globaldata.NQCount; i++)
                {
                    if (globaldata.NLife == 3)
                    {
                        break;
                    }
                    var b = rando.Next(1, 3);

                    if (b == 1)
                    {
                        normalRB N1 = new normalRB();
                        this.Hide();
                        N1.ShowQuestion(random[i]);
                        N1.ShowDialog();
                        globaldata.NTimeLeft = 13;
                        globaldata.Score += 1;
                    }
                    if (b == 2)
                    {
                        normalCB C1 = new normalCB();
                        this.Hide();
                        C1.ShowQuestion(random[i]);
                        C1.ShowDialog();
                        globaldata.NTimeLeft = 13;
                        globaldata.Score += 1;
                    }
                }
                endscreen end1 = new endscreen();
                end1.Show();
                this.Hide();
            }
            if (cbHard.Checked == true)
            {
                var rando = new Random();
                var linesarray = File.ReadAllLines("QuizQuestionsHard.txt");
                Random rand = new Random();

                string[] random = linesarray.OrderBy(x => rand.Next()).ToArray();

                globaldata.HQCount = 10;
                for (int i = 0; i < globaldata.HQCount; i++)
                {
                    if (globaldata.HLife == 2)
                    {
                        break;
                    }
                    var b = rando.Next(1, 3);  
                    if (b == 1)
                    {
                        hardRB HR1 = new hardRB();
                        this.Hide();
                        HR1.ShowQuestion(random[i]);
                        HR1.ShowDialog();
                        globaldata.HTimeLeft = 11;
                        globaldata.Score += 1;
                    }
                    else
                    {
                        hardCB HC1 = new hardCB();
                        this.Hide();
                        HC1.ShowQuestion(random[i]);
                        HC1.ShowDialog();
                        globaldata.HTimeLeft = 11;
                        globaldata.Score += 1;
                    }
                }
                endscreen end1 = new endscreen();
                end1.Show();
                this.Hide();
            }

        }

        private void cbEasy_Click(object sender, EventArgs e)
        {
            cbEasy.Checked = true;
            cbNormal.Checked = false;
            cbHard.Checked = false;
            lblnocheck.Visible = false;

            lblRules.Text = "5 Lives\n" + "10 seconds\n";
        }        

        private void cbNormal_Click(object sender, EventArgs e)
        {
            cbEasy.Checked = false;
            cbNormal.Checked = true;
            cbHard.Checked = false;
            lblnocheck.Visible = false;

            lblRules.ForeColor = Color.Orange;
            lblRules.Text = "3 Lives\n" + "8 seconds\n";
        }

        private void cbHard_Click(object sender, EventArgs e)
        {
            cbEasy.Checked = false;
            cbNormal.Checked = false;
            cbHard.Checked = true;
            lblnocheck.Visible = false;

            lblRules.ForeColor = Color.Red;
            lblRules.Text = "2 Lives\n" + "5 seconds\n";
        }

        private void difficulty_Load(object sender, EventArgs e)
        {

        }
    }
}

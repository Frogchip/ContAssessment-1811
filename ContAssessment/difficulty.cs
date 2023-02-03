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
        private void btnStart_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer("");
            //player.Play();
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

                for (int i = 0; i < globaldata.EQCount; i++)
                {
                    if (globaldata.ELife > 4)
                    {
                        break;
                    }
                    var b = rando.Next(1, 9);
                    if (b == 1 || b == 2 || b == 3)
                    {
                        globaldata.ETimeLeft = 16;
                        globaldata.Score += 1;
                        easyRB RB1 = new easyRB();
                        this.Hide();
                        RB1.ShowQuestion(random[i]);
                        RB1.ShowDialog();
                    }
                    if (b == 4 || b == 5 || b == 6)
                    {
                        globaldata.ETimeLeft = 8;
                        globaldata.Score += 1;
                        easyCB CB1 = new easyCB();
                        this.Hide();
                        CB1.ShowQuestion(random[i]);
                        CB1.ShowDialog();

                    }
                    if (b == 7)
                    {
                        globaldata.ETimeLeft = 6;
                        globaldata.Score += 1;
                        easybomb EB1 = new easybomb();
                        this.Hide();
                        EB1.ShowDialog();

                    }
                    if (b == 8)
                    {
                        globaldata.ETimeLeft = 16;
                        globaldata.Score += 1;
                        easyDND DND1 = new easyDND();
                        this.Hide();
                        DND1.ShowDialog();
                    }
                }
                globaldata.Score--;
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

                for (int i = 0; i < globaldata.NQCount; i++)
                {
                    if (globaldata.NLife == 3)
                    {
                        break;
                    }
                    var b = rando.Next(1, 7);

                    if (b == 1 || b == 2)
                    {
                        if (globaldata.Admin == 1)
                        {
                            globaldata.NTimeLeft = 99999;
                            globaldata.Score += 1;
                        }
                        else
                        {
                            globaldata.NTimeLeft = 13;
                            globaldata.Score += 1;
                        }
                        normalRB N1 = new normalRB();
                        this.Hide();
                        N1.ShowQuestion(random[i]);
                        N1.ShowDialog();
                    }
                    if (b == 3 || b == 4)
                    {
                        if (globaldata.Admin == 1)
                        {
                            globaldata.NTimeLeft = 99999;
                            globaldata.Score += 1;
                        }
                        else
                        {
                            globaldata.NTimeLeft = 13;
                            globaldata.Score += 1;
                        }
                        normalCB C1 = new normalCB();
                        this.Hide();
                        C1.ShowQuestion(random[i]);
                        C1.ShowDialog();
                    }
                    if (b == 5)
                    {
                        if (globaldata.Admin == 1)
                        {
                            globaldata.NTimeLeft = 99999;
                            globaldata.Score += 1;
                        }
                        else
                        {
                            globaldata.NTimeLeft = 4;
                            globaldata.Score += 1;
                        }
                        normalbomb NB1 = new normalbomb();
                        this.Hide();
                        NB1.ShowDialog();
                    }
                    if (b == 6)
                    {
                        if (globaldata.Admin == 1)
                        {
                            globaldata.NTimeLeft = 99999;
                            globaldata.Score += 1;
                        }
                        else
                        {
                            globaldata.NTimeLeft = 13;
                            globaldata.Score += 1;
                        }
                        normalDND DND1 = new normalDND();
                        this.Hide();
                        DND1.ShowDialog();
                    }

                }
                globaldata.Score--;
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

                for (int i = 0; i < globaldata.HQCount; i++)
                {
                    if (globaldata.HLife == 2)
                    {
                        break;
                    }
                    var b = rando.Next(1, 8);  
                    if (b == 1 || b == 2)
                    {
                        if (globaldata.Admin == 1)
                        {
                            globaldata.HTimeLeft = 9999;
                            globaldata.Score += 1;
                        }
                        else
                        {
                            globaldata.HTimeLeft = 11;
                            globaldata.Score += 1;
                        }
                        hardRB HR1 = new hardRB();
                        this.Hide();
                        HR1.ShowQuestion(random[i]);
                        HR1.ShowDialog();
                    }
                    if (b == 3 || b == 4)
                    {
                        if (globaldata.Admin == 1)
                        {
                            globaldata.HTimeLeft = 9999;
                            globaldata.Score += 1;
                        }
                        else
                        {
                            globaldata.HTimeLeft = 11;
                            globaldata.Score += 1;
                        }
                        hardCB HC1 = new hardCB();
                        this.Hide();
                        HC1.ShowQuestion(random[i]);
                        HC1.ShowDialog();
                    }
                    if (b == 5 || b == 6)
                    {
                        if (globaldata.Admin == 1)
                        {
                            globaldata.HTimeLeft = 9999;
                            globaldata.Score += 1;
                        }
                        else
                        {
                            globaldata.HTimeLeft = 3;
                            globaldata.Score += 1;
                        }
                        hardbomb HB1 = new hardbomb();
                        this.Hide();
                        HB1.ShowDialog();
                    }
                    if (b == 7)
                    {
                        if (globaldata.Admin == 1)
                        {
                            globaldata.HTimeLeft = 99999;
                            globaldata.Score += 1;
                        }
                        else
                        {
                            globaldata.HTimeLeft = 13;
                            globaldata.Score += 1;
                        }
                        hardDND DND1 = new hardDND();
                        this.Hide();
                        DND1.ShowDialog();
                    }
                }
                globaldata.Score--;
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

            lblRules.ForeColor = Color.GreenYellow;
            lblRules.Text = "You will not be challenged.\n";
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer("");
            //player.Play();
        }        

        private void cbNormal_Click(object sender, EventArgs e)
        {
            cbEasy.Checked = false;
            cbNormal.Checked = true;
            cbHard.Checked = false;
            lblnocheck.Visible = false;

            lblRules.ForeColor = Color.Orange;
            lblRules.Text = "Your speed of answering questions will be tested.\n";
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer("");
            //player.Play();
        }

        private void cbHard_Click(object sender, EventArgs e)
        {
            cbEasy.Checked = false;
            cbNormal.Checked = false;
            cbHard.Checked = true;
            lblnocheck.Visible = false;

            lblRules.ForeColor = Color.Red;
            lblRules.Text = "You will not survive.\n";
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer("");
            //player.Play();
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Homescreen H1 = new Homescreen();
            H1.Show();
            this.Hide();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbNormal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void difficulty_Load(object sender, EventArgs e)
        {

        }
    }
}

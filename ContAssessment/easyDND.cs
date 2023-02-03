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
using System.Resources;
using System.Xml;
using System.Media;

namespace ContAssessment
{
    public partial class easyDND : Form
    {
        private string[] questionPartsArray;
        private List<string> SavedImages = new List<string>();
        private List<string> Answers = new List<string>();
        private List<string>randImage = new List<string>();

        public easyDND()
        {
            InitializeComponent();
        }

        private void easyDND_Load(object sender, EventArgs e)
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
            if (globaldata.Admin == 1)
            {
                lblans1.Visible = true;
                lblans2.Visible = true;
                lblans3.Visible = true;
                lblans4.Visible = true;
            }
            answer1.AllowDrop = true;
            answer2.AllowDrop = true;
            answer3.AllowDrop = true;
            answer4.AllowDrop = true;
            order1.AllowDrop = true;
            order2.AllowDrop = true;
            order3.AllowDrop = true;
            order4.AllowDrop = true;

            string[] LinesArray = File.ReadAllLines("easyDNDQuestions.txt");
            List<string> Questions = LinesArray.ToList();
            List<string> ImageQuestions = new List<string>();

            for (int i = 0; i < Questions.Count; i++)
            {
                questionPartsArray = Questions[i].Split(',');
                if (questionPartsArray[0] == "IMG")
                {
                    ImageQuestions.Add(Questions[i]);
                }
            }

            Random rand1 = new Random();
            int qcount = ImageQuestions.Count();
            int num1 = rand1.Next(0, qcount - 1);
            questionPartsArray = ImageQuestions[num1].Split(',');
            lblQuestion.Text = questionPartsArray[1];
            if (globaldata.Admin == 1)
            {
                lblans1.Text = questionPartsArray[6];
                lblans2.Text = questionPartsArray[7];
                lblans3.Text = questionPartsArray[8];
                lblans4.Text = questionPartsArray[9];
            }

            List<string> images = new List<string>();
            List<string> randimage = new List<string>();

            images.Add(questionPartsArray[2]);
            images.Add(questionPartsArray[3]);
            images.Add(questionPartsArray[4]);
            images.Add(questionPartsArray[5]);



            while (images.Count != 0)
            {
                rand1 = new Random();
                var index = rand1.Next(0, (images.Count - 0));
                randimage.Add(images[index]);
                images.RemoveAt(index);
            }

            answer1.Image = (Bitmap)dndimages.ResourceManager.GetObject(randimage[0]);
            answer2.Image = (Bitmap)dndimages.ResourceManager.GetObject(randimage[1]);
            answer3.Image = (Bitmap)dndimages.ResourceManager.GetObject(randimage[2]);
            answer4.Image = (Bitmap)dndimages.ResourceManager.GetObject(randimage[3]);

            answer1.Image.Tag = randimage[0];
            answer2.Image.Tag = randimage[1];
            answer3.Image.Tag = randimage[2];
            answer4.Image.Tag = randimage[3];
            //lblScore.Text = "" + globaldata.Score;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (globaldata.PB5ID == false | globaldata.PB6ID == false | globaldata.PB7ID == false | globaldata.PB8ID == false)
            {
                MessageBox.Show("Please sort the images correctly.");
                return;
            }
            else
            {
                order1.Image.Tag = globaldata.PB5IMG;
                order2.Image.Tag = globaldata.PB6IMG;
                order3.Image.Tag = globaldata.PB7IMG;
                order4.Image.Tag = globaldata.PB8IMG;
            }
            if (order1.Image.Tag.ToString() == lblans1.Text && order2.Image.Tag.ToString() == lblans2.Text && order3.Image.Tag.ToString() == lblans3.Text && order4.Image.Tag.ToString() == lblans4.Text)
            {
                timer1.Stop();
                globaldata.ECount++;
                lblTime.Visible = false;
                MessageBox.Show("Good job!");
                this.Hide();



            }
            else
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
        }
        private void pictureBox6_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void pictureBox7_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void pictureBox7_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void pictureBox8_DragDrop(object sender, DragEventArgs e)
        {
            order4.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            globaldata.PB8IMG = globaldata.IMGTAG;
            globaldata.PB8ID = true;
        }

        private void pictureBox8_DragEnter(object sender, DragEventArgs e)
        {

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "" + globaldata.ETimeLeft;
            lblTime.Visible = true;
            timer1.Start();
            globaldata.ETimeLeft = globaldata.ETimeLeft - 1;
            if (globaldata.ETimeLeft == 5)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"OneDrive - C2k/Y13SSD/sfx/Countdown/atomchick_five22.wav");
                player.Play();
            }
            if (globaldata.ETimeLeft == 4)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"/OneDrive - C2k/Y13SSD/sfx/Countdown/atomchick_four22.wav");
                player.Play();
            }
            if (globaldata.ETimeLeft == 3)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"/OneDrive - C2k/Y13SSD/sfx/Countdown/atomchick_three2.wav");
                player.Play();
            }
            if (globaldata.ETimeLeft == 2)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"/OneDrive - C2k/Y13SSD/sfx/Countdown/atomchick_two22_.wav");
                player.Play();
            }
            if (globaldata.ETimeLeft == 1)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"/OneDrive - C2k/Y13SSD/sfx/Countdown/atomchick_one22_.wav");
                player.Play();
            }
            if (globaldata.ETimeLeft == 0)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"/OneDrive - C2k/Y13SSD/sfx/Countdown/atomchick_zero22.wav");
                player.Play();
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

        private void answer1_MouseDown(object sender, MouseEventArgs e)
        {
            globaldata.IMGTAG = answer1.Image.Tag.ToString();

            answer1.DoDragDrop(answer1.Image, DragDropEffects.Copy);
        }

        private void answer2_MouseDown(object sender, MouseEventArgs e)
        {
            globaldata.IMGTAG = answer2.Image.Tag.ToString();

            answer2.DoDragDrop(answer2.Image, DragDropEffects.Copy);
        }

        private void answer3_MouseDown(object sender, MouseEventArgs e)
        {
            globaldata.IMGTAG = answer3.Image.Tag.ToString();

            answer3.DoDragDrop(answer3.Image, DragDropEffects.Copy);
        }

        private void answer4_MouseDown(object sender, MouseEventArgs e)
        {
            globaldata.IMGTAG = answer4.Image.Tag.ToString();

            answer4.DoDragDrop(answer4.Image, DragDropEffects.Copy);
        }

        private void order1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
        }

        private void order1_DragDrop(object sender, DragEventArgs e)
        {
            order1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            globaldata.PB5IMG = globaldata.IMGTAG;
            globaldata.PB5ID = true;
        }

        private void order2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
        }

        private void order2_DragDrop(object sender, DragEventArgs e)
        {
            order2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            globaldata.PB6IMG = globaldata.IMGTAG;
            globaldata.PB6ID = true;
        }

        private void order3_DragDrop(object sender, DragEventArgs e)
        {
            order2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            globaldata.PB6IMG = globaldata.IMGTAG;
            globaldata.PB6ID = true;
        }

        private void order3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
        }

        private void order4_DragDrop(object sender, DragEventArgs e)
        {
            order4.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            globaldata.PB8IMG = globaldata.IMGTAG;
            globaldata.PB8ID = true;
        }

        private void order4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
        }
    }








}






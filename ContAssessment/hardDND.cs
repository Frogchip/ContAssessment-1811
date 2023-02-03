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
    public partial class hardDND : Form
    {
        private string[] questionPartsArray;
        private List<string> SavedImages = new List<string>();
        private List<string> Answers = new List<string>();
        private List<string> randImage = new List<string>();
        public hardDND()
        {
            InitializeComponent();
        }

        private void hardDND_Load(object sender, EventArgs e)
        {
            lblans1.Visible = false;
            lblans2.Visible = false;
            lblans3.Visible = false;
            lblans4.Visible = false;
            if (globaldata.HLife == 1)
            {
                Health1.Visible = true;
                Health2.Visible = false;
            }
            if (globaldata.Admin == 1)
            {
                lblans1.Visible = true;
                lblans2.Visible = true;
                lblans3.Visible = true;
                lblans4.Visible = true;
            }
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;
            pictureBox7.AllowDrop = true;
            pictureBox8.AllowDrop = true;

            string[] LinesArray = File.ReadAllLines("hardDNDQuestions.txt");
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
            lblans1.Text = questionPartsArray[6];
            lblans2.Text = questionPartsArray[7];
            lblans3.Text = questionPartsArray[8];
            lblans4.Text = questionPartsArray[9];

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

            pictureBox1.Image = (Bitmap)dndimages.ResourceManager.GetObject(randimage[0]);
            pictureBox2.Image = (Bitmap)dndimages.ResourceManager.GetObject(randimage[1]);
            pictureBox3.Image = (Bitmap)dndimages.ResourceManager.GetObject(randimage[2]);
            pictureBox4.Image = (Bitmap)dndimages.ResourceManager.GetObject(randimage[3]);

            pictureBox1.Image.Tag = randimage[0];
            pictureBox2.Image.Tag = randimage[1];
            pictureBox3.Image.Tag = randimage[2];
            pictureBox4.Image.Tag = randimage[3];
            //lblScore.Text = "" + globaldata.Score;


        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            globaldata.IMGTAG = pictureBox1.Image.Tag.ToString();

            pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.Copy);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            globaldata.IMGTAG = pictureBox2.Image.Tag.ToString();

            pictureBox2.DoDragDrop(pictureBox2.Image, DragDropEffects.Copy);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            globaldata.IMGTAG = pictureBox3.Image.Tag.ToString();

            pictureBox3.DoDragDrop(pictureBox3.Image, DragDropEffects.Copy);
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            globaldata.IMGTAG = pictureBox4.Image.Tag.ToString();

            pictureBox4.DoDragDrop(pictureBox4.Image, DragDropEffects.Copy);
        }

        private void pictureBox5_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox5.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            globaldata.PB5IMG = globaldata.IMGTAG;
            globaldata.PB5ID = true;

        }

        private void pictureBox5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox6_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox6.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            globaldata.PB6IMG = globaldata.IMGTAG;
            globaldata.PB6ID = true;
        }

        private void pictureBox6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
        }
        private void pictureBox7_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox7.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            globaldata.PB7IMG = globaldata.IMGTAG;
            globaldata.PB7ID = true;
        }

        private void pictureBox7_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox8_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox8.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            globaldata.PB8IMG = globaldata.IMGTAG;
            globaldata.PB8ID = true;
        }

        private void pictureBox8_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (globaldata.PB5ID == false | globaldata.PB6ID == false | globaldata.PB7ID == false | globaldata.PB8ID == false)
            {
                MessageBox.Show("Please sort the images correctly.");
                return;
            }
            else
            {
                pictureBox5.Image.Tag = globaldata.PB5IMG;
                pictureBox6.Image.Tag = globaldata.PB6IMG;
                pictureBox7.Image.Tag = globaldata.PB7IMG;
                pictureBox8.Image.Tag = globaldata.PB8IMG;
            }
            if (pictureBox5.Image.Tag.ToString() == lblans1.Text && pictureBox6.Image.Tag.ToString() == lblans2.Text && pictureBox7.Image.Tag.ToString() == lblans3.Text && pictureBox8.Image.Tag.ToString() == lblans4.Text)
            {
                timer1.Stop();
                globaldata.HCount++;
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
                globaldata.HLife = globaldata.HLife + 1;
                if (globaldata.HLife == 1)
                {
                    Health1.Visible = false;
                }
                if (globaldata.HLife == 2)
                {
                    timer1.Stop();
                    this.Hide();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "" + globaldata.HTimeLeft;
            lblTime.Visible = true;
            timer1.Start();
            globaldata.HTimeLeft = globaldata.HTimeLeft - 1;
            if (globaldata.HTimeLeft == 5)
            {
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"OneDrive - C2k/Y13SSD/sfx/Countdown/atomchick_five22.wav");
                //player.Play();
            }
            if (globaldata.HTimeLeft == 4)
            {
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"/OneDrive - C2k/Y13SSD/sfx/Countdown/atomchick_four22.wav");
                //player.Play();
            }
            if (globaldata.HTimeLeft == 3)
            {
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"/OneDrive - C2k/Y13SSD/sfx/Countdown/atomchick_three2.wav");
                //player.Play();
            }
            if (globaldata.HTimeLeft == 2)
            {
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"/OneDrive - C2k/Y13SSD/sfx/Countdown/atomchick_two22_.wav");
                //player.Play();
            }
            if (globaldata.HTimeLeft == 1)
            {
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"/OneDrive - C2k/Y13SSD/sfx/Countdown/atomchick_one22_.wav");
                //player.Play();
            }
            if (globaldata.HTimeLeft == 0)
            {
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"/OneDrive - C2k/Y13SSD/sfx/Countdown/atomchick_zero22.wav");
                //player.Play();
                lblTime.Visible = false;
                globaldata.HCount++;
                MessageBox.Show("Out of time!");
                timer1.Stop();
                this.Hide();
                globaldata.HLife = globaldata.HLife + 1;
                globaldata.Score--;
                if (globaldata.HLife == 5)
                {
                    globaldata.HQCount = 0;
                    timer1.Stop();
                    endscreen end1 = new endscreen();
                    this.Hide();
                    end1.Show();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            globaldata.Score = 0;
            globaldata.HLife = 0;
            difficulty diff1 = new difficulty();
            this.Hide();
            diff1.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}

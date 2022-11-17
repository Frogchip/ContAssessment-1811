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
    public partial class easyDND : Form
    {
        string[] questionPartsArray;
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
            lblEScore.Text = globaldata.Score + "";
            lblEQCount.Text = "";
            globaldata.ETimeLeft = 16;
            lblTime.Visible = true;
            timer1.Start();

            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            var linesArray = File.ReadAllLines("EDNDQuestions.txt");
            List<string> Questions = linesArray.ToList();
            List<string> ImageQuestions = new List<string>();
            for (int i = 0; i < Questions.Count; i++)
            {
                questionPartsArray = Questions[i].Split(",");
                if (questionPartsArray[0] == "IMG")
                {
                    pictureBox1.Show();
                    pictureBox2.Show();
                    pictureBox3.Show();
                    pictureBox4.Show();

                    ImageQuestions.Add(Questions[i]);

                    Random rand = new Random();
                    int qcount = ImageQuestions.Count();
                    int num = rand.Next(0, qcount);
                    questionPartsArray = ImageQuestions[num].Split(",");

                    List<string> images = new List<string>();
                    List<string> randImages = new List<string>();
                    images.Add(questionPartsArray[6]);
                    images.Add(questionPartsArray[7]);
                    images.Add(questionPartsArray[8]);
                    images.Add(questionPartsArray[9]);
                    lblQuestion.Text = questionPartsArray[1];
                    lblans1.Text = questionPartsArray[2];
                    lblans2.Text = questionPartsArray[3];
                    lblans3.Text = questionPartsArray[4];
                    lblans4.Text = questionPartsArray[5];

                    while (images.Count != 0)
                    {
                        rand = new Random();
                        var index = rand.Next(0, (images.Count - 1));
                        randImages.Add(images[index]);
                        images.RemoveAt(index);
                    }

                    pictureBox1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(randImages[0]);
                    pictureBox2.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(randImages[1]);
                    pictureBox3.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(randImages[2]);
                    pictureBox4.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(randImages[3]);

                    pictureBox1.Image.Tag = randImages[0];
                    pictureBox2.Image.Tag = randImages[1];
                    pictureBox3.Image.Tag = randImages[2];
                    pictureBox4.Image.Tag = randImages[3];

                } 
            }
        }

        private void pictureBox8_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            globaldata.PB8IMG = globaldata.IMGTAG;
        }

        private void pictureBox7_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            globaldata.PB7IMG = globaldata.IMGTAG;
        }

        private void pictureBox6_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            globaldata.PB6IMG = globaldata.IMGTAG;
        }

        private void pictureBox5_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            globaldata.PB5IMG = globaldata.IMGTAG;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox5.Image.Tag = globaldata.PB5IMG;
            pictureBox6.Image.Tag = globaldata.PB6IMG;
            pictureBox7.Image.Tag = globaldata.PB7IMG;
            pictureBox8.Image.Tag = globaldata.PB8IMG;

            if (pictureBox8.Image.Tag.ToString() == lblans1.Text &&)
            {
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            globaldata.IMGTAG = pictureBox1.Image.Tag.ToString();
            pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.Copy);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            globaldata.IMGTAG = pictureBox2.Image.Tag.ToString();
            pictureBox2.DoDragDrop(pictureBox1.Image, DragDropEffects.Copy);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            globaldata.IMGTAG = pictureBox3.Image.Tag.ToString();
            pictureBox3.DoDragDrop(pictureBox1.Image, DragDropEffects.Copy);
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            globaldata.IMGTAG = pictureBox4.Image.Tag.ToString();
            pictureBox4.DoDragDrop(pictureBox1.Image, DragDropEffects.Copy);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

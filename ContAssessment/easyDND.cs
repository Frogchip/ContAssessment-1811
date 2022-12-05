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

namespace ContAssessment
{
    public partial class easyDND : Form
    {
        string[] questionPartsArray;
        string selectedimg;

        List<string> images = new List<string>();
        List<string> saveimages = new List<string>();
        List<string> randimages = new List<string>();
        List<string> answers = new List<string>();
        List<string> saveanswers = new List<string>();
        public easyDND()
        {
            InitializeComponent();
        }

        private void easyDND_Load(object sender, EventArgs e)
        {
            saveanswers.Add("");
            saveanswers.Add("");
            saveanswers.Add("");
            saveanswers.Add("");

            string[] linesarray = File.ReadAllLines("EDNDQuestions.txt");
            List<string> questions = linesarray.ToList();
            List<string> imagequestions = new List<string>();
            Random rand = new Random();

            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;
            pictureBox7.AllowDrop = true;
            pictureBox8.AllowDrop = true;

            for (int i = 0; i < questions.Count; i++)
            {
                questionPartsArray = questions[i].Split(',');
                if (questionPartsArray[0] == "IMG")
                {
                    imagequestions.Add(questions[i]);
                }

            }
            int qcount = imagequestions.Count();
            int num = rand.Next(0, qcount - 1);
            questionPartsArray = imagequestions[num].Split(',');
            lblQuestion.Text = questionPartsArray[1];
            images.Add(questionPartsArray[2]);
            images.Add(questionPartsArray[3]);
            images.Add(questionPartsArray[4]);
            images.Add(questionPartsArray[5]);

            answers.Add(questionPartsArray[2]);
            answers.Add(questionPartsArray[3]);
            answers.Add(questionPartsArray[4]);
            answers.Add(questionPartsArray[5]);

            saveimages = images.ToList();
            saveanswers = images.ToList();
            while (images.Count != 0)
            {
                rand = new Random();
                var index = rand.Next(0, (images.Count - 0));
                randimages.Add(images[index]);
                images.RemoveAt(index);
            }

            pictureBox1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(randimages[0]);
            pictureBox2.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(randimages[1]);
            pictureBox3.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(randimages[2]);
            pictureBox4.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(randimages[3]);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            selectedimg = randimages[0];
            pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.Copy);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            selectedimg = randimages[1];
            pictureBox2.DoDragDrop(pictureBox2.Image, DragDropEffects.Copy);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            selectedimg = randimages[2];
            pictureBox3.DoDragDrop(pictureBox3.Image, DragDropEffects.Copy);
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            selectedimg = randimages[3];
            pictureBox4.DoDragDrop(pictureBox4.Image, DragDropEffects.Copy);
        }

        private void pictureBox5_DragDrop(object sender, DragEventArgs e)
        {
            answers[0] = selectedimg;
            pictureBox8.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox6_DragDrop(object sender, DragEventArgs e)
        {
            answers[1] = selectedimg;
            pictureBox7.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox7_DragDrop(object sender, DragEventArgs e)
        {
            answers[2] = selectedimg;
            pictureBox6.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBox8_DragDrop(object sender, DragEventArgs e)
        {
            answers[3] = selectedimg;
            pictureBox5.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((pictureBox5 == null) || (pictureBox6 == null) || (pictureBox7 == null) || (pictureBox8 == null))
            {
                MessageBox.Show("Please select an answer.");
                return;
            }
            for (int idx = 0; idx < 4; idx++)
            {
                if (saveimages[idx] != answers[idx])
                {
                    MessageBox.Show("Incorrect!");
                    return;
                }
            }
            MessageBox.Show("Good job!"); 
        }
    }
}
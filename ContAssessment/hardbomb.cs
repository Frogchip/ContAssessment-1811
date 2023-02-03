using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContAssessment
{
    public partial class hardbomb : Form
    {
        public hardbomb()
        {
            InitializeComponent();
        }

        private void hardbomb_Load(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer("");
            //player.Play();
            lblTime.Visible = true;
            timer1.Start();
            picBomb.Visible = true;
            //Create a list of locations.
            List<bomblocations> bombLocations = new List<bomblocations>() {
            new bomblocations {Left = 50, Top = 100},
            new bomblocations {Left = 50, Top = 200},
            new bomblocations {Left = 50, Top = 300},
            new bomblocations {Left = 50, Top = 400},
            new bomblocations {Left = 50, Top = 500},

            new bomblocations {Left = 100, Top = 100},
            new bomblocations {Left = 100, Top = 200},
            new bomblocations {Left = 100, Top = 300},
            new bomblocations {Left = 100, Top = 400},
            new bomblocations {Left = 100, Top = 500},

            new bomblocations {Left = 150, Top = 100},
            new bomblocations {Left = 150, Top = 200},
            new bomblocations {Left = 150, Top = 300},
            new bomblocations {Left = 150, Top = 400},
            new bomblocations {Left = 150, Top = 500},
            new bomblocations {Left = 150, Top = 600},
            new bomblocations {Left = 150, Top = 700},

            new bomblocations {Left = 200, Top = 100},
            new bomblocations {Left = 200, Top = 200},
            new bomblocations {Left = 200, Top = 300},
            new bomblocations {Left = 200, Top = 400},
            new bomblocations {Left = 200, Top = 500},

            new bomblocations {Left = 250, Top = 100},
            new bomblocations {Left = 250, Top = 200},
            new bomblocations {Left = 250, Top = 300},
            new bomblocations {Left = 250, Top = 400},
            new bomblocations {Left = 250, Top = 500},

            new bomblocations {Left = 300, Top = 100},
            new bomblocations {Left = 300, Top = 200},
            new bomblocations {Left = 300, Top = 300},
            new bomblocations {Left = 300, Top = 400},
            new bomblocations {Left = 300, Top = 500},

            new bomblocations {Left = 350, Top = 100},
            new bomblocations {Left = 350, Top = 200},
            new bomblocations {Left = 350, Top = 300},
            new bomblocations {Left = 350, Top = 400},
            new bomblocations {Left = 350, Top = 500},

            new bomblocations {Left = 400, Top = 100},
            new bomblocations {Left = 400, Top = 200},
            new bomblocations {Left = 400, Top = 300},
            new bomblocations {Left = 400, Top = 400},
            new bomblocations {Left = 400, Top = 500},

            new bomblocations {Left = 450, Top = 100},
            new bomblocations {Left = 450, Top = 200},
            new bomblocations {Left = 450, Top = 300},
            new bomblocations {Left = 450, Top = 400},
            new bomblocations {Left = 450, Top = 500},

            new bomblocations {Left = 500, Top = 100},
            new bomblocations {Left = 500, Top = 200},
            new bomblocations {Left = 500, Top = 300},
            new bomblocations {Left = 500, Top = 400},
            new bomblocations {Left = 500, Top = 500},

            new bomblocations {Left = 550, Top = 100},
            new bomblocations {Left = 550, Top = 200},
            new bomblocations {Left = 550, Top = 300},
            new bomblocations {Left = 550, Top = 400},
            new bomblocations {Left = 550, Top = 500},

            new bomblocations {Left = 600, Top = 100},
            new bomblocations {Left = 600, Top = 200},
            new bomblocations {Left = 600, Top = 300},
            new bomblocations {Left = 600, Top = 400},
            new bomblocations {Left = 600, Top = 500},
            new bomblocations {Left = 600, Top = 600},

            new bomblocations {Left = 650, Top = 100},
            new bomblocations {Left = 650, Top = 200},
            new bomblocations {Left = 650, Top = 300},
            new bomblocations {Left = 650, Top = 400},
            new bomblocations {Left = 650, Top = 500},

            new bomblocations {Left = 700, Top = 100},
            new bomblocations {Left = 700, Top = 200},
            new bomblocations {Left = 700, Top = 300},
            new bomblocations {Left = 700, Top = 400},
            new bomblocations {Left = 700, Top = 500},

            new bomblocations {Left = 750, Top = 100},
            new bomblocations {Left = 750, Top = 200},
            new bomblocations {Left = 750, Top = 300},
            new bomblocations {Left = 750, Top = 400},
            new bomblocations {Left = 750, Top = 500},

            new bomblocations {Left = 800, Top = 100},
            new bomblocations {Left = 800, Top = 200},
            new bomblocations {Left = 800, Top = 300},
            new bomblocations {Left = 800, Top = 400},
            new bomblocations {Left = 800, Top = 500},

            new bomblocations {Left = 850, Top = 100},
            new bomblocations {Left = 850, Top = 200},
            new bomblocations {Left = 850, Top = 300},
            new bomblocations {Left = 850, Top = 400},
            new bomblocations {Left = 850, Top = 500},

            new bomblocations {Left = 900, Top = 100},
            new bomblocations {Left = 900, Top = 200},
            new bomblocations {Left = 900, Top = 300},
            new bomblocations {Left = 900, Top = 400},
            new bomblocations {Left = 900, Top = 500},


            new bomblocations {Left = 950, Top = 100},
            new bomblocations {Left = 950, Top = 200},
            new bomblocations {Left = 950, Top = 300},
            new bomblocations {Left = 950, Top = 400},
            new bomblocations {Left = 950, Top = 500},

            new bomblocations {Left = 1000, Top = 100},
            new bomblocations {Left = 1000, Top = 200},
            new bomblocations {Left = 1000, Top = 300},
            new bomblocations {Left = 1000, Top = 400},
            new bomblocations {Left = 1000, Top = 500},
        };
            //Instantiate Random

            Random random = new Random();

            //Loop through the different Locations

            //Generate a random int from 0 to -1 of the number of possible locations

            int randomBombLocationIndex = random.Next(0, bombLocations.Count() - 1);
            picBomb.Left = bombLocations[randomBombLocationIndex].Left;
            picBomb.Top = bombLocations[randomBombLocationIndex].Top;
            this.Controls.Add(picBomb);
            bombLocations.RemoveAt(randomBombLocationIndex);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Visible = true;
            timer1.Start();
            globaldata.HTimeLeft = globaldata.HTimeLeft - 1;
            lblTime.Text = globaldata.HTimeLeft + "";
            if (globaldata.HTimeLeft == 0)
            {
                timer1.Stop();
                lblTime.Visible = false;
                globaldata.HCount++;
                MessageBox.Show("Out of time!");
                this.Hide();
                globaldata.HLife = globaldata.HLife + 1;
                globaldata.Score--;
                if (globaldata.HLife == 3)
                {
                    globaldata.HQCount = 0;
                    timer1.Stop();
                    endscreen end1 = new endscreen();
                    this.Hide();
                    end1.Show();
                }
            }
        }

        private void picBomb_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            globaldata.HCount++;
            lblTime.Visible = false;
            MessageBox.Show("Good job!");
            this.Hide();
        }
    }
}

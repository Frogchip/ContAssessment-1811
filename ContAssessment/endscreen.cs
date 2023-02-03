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
    public partial class endscreen : Form
    {
        public endscreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLead_Click(object sender, EventArgs e)
        {
            lead lead1 = new lead();
            this.Hide();
            lead1.Show();
        }

        private void endscreen_Load(object sender, EventArgs e)
        {
            if (globaldata.ELife == 5)
            {
                globaldata.Score++;
            }
            if (globaldata.NLife == 3)
            {
                globaldata.Score++;
            }
            if (globaldata.HLife == 2)
            {
                globaldata.Score++;
            }
            lblScore.Text = globaldata.Score + "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            globaldata.Score = 0;
            difficulty diff1 = new difficulty();
            this.Hide();
            diff1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblFailed_Click(object sender, EventArgs e)
        {

        }

        private void lblGold_Click(object sender, EventArgs e)
        {

        }

        private void lblPlat_Click(object sender, EventArgs e)
        {

        }
    }
}

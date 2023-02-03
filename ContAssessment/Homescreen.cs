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
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace ContAssessment
{
    public partial class Homescreen : Form
    {
        List<Playerdata> pdata = new List<Playerdata>();
        IFormatter serializer = new BinaryFormatter();
        IFormatter deserializer = new BinaryFormatter();
        bool registered = false;
        public Homescreen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            registered = false;

            //Validate the username and password
            if (txtUsername.Text.Length < 6)
            {
                MessageBox.Show("Username must be length of at least 6 characters");
                return;
            }

            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be length of at least 6 characters");
                return;
            }

            if (!File.Exists(mystatic.pdata))
            {
                MessageBox.Show("Click register to register the new account");
                return;
            }
            //Get the list of users by deserializing to a list of user objects
            using (Stream filestream = File.Open(mystatic.pdata, FileMode.Open))
            {
                pdata = (List<Playerdata>)deserializer.Deserialize(filestream);
            }
            //Check the list to see if username already in use
            foreach (Playerdata searchuser in pdata)
            {
                if (searchuser.Username == txtUsername.Text)
                {
                    if (searchuser.Password == txtPassword.Text)
                    {
                        registered = true;
                    }
                    else
                    {
                        MessageBox.Show("Username found but password is incorrect - please try again.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("This username is not associated with any account - please try again.");
                }

            }

            if (registered)
            {
                difficulty Q1 = new difficulty();
                this.Hide();
                Q1.Show();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length < 6)
            {
                MessageBox.Show("Username must be length of at least 6 characters");
                return;
            }

            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be length of at least 6 characters");
                return;
            }

            //Check if user file exists - if not then create the file and write the new user
            if (!File.Exists(mystatic.pdata))
            {
                using (Stream filestream = File.Open(mystatic.pdata, FileMode.Create))
                {
                    Playerdata newuser = new Playerdata(txtUsername.Text, txtPassword.Text);
                    pdata.Add(newuser);
                    serializer.Serialize(filestream, pdata); // Serialise data using a list of user objects
                    pdata.Clear();
                }

                MessageBox.Show("Welcome" + txtUsername.Text + "you are now registered.");
                difficulty Q1 = new difficulty();
                this.Hide();
                Q1.Show();
            }
            else //User file exists so check username not taken
            {
                //Get the list of users by deserializing to a list of new objects
                using (Stream filestream = File.Open(mystatic.pdata, FileMode.Open))
                {
                    pdata = (List<Playerdata>)deserializer.Deserialize(filestream);
                }

                //Check the list to see if username is already in use
                foreach (Playerdata searchuser in pdata)
                {
                    if (searchuser.Username == txtUsername.Text)
                    {
                        MessageBox.Show("Sorry, this username is already in use. Please try another one.");
                        return;
                    }
                }
            }
            //Username not found so delete old file and write a new file or existing users plus new user

            File.Delete(mystatic.pdata);

            using (Stream filestream = File.Open(mystatic.pdata, FileMode.Create))
            {
                Playerdata newuser = new Playerdata(txtUsername.Text, txtPassword.Text);
                pdata.Add(newuser);

                try
                {
                    serializer.Serialize(filestream, pdata);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            MessageBox.Show("Welcome" + txtUsername.Text + "you are now registered.");



        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Homescreen_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            globaldata.Admin++;
            difficulty diff1 = new difficulty();
            diff1.Show();
            this.Hide();
        }
    }
}

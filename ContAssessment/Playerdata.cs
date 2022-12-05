using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContAssessment
{
    [Serializable]

    class Playerdata : IComparable<Playerdata>
    {

        private string username;
        private string password;
        private int score;

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public int Score
        {
            get { return this.score; }
            set { this.score = value; }
        }

        public Playerdata()
        { }
        public Playerdata(string iusername, string ipassword)
        {
            this.Username = iusername;
            this.Password = ipassword;
        }
        public int CompareTo(Playerdata other)
        {
            if (globaldata.sorttable == 'u')
            {
                int compare = string.Compare(this.username, other.username);
                return compare;
            }
            else if (globaldata.sorttable == 'p')
            {
                int compare = string.Compare(this.password, other.password);
                return compare;
            }
            else
            {
                int compare = this.score.CompareTo(other.score);
                return compare;
            }
        }
    }
}

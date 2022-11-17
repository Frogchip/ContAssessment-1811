using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContAssessment
{
    [Serializable]

    class Playerdata
    {
        private string username;
        private string password;

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

        public Playerdata()
        { }
        public Playerdata(string iusername, string ipassword)
        {
            this.Username = iusername;
            this.Password = ipassword;
        }
    }
}

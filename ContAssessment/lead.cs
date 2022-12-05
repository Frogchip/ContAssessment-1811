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
    [Serializable]
    public partial class lead : Form
    {
        List<Playerdata> pdata = new List<Playerdata>();
        IFormatter serializer = new BinaryFormatter();
        IFormatter deserializer = new BinaryFormatter();
        public lead()
        {
            InitializeComponent();
        }

        private void btnUsername_Click(object sender, EventArgs e)
        {
            globaldata.sorttable = 'u';
            //readlist.Sort();
            dgLead.Refresh();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            globaldata.sorttable = 's';
            //readlist.Sort();
            dgLead.Refresh();
        }

        private void lead_Load(object sender, EventArgs e)
        {
            using (Stream filestream = File.Open(mystatic.pdata, FileMode.Open))
            {
                pdata = (List<Playerdata>)deserializer.Deserialize(filestream);
            }
            using (Stream filestream = File.Open(mystatic.pdata, FileMode.Create))
            {
                serializer.Serialize(filestream, pdata); // Serialise data using a list of user objects
                pdata.Clear();
            }
        }
    }
}

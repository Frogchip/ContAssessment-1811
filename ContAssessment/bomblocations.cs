using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContAssessment
{
    public class bomblocations
    {
        private int left;
        private int top;
        public int Left
        {
            get { return this.left; }
            set { this.left = value; }
        }
        public int Top
        {
            get { return this.top; }
            set { this.top = value; }
        }
        public bomblocations()
        { }
        public bomblocations(int itop, int ileft)
        {
            this.Top = itop;
            this.Left = ileft;
        }
    }
}


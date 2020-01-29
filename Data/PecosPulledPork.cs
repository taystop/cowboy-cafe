using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree.
    /// </summary>
    class PecosPulledPork
    {

        private bool bread = true;
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }


        private bool pickle = true;
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
    }
}

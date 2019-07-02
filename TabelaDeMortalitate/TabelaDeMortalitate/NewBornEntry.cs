using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaDeMortalitate
{
    public class NewBornEntry
    {
        private int newBornsYear0;
        bool flag = true;

        public int NewBornsYear0
        {
            get { return newBornsYear0; }
            set { newBornsYear0 = value; flag = false; }
        }
        private int newBornsYear1;

        public int NewBornsYear1
        {
            get { return newBornsYear1; }
            set { newBornsYear1 = value; flag = false; }
        }
        private int newBornsYear2;

        public int NewBornsYear2
        {
            get { return newBornsYear2; }
            set { newBornsYear2 = value; flag = false; }
        }
        private int newBornsYear3;

        public int NewBornsYear3
        {
            get { return newBornsYear3; }
            set { newBornsYear3 = value; flag = false; }
        }

        public bool CheckForNoData()
        {
            return flag;
        }
    }
}

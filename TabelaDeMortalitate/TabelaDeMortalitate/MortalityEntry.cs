using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaDeMortalitate
{
    public class MortalityEntry
    {
        private string strAge;

        public string StrAge
        {
            get { return strAge; }
            set { strAge = value; }
        }

        private int intAge;

        public int IntAge
        {
            get { return intAge; }
            set { intAge = value; }
        }

        private int mortalityValueYear1;

        public int MortalityValueYear1
        {
            get { return mortalityValueYear1; }
            set { mortalityValueYear1 = value; }
        }

        private int mortalityValueYear2;

        public int MortalityValueYear2
        {
            get { return mortalityValueYear2; }
            set { mortalityValueYear2 = value; }
        }

        private int mortalityValueYear3;

        public int MortalityValueYear3
        {
            get { return mortalityValueYear3; }
            set { mortalityValueYear3 = value; }
        }

    }
}

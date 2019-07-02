using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaDeMortalitate
{
    public static class StructureExcel
    {
        private static int maxAge;

        public static int MaxAge
        {
            get { return maxAge; }
            set { maxAge = value; }
        }

        private static List<int> populationYear2 = new List<int>();

        public static List<int> PopulationYear2
        {
            get { return populationYear2; }
            set { populationYear2 = value; }
        }

        private static List<int> populationYear3 = new List<int>();

        public static List<int> PopulationYear3
        {
            get { return populationYear3; }
            set { populationYear3 = value; }
        }

        private static List<double> populationAverage = new List<double>();

        public static List<double> PopulationAverage
        {
            get { return populationAverage; }
        }

        public static void setPopulationAverage()
        {
            for (int i = 0; i < populationYear2.Count(); i++)
                populationAverage.Add((populationYear2.ElementAt(i) * 1.0 + populationYear3.ElementAt(i) * 1.0) / 2);
        }



        private static List<int> mortalitysFirstYear = new List<int>();

        public static List<int> MortalitysFirstYear
        {
            get { return mortalitysFirstYear; }
            set { mortalitysFirstYear = value; }
        }

        private static List<int> mortalitysSecondYear = new List<int>();

        public static List<int> MortalitysSecondYear
        {
            get { return mortalitysSecondYear; }
            set { mortalitysSecondYear = value; }
        }

        private static List<int> mortalitysThirdYear = new List<int>();
        public static List<int> MortalitysThirdYear
        {
            get { return mortalitysThirdYear; }
            set { mortalitysThirdYear = value; }
        }

        private static int[] newBorns = new int[4];

        public static int[] NewBorns
        {
            get { return StructureExcel.newBorns; }
            set { StructureExcel.newBorns = value; }
        }

    }
}

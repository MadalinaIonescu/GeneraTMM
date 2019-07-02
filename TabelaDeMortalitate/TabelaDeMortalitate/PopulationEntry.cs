using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaDeMortalitate
{
   public class PopulationEntry
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

       private int populationValueYear2;

       public int PopulationValueYear2
       {
           get { return populationValueYear2; }
           set { populationValueYear2 = value; }
       }

       private int populationValueYear3;

       public int PopulationValueYear3
       {
           get { return populationValueYear3; }
           set { populationValueYear3 = value; }
       }
   }
}

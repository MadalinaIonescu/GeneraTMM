using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaDeMortalitate
{
    public class OutputFormat
    {
        private List<double> x= new List<double>();

        public List<double> X
        {
            get { return x; }
            set { x = value; }
        }
        private List<double> Sx=new List<double>();

        public List<double> SX
        {
            get { return Sx; }
            set { Sx = value; }
        }
        private List<double> dxx1 = new List<double>();

        public List<double> Dxx1
        {
            get { return dxx1; }
            set { dxx1 = value; }
        }
        private List<double> mx = new List<double>();

        public List<double> Mx
        {
            get { return mx; }
            set { mx = value; }
        }
        private List<double> qx = new List<double>();

        public List<double> Qx
        {
            get { return qx; }
            set { qx = value; }
        }
        private List<double> px = new List<double>();

        public List<double> Px
        {
            get { return px; }
            set { px = value; }
        }
        private List<double> Lx = new List<double>();

        public List<double> LX
        {
            get { return Lx; }
            set { Lx = value; }
        }

        private List<double> Tx = new List<double>();

        public List<double> TX
        {
            get { return Tx; }
            set { Tx = value; }
        }
        private List<double> ex = new List<double>();

        public List<double> Ex
        {
            get { return ex; }
            set { ex = value; }
        }

    }
}

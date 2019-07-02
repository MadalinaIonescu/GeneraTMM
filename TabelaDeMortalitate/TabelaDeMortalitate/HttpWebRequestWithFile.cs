using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace TabelaDeMortalitate
{
     public class HttpWebRequestWithFile 
    {
        private HttpWebRequest request;

        public HttpWebRequest Request
        {
            get { return request; }
            set { request = value; }
        }
        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        private int delay;

        public int Delay
        {
            get { return delay; }
            set { delay = value; }
        }


    }
}

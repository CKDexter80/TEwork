using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SearchApplication.Util
{
    class TELog
    {
        public static void Log(string message)
        {
            //TODO add try catch
            using (StreamWriter sw = new StreamWriter("logs/search.log", true))
            {
                sw.WriteLine(message);
            }
        }
    }
}

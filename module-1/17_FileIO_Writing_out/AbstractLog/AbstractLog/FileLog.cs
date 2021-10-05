using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AbstractLog
{
    public class FileLog : LogBase
    {
        private static string location = Environment.CurrentDirectory;
        private static string fileName = "log.txt";
        private  static string fullPath = Path.Combine(location, fileName);
        public override void Log(string message)
        {
            using (StreamWriter sw = new StreamWriter(fullPath, true))
            {
                sw.WriteLine(message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AbstractLog
{
    public class FileLog : LogBase
    {
        private string location { get; } = Environment.CurrentDirectory;
        private string fileName { get; } = "log.txt";
        private string fullPath { get; }

        public FileLog()
        {
            fullPath = Path.Combine(location, fileName);
        }
        public override void Log(string message)
        {
            using (StreamWriter sw = new StreamWriter(fullPath, true))
            {
                sw.WriteLine(message);
            }
        }
    }
}

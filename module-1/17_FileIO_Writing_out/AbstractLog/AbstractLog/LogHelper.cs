using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractLog
{
    public static class LogHelper
    {
        public static void Log(LogTypes target, string message)
        {
            if (target == LogTypes.File)
            {
                FileLog fl = new FileLog();
                fl.Log(message);
            } else if (target == LogTypes.Database)
            {
                DBLogger db = new DBLogger();
                db.Log(message);
            }
        }
    }
}

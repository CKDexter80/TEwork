using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractLog
{
    class DBLogger : LogBase
    {
        //database specific
        public override void Log(string message)
        {
            throw new NotImplementedException();
        }
    }
}

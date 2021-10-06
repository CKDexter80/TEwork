using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractLog
{
    class DBLog : LogBase
    {
        //database specific
        public override void Log(string message)
        {
            throw new NotImplementedException();
        }
    }
}

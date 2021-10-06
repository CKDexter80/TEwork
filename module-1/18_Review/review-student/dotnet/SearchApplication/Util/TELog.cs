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
            //ADD TRY/CATCH
            try
            {
                using (StreamWriter sw = new StreamWriter("logs/search.log", true))
                {
                    sw.WriteLine(message);
                }
            }
            catch (Exception e)
            {

               Console.WriteLine(e.Message); ;
            }
            
        }
    }
}

using System;

namespace Business.ccs
{
    public class DatabaseLogger : ILogger
    {

        public void Log()
        {
            Console.WriteLine("Veritabanina loglandi");
        }
    }
}

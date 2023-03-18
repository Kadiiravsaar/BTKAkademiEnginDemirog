using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciBloklaraGiris
{
    public class Database : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }
}

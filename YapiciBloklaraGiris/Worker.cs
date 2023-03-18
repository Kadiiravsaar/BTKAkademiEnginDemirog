using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciBloklaraGiris
{
    public class Worker
    {
        public ILogger _logger { get; set; }
        public Worker(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine($"{_logger} to added");
        }
    }
}

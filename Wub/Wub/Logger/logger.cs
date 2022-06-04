using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wub.Logger
{
    public class logger
    {
        private List<string> loggers = new List<string>();
        private string output = "log.txt";

        public void add(string message)
        {
            loggers.Add(message);
        }

        public void dump()
        {
            File.WriteAllLines(output, loggers);
        }
    }
}

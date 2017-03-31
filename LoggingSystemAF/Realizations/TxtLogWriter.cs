using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingSystemAF.Interfaces;

namespace LoggingSystemAF.Realizations
{
    class TxtLogWriter:ILogWriter
    {
        public void WriteToLogFile(string file, string message)
        {
            throw new NotImplementedException();
        }
    }
}

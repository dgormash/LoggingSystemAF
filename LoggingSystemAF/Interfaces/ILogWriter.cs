﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSystemAF.Interfaces
{
    public interface ILogWriter
    {
        void WriteToLogFile(string file, string message);
    }
}

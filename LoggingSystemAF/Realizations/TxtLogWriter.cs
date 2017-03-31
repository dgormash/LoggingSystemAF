using System.IO;
using LoggingSystemAF.Interfaces;

namespace LoggingSystemAF.Realizations
{
    class TxtLogWriter:ILogWriter
    {
        public void WriteToLogFile(string file, string message)
        {
            using (var writer = new StreamWriter(file))
            {
                writer.Write(message);
            }
        }
    }
}

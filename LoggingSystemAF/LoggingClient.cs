using System;
using LoggingSystemAF.Interfaces;
using LoggingSystemAF.Interfaces.AFactory;

namespace LoggingSystemAF
{
    public class LoggingClient
    {
        readonly ILogWriter _writer;
        //ILogReader _reader;
        readonly ILogFile _file;
        readonly IMessage _message;
        public LoggingClient(ILogger logger)
        {
            _file = logger.CreateLogFile();
            _writer = logger.CreateLogWriter();
            _message = logger.CreateMessage();
            //_reader = logger.CreateLogReader();
        }

        public string MakeRecordToLog(string fileName, string message, MessageTypes type)
        {

            var result = string.Empty;
            try
            {
                _file.CreateFile(fileName);
                _message.Message = message;
                _message.SetMessageType(type);
                _writer.WriteToLogFile(_file.Name, _message.Message);
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
    }
}

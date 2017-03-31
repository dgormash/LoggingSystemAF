
using LoggingSystemAF.Interfaces;
using LoggingSystemAF.Interfaces.AFactory;

namespace LoggingSystemAF.Realizations
{
    //Класс TxtLogger, реализующий интерфейс ILogger, является представителем ConcreteFactory и 
    //создаёт элементы системы
    class TxtLogger:ILogger
    {
        public ILogWriter CreateLogWriter()
        {
            return new TxtLogWriter();
        }

        public ILogReader CreateLogReader()
        {
            return new TxtLogReader();
        }

        public ILogFile CreateLogFile()
        {
            return new TxtLogFile();
        }

        public IMessage CreateMessage()
        {
            return new TxtMessage();
        }
    }
}

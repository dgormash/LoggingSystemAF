namespace LoggingSystemAF.Interfaces.AFactory
{
    interface ILogger //Абстрактный логгер (только создаёт продукты (элементы) системы)
    {
        ILogWriter CreateLogWriter();
        ILogReader CreateLogReader();
        ILogFile CreateLogFile();
        IMessage CreateMessage();
    }
}

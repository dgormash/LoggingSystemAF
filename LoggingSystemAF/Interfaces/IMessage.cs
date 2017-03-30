
namespace LoggingSystemAF.Interfaces
{
    interface IMessage //Абстрактное сообщение
    {
        string GetMessage(MessageTypes type);
    }
}

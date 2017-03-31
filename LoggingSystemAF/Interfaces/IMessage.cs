
namespace LoggingSystemAF.Interfaces
{
    public interface IMessage //Абстрактное сообщение
    {  
        string Message { get; set; }
        void SetMessageType(MessageTypes type);
    }
}

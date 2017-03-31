
namespace LoggingSystemAF.Interfaces
{
    interface IMessage //Абстрактное сообщение
    {  
        void SetMessage(MessageTypes type, string message);
    }
}

using LoggingSystemAF.Interfaces;

namespace LoggingSystemAF.Realizations
{
    internal class TxtMessage : IMessage
    {
        public string Message { get; set; }
        public void SetMessage(MessageTypes type, string message)
        {
            switch (type)
            {
                case MessageTypes.Normal:
                    break;
                case MessageTypes.Good:
                    break;
                case MessageTypes.Error:
                    break;
                case MessageTypes.CriticalError:
                    break;
                case MessageTypes.FatalError:
                    break;
            }
        }
    }
}
using LoggingSystemAF.Interfaces;

namespace LoggingSystemAF.Realizations
{
    internal class TxtMessage : IMessage
    {
        public string Message { get; set; }
        public void SetMessageType(MessageTypes type)
        {
            switch (type)
            {
                case MessageTypes.Normal:
                    Message = $"[Message]: {Message}";
                    break;
                case MessageTypes.Good:
                    Message = $"[Message]: {Message}";
                    break;
                case MessageTypes.Error:
                    Message = $"[Error]: {Message}";
                    break;
                case MessageTypes.CriticalError:
                    Message = $"[CriticalError]: {Message}";
                    break;
                case MessageTypes.FatalError:
                    Message = $"[FatalError]: {Message}";
                    break;
                default:
                    Message = $"[Message]: {Message}";
                    break;
            }
        }
    }
}
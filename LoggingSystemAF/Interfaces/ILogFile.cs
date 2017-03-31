namespace LoggingSystemAF.Interfaces
{
    
    public interface ILogFile //Абстрактный файл лога
    {
        string Name { get;  set; }
        void CreateFile(string fullName);
    }
}

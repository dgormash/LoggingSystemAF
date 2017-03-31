using LoggingSystemAF.Interfaces;
using System;
using System.IO;

namespace LoggingSystemAF.Realizations
{
    //Класс TxtLogFile реализует интерфейс ILogFile, создавая файл с расширением .txt, по пути, указанному в fullName
    internal class TxtLogFile : ILogFile
    {
        public string Name { get; private set; }
        public void CreateFile(string fullName)
        {
            Name = fullName;
            if (!File.Exists(Name))
            {
                File.Create(Name);
            }
        }
    }
}
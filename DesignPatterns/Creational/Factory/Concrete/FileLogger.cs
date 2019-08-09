using System;
using DesignPatterns.Creational.Factory.Interface;

namespace DesignPatterns.Creational.Factory.Concrete
{
    public class FileLogger : ILogger
    {
        public FileLogger()
        {

        }

        public void LogError(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }

        public void LogInformation(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }

        public void LogWarning(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }
    }
}

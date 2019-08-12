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
            Console.WriteLine($"Error Logger configured using {errorMessage}");
        }

        public void LogInformation(string errorMessage)
        {
            Console.WriteLine($"Information Logger configured using {errorMessage}");
        }

        public void LogWarning(string errorMessage)
        {
            Console.WriteLine($"Warning Logger configured using {errorMessage}");
        }
    }
}

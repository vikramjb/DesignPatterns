using System;
using DesignPatterns.Creational.Factory.Interface;

namespace DesignPatterns.Creational.Factory.Concrete
{
    public class NullLogger : ILogger
    {
        public NullLogger()
        {

        }
        public void LogError(string errorMessage)
        {
            Console.WriteLine($"No Error Logger configured using {errorMessage}");
        }

        public void LogInformation(string errorMessage)
        {
            Console.WriteLine($"No Information Logger configured using {errorMessage}");
        }

        public void LogWarning(string errorMessage)
        {
            Console.WriteLine($"No Warning Logger configured using {errorMessage}");
        }
    }
}

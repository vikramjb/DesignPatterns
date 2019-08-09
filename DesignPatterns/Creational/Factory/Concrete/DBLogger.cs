using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Creational.Factory.Interface;

namespace DesignPatterns.Creational.Factory.Concrete
{
    public class DBLogger : ILogger
    {
        public DBLogger()
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

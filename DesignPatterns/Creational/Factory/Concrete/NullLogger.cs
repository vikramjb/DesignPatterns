using System;
using System.Collections.Generic;
using System.Text;
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
            
        }

        public void LogInformation(string errorMessage)
        {
            
        }

        public void LogWarning(string errorMessage)
        {
            
        }
    }
}

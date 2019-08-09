using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Factory.Interface
{
    public interface ILogger
    {
        void LogInformation(string errorMessage);
        void LogWarning(string errorMessage);
        void LogError(string errorMessage);

    }
}

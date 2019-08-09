﻿using DesignPatterns.Creational.Factory.Concrete;
using DesignPatterns.Creational.Factory.Interface;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Logger Implementation with Factory Design Pattern
            ILogger fileLogger = LogFactory.GetInstance.CreateFileLogger();
            fileLogger.LogError("File Error Logging");
            ILogger dbLogger = LogFactory.GetInstance.CreateDBLogger();
            dbLogger.LogInformation("DB Error Logging");
            ILogger consoleLogger = LogFactory.GetInstance.CreateConsoleLogger();
            consoleLogger.LogWarning("Console Error Logging");

        }
    }
}

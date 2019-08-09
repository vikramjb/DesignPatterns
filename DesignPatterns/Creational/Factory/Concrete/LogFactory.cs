using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Creational.Factory.Interface;

namespace DesignPatterns.Creational.Factory.Concrete
{
    public class LogFactory : ILogFactory
    {
        private LogFactory()
        {

        }

        public static ILogFactory GetInstance { get; } = new LogFactory();

        public ILogger CreateConsoleLogger()
        {
            return new ConsoleLogger();
        }

        public ILogger CreateDBLogger()
        {
            return new DBLogger();
        }

        public ILogger CreateFileLogger()
        {
            return new FileLogger();
        }
    }
}

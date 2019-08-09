using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Creational.Factory.Interface;

namespace DesignPatterns.Creational.Factory.Concrete
{
    public class LogFactory : ILogFactory
    {

        static ILogFactory _localInstance = new LogFactory();

        private LogFactory()
        {

        }

        public static ILogFactory GetInstance
        {
            get
            {
                return _localInstance;
            }
        }

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

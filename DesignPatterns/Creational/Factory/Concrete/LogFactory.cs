using DesignPatterns.Creational.Enum;
using DesignPatterns.Creational.Factory.Interface;

namespace DesignPatterns.Creational.Factory.Concrete
{
    public class LogFactory : ILogFactory
    {

        private LogFactory()
        {

        }

        public static ILogFactory GetInstance { get; } = new LogFactory();


        public ILogger CreateLogger(LogTypes logType)
        {
            switch (logType)
            {
                case LogTypes.None:
                    return new DBLogger();
                case LogTypes.Console:
                    return new ConsoleLogger();
                case LogTypes.DB:
                    return new DBLogger();
                case LogTypes.File:
                    return new FileLogger();
                default:
                    return new NullLogger();
            }
        }
    }
}

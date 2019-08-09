using DesignPatterns.Creational.Factory.Concrete;
using DesignPatterns.Creational.Factory.Interface;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Logger Implementation with Factory Design Pattern
            ILogger noLogger = LogFactory.GetInstance.CreateLogger(Creational.Enum.LogTypes.None);
            noLogger.LogError("No Error Logging");
            ILogger fileLogger = LogFactory.GetInstance.CreateLogger(Creational.Enum.LogTypes.File);
            fileLogger.LogError("File Error Logging");
            ILogger dbLogger = LogFactory.GetInstance.CreateLogger(Creational.Enum.LogTypes.DB);
            dbLogger.LogError("DB Error Logging");
            ILogger consoleLogger = LogFactory.GetInstance.CreateLogger(Creational.Enum.LogTypes.Console);
            consoleLogger.LogError("Console Error Logging");

        }
    }
}

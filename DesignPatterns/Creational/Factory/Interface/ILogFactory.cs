using DesignPatterns.Creational.Enum;

namespace DesignPatterns.Creational.Factory.Interface
{
    public interface ILogFactory
    {
        ILogger CreateLogger(LogTypes logType);
    }
}

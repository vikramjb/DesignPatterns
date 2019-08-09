using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Factory.Interface
{
    public interface ILogFactory
    {
        ILogger CreateDBLogger();
        ILogger CreateConsoleLogger();
        ILogger CreateFileLogger();
    }
}

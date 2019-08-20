using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Singleton.Interface
{
    public interface IDBConnector
    {
        void Connect();
        void Disconnect();
    }
}

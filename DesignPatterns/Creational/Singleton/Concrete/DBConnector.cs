using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Creational.Singleton.Interface;

namespace DesignPatterns.Creational.Singleton.Interface
{
    public class DBConnector : IDBConnector
    {
        private static DBConnector _dbConnector;
        private static string _instanceId;

        private DBConnector()
        {
        }


        public static DBConnector GetInstance(string instanceId)
        {
            if (_dbConnector == null)
            {
                _dbConnector = new DBConnector();
                _instanceId = instanceId;
            }
            return _dbConnector;
        }


        public void Connect()
        {
            Console.WriteLine($"Connected to {_instanceId} database instance.");
        }

        public void Disconnect()
        {
            Console.WriteLine($"Disconnected from {_instanceId} database instance.");
        }
    }
}

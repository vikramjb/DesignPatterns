using System;
using DesignPatterns.Creational.AbstractFactory.Interface;
using DesignPatterns.Creational.Enum;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Factory Pattern
                ////Logger Implementation with Factory Design Pattern
                //ILogger noLogger = LogFactory.GetInstance.CreateLogger(Creational.Enum.LogTypes.None);
                //noLogger.LogError("No Error Logging");
                //ILogger fileLogger = LogFactory.GetInstance.CreateLogger(Creational.Enum.LogTypes.File);
                //fileLogger.LogError("File Error Logging");
                //ILogger dbLogger = LogFactory.GetInstance.CreateLogger(Creational.Enum.LogTypes.DB);
                //dbLogger.LogError("DB Error Logging");
                //ILogger consoleLogger = LogFactory.GetInstance.CreateLogger(Creational.Enum.LogTypes.Console);
                //consoleLogger.LogError("Console Error Logging");
            #endregion


            #region Abstract Factory Pattern

            IUIFactory uiFactory = GetUIConfig(OperatingSystemUITypes.None);
            uiFactory.CreateButton().Draw();
            uiFactory.CreateRadioButton().Draw();
            uiFactory.CreateTextBox().Draw();
            uiFactory.CreateCheckBox().Draw();

            uiFactory = GetUIConfig(OperatingSystemUITypes.Windows);
            uiFactory.CreateButton().Draw();
            uiFactory.CreateRadioButton().Draw();
            uiFactory.CreateTextBox().Draw();
            uiFactory.CreateCheckBox().Draw();

            uiFactory = GetUIConfig(OperatingSystemUITypes.MAC);
            uiFactory.CreateButton().Draw();
            uiFactory.CreateRadioButton().Draw();
            uiFactory.CreateTextBox().Draw();
            uiFactory.CreateCheckBox().Draw();

            uiFactory = GetUIConfig(OperatingSystemUITypes.Linux);
            uiFactory.CreateButton().Draw();
            uiFactory.CreateRadioButton().Draw();
            uiFactory.CreateTextBox().Draw();
            uiFactory.CreateCheckBox().Draw();
            #endregion



        }

        private static IUIFactory GetUIConfig(OperatingSystemUITypes osUIType)
        {
            switch (osUIType)
            {
                case OperatingSystemUITypes.None:
                    return new Creational.AbstractFactory.Concrete.None.UIFactory();
                case OperatingSystemUITypes.Windows:
                    return new Creational.AbstractFactory.Concrete.Windows.UIFactory();
                case OperatingSystemUITypes.Linux:
                    return new Creational.AbstractFactory.Concrete.Linux.UIFactory();
                case OperatingSystemUITypes.MAC:
                    return new Creational.AbstractFactory.Concrete.MacOS.UIFactory();
            }
            throw new NotImplementedException();
        }
    }
}

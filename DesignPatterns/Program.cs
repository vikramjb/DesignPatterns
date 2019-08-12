using System;
using DesignPatterns.Creational.AbstractFactory.Interface;
using DesignPatterns.Creational.Factory.Concrete;
using DesignPatterns.Creational.Factory.Interface;
using DesignPatterns.Enum;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Factory Pattern
            //Logger Implementation with Factory Design Pattern
            ILogger logger = LogFactory.GetInstance.CreateLogger(LogTypes.None);
            logger.LogError($"{logger.GetType()}");
            logger.LogInformation($"{logger.GetType()}");
            logger.LogWarning($"{logger.GetType()}");

            logger = LogFactory.GetInstance.CreateLogger(LogTypes.File);
            logger.LogError($"{logger.GetType()}");
            logger.LogInformation($"{logger.GetType()}");
            logger.LogWarning($"{logger.GetType()}");


            logger = LogFactory.GetInstance.CreateLogger(LogTypes.DB);
            logger.LogError($"{logger.GetType()}");
            logger.LogInformation($"{logger.GetType()}");
            logger.LogWarning($"{logger.GetType()}");


            logger = LogFactory.GetInstance.CreateLogger(LogTypes.Console);
            logger.LogError($"{logger.GetType()}");
            logger.LogInformation($"{logger.GetType()}");
            logger.LogWarning($"{logger.GetType()}");

            #endregion


            #region Abstract Factory Pattern

            IUIFactory uiFactory = GetUISpecificFactory(OperatingSystemUITypes.None);
            uiFactory.CreateButton().Draw();
            uiFactory.CreateRadioButton().Draw();
            uiFactory.CreateTextBox().Draw();
            uiFactory.CreateCheckBox().Draw();

            uiFactory = GetUISpecificFactory(OperatingSystemUITypes.Windows);
            uiFactory.CreateButton().Draw();
            uiFactory.CreateRadioButton().Draw();
            uiFactory.CreateTextBox().Draw();
            uiFactory.CreateCheckBox().Draw();

            uiFactory = GetUISpecificFactory(OperatingSystemUITypes.MAC);
            uiFactory.CreateButton().Draw();
            uiFactory.CreateRadioButton().Draw();
            uiFactory.CreateTextBox().Draw();
            uiFactory.CreateCheckBox().Draw();

            uiFactory = GetUISpecificFactory(OperatingSystemUITypes.Linux);
            uiFactory.CreateButton().Draw();
            uiFactory.CreateRadioButton().Draw();
            uiFactory.CreateTextBox().Draw();
            uiFactory.CreateCheckBox().Draw();
            #endregion



        }

        private static IUIFactory GetUISpecificFactory(OperatingSystemUITypes osUIType)
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

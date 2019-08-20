using System;
using DesignPatterns.Creational.AbstractFactory.Interface;
using DesignPatterns.Creational.Builder.Concrete;
using DesignPatterns.Creational.Factory.Concrete;
using DesignPatterns.Creational.Factory.Interface;
using DesignPatterns.Creational.Singleton.Interface;
using DesignPatterns.Creational.Prototype.Concrete;
using DesignPatterns.Enum;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************************************************");
            InvokeFactoryPattern();
            Console.WriteLine("*****************************************************************************");
            InvokeAbstractFactoryPattern();
            Console.WriteLine("*****************************************************************************");
            InvokeBuilderPattern();
            Console.WriteLine("*****************************************************************************");
            InvokeSingletonPattern();
            Console.WriteLine("*****************************************************************************");
        }

        private static void InvokeSingletonPattern()
        {
            int dbInstanceCounter = 3;

            for (int iCounter= 0; iCounter < dbInstanceCounter; iCounter++)
            {
                Console.WriteLine($"Trying to connect with Counter_{iCounter}");
                DBConnector dBConnector = DBConnector.GetInstance($"Counter_{iCounter}");
                dBConnector.Connect();
                dBConnector.Disconnect();
            }
            InvokePrototypePattern();
            Console.WriteLine("*****************************************************************************");

        }

        private static void InvokePrototypePattern()
        {
            Lamb warmWhiteLamb = new Lamb("Warm","White",4);
            var cloneLamb1 = warmWhiteLamb.Clone();
            Lamb coldWhiteLamb = new Lamb("Cold", "White", 4);
            var cloneLamb2 = coldWhiteLamb.Clone();
            Lamb coldRedLamb = new Lamb("Cold", "Red", 4);
            var cloneLamb3 = coldRedLamb.Clone();
        }

        private static void InvokeBuilderPattern()
        {
            var robotBuilder = new RobotCreator(new DumbRobotBuilder());
            robotBuilder.CreateRobot();
            var robot = robotBuilder.GetRobot();
            robot.ShowRobotInfo();

            robotBuilder = new RobotCreator(new SmartRobotBuilder());
            robotBuilder.CreateRobot();
            robot = robotBuilder.GetRobot();
            robot.ShowRobotInfo();
        }

        private static void InvokeFactoryPattern()
        {
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
        }

        private static void InvokeAbstractFactoryPattern()
        {
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

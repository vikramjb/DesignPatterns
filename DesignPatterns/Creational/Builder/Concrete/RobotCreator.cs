using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Creational.Builder.Interface;

namespace DesignPatterns.Creational.Builder.Concrete
{
    public class RobotCreator
    {
        public IRobotBuilder robotBuilder;

        public RobotCreator(IRobotBuilder builder)
        {
            robotBuilder = builder;
        }

        public void CreateRobot()
        {
            robotBuilder.SetArm();
            robotBuilder.SetHead();
            robotBuilder.SetLeg();
            robotBuilder.SetNeck();
            robotBuilder.SetTorso();
        }

        public Robot GetRobot()
        {
            return robotBuilder.GetRobot();
        }


    }
}

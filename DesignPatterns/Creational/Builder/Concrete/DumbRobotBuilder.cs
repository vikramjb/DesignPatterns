using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Creational.Builder.Interface;

namespace DesignPatterns.Creational.Builder.Concrete
{
    public class DumbRobotBuilder : IRobotBuilder
    {
        readonly Robot dumbRobot = null;
        public DumbRobotBuilder()
        {
            Console.WriteLine("BUILDING A DUMB ROBOT");
            dumbRobot = new Robot();
        }

        public Robot GetRobot()
        {
            return dumbRobot;
        }

        public void SetArm()
        {
            dumbRobot.Arm = "Maple Wooden";
        }

        public void SetHead()
        {
            dumbRobot.Head = "Teak Wood";
        }

        public void SetLeg()
        {
            dumbRobot.Leg = "Aluminium";
        }

        public void SetNeck()
        {
            dumbRobot.Neck = "Spring";
        }

        public void SetTorso()
        {
            dumbRobot.Torso = "Plywood";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Creational.Builder.Interface;

namespace DesignPatterns.Creational.Builder.Concrete
{
    public class SmartRobotBuilder : IRobotBuilder
    {
        readonly Robot smartRobot = null;
        public SmartRobotBuilder()
        {
            Console.WriteLine("BUILDING A SMART ROBOT");
            smartRobot = new Robot();
        }

        public Robot GetRobot()
        {
            return smartRobot;
        }

        public void SetArm()
        {
            smartRobot.Arm = "Iron Arm";
        }

        public void SetHead()
        {
            smartRobot.Head = "Steel Head";
        }

        public void SetLeg()
        {
            smartRobot.Leg = "Titanium Leg";
        }

        public void SetNeck()
        {
            smartRobot.Neck = "Tissue Neck";
        }

        public void SetTorso()
        {
            smartRobot.Torso = "Cotton Torso";
        }
    }
}

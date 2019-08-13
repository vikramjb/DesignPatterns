using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder.Concrete
{
    public class Robot
    {
        public string Head { get; set; }
        public string Neck { get; set; }
        public string Arm { get; set; }
        public string Torso { get; set; }
        public string Leg { get; set; }

        public Robot()
        {

        }

        public void ShowRobotInfo()
        {
            Console.WriteLine($"Head Number is {Head}");
            Console.WriteLine($"Neck Number is {Neck}");
            Console.WriteLine($"Arm Number is {Arm}");
            Console.WriteLine($"Torso Number is {Torso}");
            Console.WriteLine($"Leg Number is {Leg}");
        }


    }
}

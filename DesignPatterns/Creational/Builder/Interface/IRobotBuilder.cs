using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Creational.Builder.Concrete;

namespace DesignPatterns.Creational.Builder.Interface
{
    public interface IRobotBuilder
    {
        Robot GetRobot();
        void SetHead();
        void SetNeck();
        void SetArm();
        void SetTorso();
        void SetLeg();
    }
}

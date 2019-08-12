using System;
using DesignPatterns.Creational.AbstractFactory.Interface;

namespace DesignPatterns.Creational.AbstractFactory.Concrete.MacOS
{
    public class UIRadioButton : IRadioButton
    {
        public void Draw()
        {
            Console.WriteLine($"Created a {this.GetType()} ");
        }
    }
}

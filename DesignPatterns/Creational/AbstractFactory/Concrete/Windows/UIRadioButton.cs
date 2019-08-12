using System;
using DesignPatterns.Creational.AbstractFactory.Interface;

namespace DesignPatterns.Creational.AbstractFactory.Concrete.Windows
{
    internal class UIRadioButton : IRadioButton
    {
        public void Draw()
        {
            Console.WriteLine($"Created a {this.GetType()} ");
        }
    }
}
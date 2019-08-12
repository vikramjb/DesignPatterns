using System;
using DesignPatterns.Creational.AbstractFactory.Interface;

namespace DesignPatterns.Creational.AbstractFactory.Concrete.None
{
    internal class NoneControl : INoneControl
    {
        public void Draw()
        {
            Console.WriteLine($"Created a {this.GetType()} ");
        }
    }
}

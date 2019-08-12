using System;
using DesignPatterns.Creational.AbstractFactory.Interface;

namespace DesignPatterns.Creational.AbstractFactory.Concrete.MacOS
{
    internal class UITextBox : ITextBox
    {
        public void Draw()
        {
            Console.WriteLine($"Created a {this.GetType()} ");
        }
    }
}

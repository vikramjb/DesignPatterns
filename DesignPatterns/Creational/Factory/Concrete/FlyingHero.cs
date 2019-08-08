using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Creational.Factory.Interface;

namespace DesignPatterns.Creational.Factory.Concrete
{
    public class FlyingHero : IFlyingHero
    {
        public FlyingHero()
        {
            Console.WriteLine("Created Flying Hero");
        }
    }
}

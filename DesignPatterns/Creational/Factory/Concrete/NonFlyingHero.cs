using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Creational.Factory.Interface;

namespace DesignPatterns.Creational.Factory.Concrete
{
    public class NonFlyingHero : INonFlyingHero
    {
        public NonFlyingHero()
        {
            Console.WriteLine("Created Non Flying Hero");
        }
    }
}

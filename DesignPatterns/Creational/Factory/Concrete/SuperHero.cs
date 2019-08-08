using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Creational.Factory.Interface;

namespace DesignPatterns.Creational.Factory.Concrete
{
    public class SuperHero : ISuperHero
    {
        private SuperHero()
        {
            Console.WriteLine("Creating SuperHero");
        }

    }
}

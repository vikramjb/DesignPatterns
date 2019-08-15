using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Creational.Prototype.Abstract;

namespace DesignPatterns.Creational.Prototype.Concrete
{
    public class Lamb : LambPrototype
    {

        private string _fur;
        private string _color;
        private int _age;


        private Lamb()
        {

        }

        public Lamb(string fur,string color,int age)
        {
            _fur = fur;
            _color = color;
            _age = age;
            Console.WriteLine($"Instantiating Lamb : {_fur},{_color},{_age}");
        }

        public override LambPrototype Clone()
        {
            Console.WriteLine($"Cloning Lamb : {_fur},{_color},{_age}");
            return this.MemberwiseClone() as LambPrototype;
        }
    }
}

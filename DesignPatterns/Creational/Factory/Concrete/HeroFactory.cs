using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Creational.Factory.Concrete;
using DesignPatterns.Creational.Factory.Interface;

namespace DesignPatterns.Creational.Factory.Concrete
{
    public class HeroFactory : IHeroFactory
    {

        private static IHeroFactory _heroInstance = new HeroFactory();

        //private static readonly Lazy<IHeroFactory> heroLazyInstance = new Lazy<IHeroFactory>(() => new HeroFactory());
        //public static IHeroFactory HeroInstance
        //{
        //    get
        //    {
        //        return heroLazyInstance.Value;
        //    }
        //}

        public static IHeroFactory HeroInstance
        {
            get
            {
                return _heroInstance;
            }
        }

        private HeroFactory()
        {

        }
         
        public ISuperHero CreateFlyingSuperHero()
        {
            return new FlyingHero();
        }

        public ISuperHero CreateNonFlyingSuperHero()
        {
            return new NonFlyingHero();
        }

    }
}

using DesignPatterns.Creational.Factory.Concrete;
using DesignPatterns.Creational.Factory.Interface;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ISuperHero superFlyingHero = HeroFactory.HeroInstance.CreateFlyingSuperHero();
            ISuperHero superNonFlyingHero = HeroFactory.HeroInstance.CreateNonFlyingSuperHero();

        }
    }
}

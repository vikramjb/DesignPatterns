using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Factory.Interface
{
    public interface IHeroFactory
    {
        ISuperHero CreateFlyingSuperHero();
        ISuperHero CreateNonFlyingSuperHero();
    }
}

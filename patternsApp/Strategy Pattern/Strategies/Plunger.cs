using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternsApp.Strategy_Pattern.Strategies
{
    internal class Plunger : IWeapons
    {
        void IWeapons.Shoot()
        {
            Console.WriteLine("atacks with a plunger"); 
        }
    }
}

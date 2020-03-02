using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class FlyweightFactory
    {
        // Only called when requested for the first time, and only run once
        private static readonly Lazy<FlyweightFactory> lazy = new Lazy<FlyweightFactory>(() => new FlyweightFactory());

        // Getting the object from the lazy value
        public static FlyweightFactory Instance { get { return lazy.Value; } }

        // shared flyweight pool
        private Dictionary<String, Flyweight> flyweights = new Dictionary<string, Flyweight>();

        public Flyweight GetFlyweight(String key)
        {
            Flyweight flyweight;
            if(flyweights.TryGetValue(key, out flyweight))
            {
                Console.WriteLine("SHARING a flyweight with key " + key);
            }
            else
            {
                Console.WriteLine("CREATING a flyweight with key " + key);
                Flyweight flyweight1 = new Flyweight(key);
                flyweights.Add(key, flyweight1);
                flyweight =  flyweight1;
            }
            return flyweight;
        }

        public int GetSize()
        {
            return flyweights.Count;
        }
    }
}

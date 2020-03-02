using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Client
    {
        IFlyweight flyweight;
        FlyweightFactory flyweightFactory;

        public Client()
        {
            // Setting up the flyweight factory
            flyweightFactory = FlyweightFactory.Instance;
        }
        

        public void DoTheThing()
        {
            // getting a new flyweight "A" from the factory
            flyweight = flyweightFactory.GetFlyweight("A");
            Console.WriteLine(flyweight.Operation(100) + "\n");

            // getting a new flyweight "B" from the factory
            flyweight = flyweightFactory.GetFlyweight("B");
            Console.WriteLine(flyweight.Operation(50) + "\n");

            // getting a second flyweight "A" from the factory
            flyweight = flyweightFactory.GetFlyweight("A");
            Console.WriteLine(flyweight.Operation(200) + "\n");

            Console.WriteLine("\n -> Number of flyweights created: " + flyweightFactory.GetSize());
        }


    }
}

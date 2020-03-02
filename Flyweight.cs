using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Flyweight : IFlyweight
    {
        private string intrinsicState;

        public Flyweight(string intrinsicState)
        {
            this.intrinsicState = intrinsicState ?? throw new ArgumentNullException(nameof(intrinsicState));
        }

        public string Operation(int extrinsicState)
        {
            return " performing operation on the flyweight"
                + " with intrinsic state = " + intrinsicState
                + " and passed in extrinsic state = " + extrinsicState + ".";
        }
    }
}

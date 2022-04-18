using System;
using System.Collections.Generic;
using System.Text;

namespace OOPConcepts
{
    public class Abstractions
    {
        public abstract class AbstractCars
        {
            public abstract int SeatNumber();

            public virtual string CarColor()
            {
                return "Car color is black";
            }
        }


        public class Toyota : AbstractCars
        {
            public override int SeatNumber()
            {
                return 4;
            }

            public override string CarColor()
            {
                return "Car color is now red";
            }
        }

    }
}

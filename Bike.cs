using System;

namespace Abstraction_Example
{
    class Bike:Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Bike is moving with clutch");
        }
    }
}

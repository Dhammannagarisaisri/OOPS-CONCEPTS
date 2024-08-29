using System;

namespace Abstraction_Example
{
    class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("car is driving");
        }
    }
}


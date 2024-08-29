using System;


namespace Abstraction_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle Car = new Car();
            Vehicle Bike = new Bike();
            Car.Move();
            Bike.Move();

        }
    }
}

using System;

namespace GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            // getters & setters = add security to field by encapsulation
            //                     They`re accessors found within properties

            // properties = combine aspects of both fields and methods (share name with a field)
            // get accessor = used to return the property value
            // get accessor = used to assign a new value
            // value keyword = defines the value being assigned by the set (parametr)

            Car car = new Car(400);
            car.Speed = 1000000;
            Console.WriteLine(car.Speed);
        }
    }

    class Car
    {
        private int speed;
        public Car(int speed)
        {
            this.Speed = speed;
        }
        public int Speed
        {
            get { return speed; }        // read
            set
            {                            // writable
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    /// <summary>
    /// Car class
    ///A class that describes most cars
    ///It has functions: displaying information,get speed, speeding up, slowing down, stopping a car.
    /// </summary>
    public abstract class Car
    {

        protected string _type;
        protected int _speed;

        /* public Car(string type)
         {
             this.type = type;
             this.speed = 0;
         }*/

        public void PrintSpeed()
        {
            Console.WriteLine($"The Car's speed is: {_speed}");

        }

        public string GetData()
        {
            return $"Type: {_type}, Speed: {_speed} km/h";
        }

        public virtual void IncreaseSpeed(int increasedSpeed = 1)
        {
            _speed += increasedSpeed;
            this.PrintSpeed();
        }

        public void SlowDownSpeed(int slowSpeed = -1)
        {
            _speed = _speed - slowSpeed <= 0 ? 0 : _speed - slowSpeed;
            this.PrintSpeed();

        }

        public void StopCar()
        {

            if (_speed == 0)
            {
                Console.WriteLine("The car is already stopped");
                return;
            }
            _speed = 0;
            Console.WriteLine("The car is now stopped");


        }
    }
}

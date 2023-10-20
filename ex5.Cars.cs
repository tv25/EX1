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
    class Car
    {

        // type- the type of the car
        // Speed - the speed of the car

        protected string type;
        protected int speed;

        //constructor
        public Car(string type)
        {
            this.type = type;
            this.speed = 0;
        }

        //return the car's speed

        public void GetSpeed()
        {
            Console.WriteLine("The Car's speed is: " + speed);
        }

        //return information about the car: type and speed

        public string GetData()
        {
            return $"Type: {type}, Speed: {speed} km/h";
        }

        //Increases car's speed according to the user's request
        //Default: increase by 1 km/h

        public virtual void IncreaseSpeed(int increasedSpeed =1)
        {
            speed += increasedSpeed;
            this.GetSpeed();
        }

        //Lowers the vehicle's speed according to the user's request
        //Default: download at -1 km/h
        //cant be negative speed

        public void SlowDownSpeed(int slowSpeed = -1)
        {
            //check that the speed in not negative
            if (speed - slowSpeed <= 0)
            {
                speed = 0;
            }
            else
            {
                speed -= slowSpeed;
            }
            this.GetSpeed();

        }

        //stop the car,speed is 0 km/h

        public void Stop()
        {
            if (speed == 0)
            {
                Console.WriteLine("The car is alreadt stopped");
            }
            else
            {
                speed = 0;
                Console.WriteLine("The car is stop");

            }
            
           
        }
    }
}

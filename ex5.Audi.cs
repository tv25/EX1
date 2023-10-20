﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    /// <summary>
    /// The "Audi" car class inherits from the car class
    ///Every time the car is accelerated, instead of accelerating by 1 km/h, 
    ///it accelerates by 2 km/h without the driver's knowledge!
    /// </summary>
    class Audi : Car
    {
        //constructor

        public Audi() : base("Audi")
        {
        }

        //Increases the speed of the car by 2 times
        public override void IncreaseSpeed(int increaseSpeed)
        {
            base.IncreaseSpeed(increaseSpeed * 2);
        }
    }
}

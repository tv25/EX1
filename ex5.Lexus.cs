using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    /// <summary>
    /// The "Lexus" car class inherits from the car class
    ///It can also play songs that are in the car's song system.
    /// </summary>
    class Lexus : Car
    {
        private bool isPlayingMusic;

        //constractor
        public Lexus() : base("Lexus")
        {
            isPlayingMusic = false;
        }

        // Start Playing Music in the car
        public void StartPlayingMusic()
        {
            //if the songs is already on 
            if (isPlayingMusic)
            {
                Console.WriteLine("The songs are already on in your car");
            }
            else
            {
                isPlayingMusic = true;
                Console.WriteLine("The songs are currently turned on in your car");
            }
        }

        // Stop Playing Music in the car

        public void StopPlayingMusic()
        {
            //if the songs is already off 
            if (!isPlayingMusic)
            {
                Console.WriteLine("The songs are already off in your car");
            }
            else
            {
                isPlayingMusic = false;
                Console.WriteLine("The songs are currently turned off in your car");
            }


        }
    }
}

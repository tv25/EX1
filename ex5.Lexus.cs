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

        public Lexus()
        {
            _type = "Lexus";
            _speed = 0;
            isPlayingMusic = false;
        }

        public void StartPlayingMusic()
        {
            if (isPlayingMusic)
            {
                Console.WriteLine("The songs are already on in your car");
                return;
            }
            isPlayingMusic = true;
            Console.WriteLine("The songs are currently turned on in your car");

        }


        public void StopPlayingMusic()
        {

            if (!isPlayingMusic)
            {
                Console.WriteLine("The songs are already off in your car");
                return;
            }
            isPlayingMusic = false;
            Console.WriteLine("The songs are currently turned off in your car");



        }
    }
}

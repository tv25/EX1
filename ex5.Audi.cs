using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Audi : Car
    {
        public Audi()
        {
            _speed = 0;
            _type = "Audi";
        }

        public override void IncreaseSpeed(int increaseSpeed)
        {
            base.IncreaseSpeed(increaseSpeed * 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Tire
    {
        int _milage = 0 ;

        public int Milage
        {
            get
            {
                return _milage;
            }
        }

        public void AddMiles(int miles)
        {
            if (miles > 0)
                _milage += miles;
        }
    }
}

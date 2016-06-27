using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle
    {
        Tire[] _tires = new Tire[4];

        public Car(string make) : base(make)
        {
            for(int i = 0; i < _tires.Length; i++)
            {
                Tire newTire = new Tire();
                _tires[i] = newTire;
            }

            ChangeOil();
        }

        #region Member Variables

        #endregion

        #region Properties

        #endregion

        #region Methods

        public override void ChangeOil()
        {
            MilageOfNextOilChange = Milage + 3000;
        }

        public override void AddMilage(int miles)
        {
            Milage += miles;

            for(int i = 0; i < _tires.Length; i++)
            {
                _tires[i].AddMiles(miles);
            }
        }

        public override void ChangeTire(int whichTire)
        {
            if (whichTire <= _tires.Length && whichTire > 0)
            {
                Tire newTire = new Tire();
                _tires[whichTire - 1] = newTire;
            }
        }

        public override bool OilChangeNeeded()
        {
            if (Milage >= MilageOfNextOilChange)
                return true;
            else
                return false;
        }

        #endregion
    }
}

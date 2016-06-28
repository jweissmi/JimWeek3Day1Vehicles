using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Motorcycle : Vehicle
    {
        Tire[] _tires = new Tire[2];

        public Motorcycle(string make) : base(make)
        {
            for (int i = 0; i < _tires.Length; i++)
            {
                Tire newTire = new Tire();
                _tires[i] = newTire;
            }

            ChangeOil();
        }

        public int Miles
        {
            get { return base.Milage; }
        }

        public int OilChangeMilage
        {
            get { return base.MilageOfNextOilChange; }
        }

        public Tire[] Tires
        {
            get { return _tires; }
        }

        #region Member Variables

        #endregion

        #region Properties

        #endregion

        #region Methods

        public override void ChangeOil()
        {
            MilageOfNextOilChange = Milage + 1000;
        }

        public override void AddMilage(int miles)
        {
            Milage += miles;

            for (int i = 0; i < _tires.Length; i++)
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

        public override void ChangeTires()
        {
            for (int i = 0; i < _tires.Length; i++)
            {
                _tires[i] = new Tire();
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

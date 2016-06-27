using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        #region Member Variables

        int _milage;
        int _milageOfNextOilChange;
        string _make;

        #endregion

        public Vehicle(string make)
        {
            _make = make;
        }

        #region Properties

        protected int Milage
        {
            get
            {
                return _milage;
            }
            set
            {
                _milage = value;
            }
        }

        protected int MilageOfNextOilChange
        {
            get
            {
                return _milageOfNextOilChange;
            }
            set
            {
                _milageOfNextOilChange = value;
            }
        }

        public string Make
        {
            get
            {
                return _make;
            }
        }

        #endregion

        #region Methods

        public abstract void ChangeOil();
        public abstract void AddMilage(int miles);
        public abstract void ChangeTire(int whichTire);
        public abstract bool OilChangeNeeded();

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        Tire[] _tires = new Tire[18];

        public Truck(string make) : base(make)
        {

        }

        #region Member Variables

        #endregion

        #region Properties

        #endregion

        #region Methods

        public override bool ChangeOil()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

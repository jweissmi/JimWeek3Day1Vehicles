using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle myMoto = new Motorcycle("MotoGuzi");
            myMoto.AddMilage(2000);
            bool test = myMoto.OilChangeNeeded();
            myMoto.AddMilage(1000);
            myMoto.ChangeOil();
            myMoto.ChangeTire(1);

            Motorcycle myHog = new Motorcycle("FatBoy");
            myHog.AddMilage(3000);
            bool testHog = myHog.OilChangeNeeded();
            myHog.AddMilage(1000);
            myHog.ChangeOil();
            myHog.ChangeTires();

            Car myCar = new Car("Pontiac GTO");
            bool needOil = myCar.OilChangeNeeded();
            myCar.AddMilage(5000);
            bool needOil2 = myCar.OilChangeNeeded();
            myCar.ChangeOil();
            myCar.AddMilage(5000);
            myCar.ChangeTire(4);

        }
    }
}

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

            Car mySmallCar = new Car("Chevy Cruze");
            mySmallCar.AddMilage(7000);
            bool needOil3 = mySmallCar.OilChangeNeeded();
            mySmallCar.AddMilage(1000);
            mySmallCar.ChangeOil();
            mySmallCar.ChangeTires();

            Truck myFreightliner = new Truck("Cascadia");
            myFreightliner.AddMilage(11000);
            bool needOil4 = myFreightliner.OilChangeNeeded();
            myFreightliner.ChangeOil();
            myFreightliner.AddMilage(15000);
            myFreightliner.ChangeTire(17);

            Truck myInternational = new Truck("ProStar");
            myInternational.AddMilage(11000);
            bool needOil5 = myInternational.OilChangeNeeded();
            myInternational.ChangeOil();
            myInternational.AddMilage(15000);
            myInternational.ChangeOil();
            bool needOil6 = myInternational.OilChangeNeeded();
            myInternational.ChangeTires();
        }
    }
}

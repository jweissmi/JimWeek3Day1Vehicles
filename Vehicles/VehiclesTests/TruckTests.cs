using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Tests
{
    [TestClass()]
    public class TruckTests
    {
        [TestMethod()]
        public void TruckTest()
        {
            Truck testTruck = new Truck("testMake");
            Assert.IsNotNull(testTruck.Make);
            Assert.IsInstanceOfType(testTruck, typeof(Truck));
            Assert.AreEqual(18, testTruck.Tires.Length);
            for (int i = 0; i < testTruck.Tires.Length; i++)
            {
                Assert.AreEqual(0, testTruck.Tires[i].Milage);
            }
            Assert.AreEqual(0, testTruck.Miles);
            Assert.AreEqual("testMake", testTruck.Make);
            Assert.AreEqual(10000, testTruck.OilChangeMilage);
        }

        [TestMethod()]
        public void ChangeOilTest()
        {
            Truck testTruck = new Truck("testMake");
            Assert.AreEqual(10000, testTruck.OilChangeMilage);
            testTruck.AddMilage(30000);
            testTruck.ChangeOil();
            Assert.AreEqual(40000, testTruck.OilChangeMilage);
        }

        [TestMethod()]
        public void AddMilageTest()
        {
            Truck testTruck = new Truck("testMake");
            Assert.AreEqual(0, testTruck.Miles);
            testTruck.AddMilage(1000);
            Assert.AreEqual(1000, testTruck.Miles);
        }

        [TestMethod()]
        public void ChangeTireTest()
        {
            Truck testTruck = new Truck("testMake");
            Assert.AreEqual(0, testTruck.Tires[0].Milage);
            testTruck.AddMilage(1000);
            Assert.AreEqual(1000, testTruck.Tires[0].Milage);

            testTruck.ChangeTire(1);
            Assert.AreEqual(0, testTruck.Tires[0].Milage);

            testTruck.ChangeTire(2);
            Assert.AreEqual(0, testTruck.Tires[1].Milage);

            testTruck.ChangeTire(3);
            Assert.AreEqual(0, testTruck.Tires[2].Milage);

            testTruck.ChangeTire(4);
            Assert.AreEqual(0, testTruck.Tires[3].Milage);

            testTruck.ChangeTire(5);
            Assert.AreEqual(0, testTruck.Tires[4].Milage);

            testTruck.ChangeTire(6);
            Assert.AreEqual(0, testTruck.Tires[5].Milage);

            testTruck.ChangeTire(7);
            Assert.AreEqual(0, testTruck.Tires[6].Milage);

            testTruck.ChangeTire(8);
            Assert.AreEqual(0, testTruck.Tires[7].Milage);

            testTruck.ChangeTire(9);
            Assert.AreEqual(0, testTruck.Tires[8].Milage);

            testTruck.ChangeTire(10);
            Assert.AreEqual(0, testTruck.Tires[9].Milage);

            testTruck.ChangeTire(11);
            Assert.AreEqual(0, testTruck.Tires[10].Milage);

            testTruck.ChangeTire(12);
            Assert.AreEqual(0, testTruck.Tires[11].Milage);

            testTruck.ChangeTire(13);
            Assert.AreEqual(0, testTruck.Tires[12].Milage);

            testTruck.ChangeTire(14);
            Assert.AreEqual(0, testTruck.Tires[13].Milage);

            testTruck.ChangeTire(15);
            Assert.AreEqual(0, testTruck.Tires[14].Milage);

            testTruck.ChangeTire(16);
            Assert.AreEqual(0, testTruck.Tires[15].Milage);

            testTruck.ChangeTire(17);
            Assert.AreEqual(0, testTruck.Tires[16].Milage);

            testTruck.ChangeTire(18);
            Assert.AreEqual(0, testTruck.Tires[17].Milage);
        }

        [TestMethod()]
        public void ChangeTiresTest()
        {
            Truck testTruck = new Truck("testMake");
            testTruck.AddMilage(5000);
            testTruck.ChangeTires();

            for (int i = 0; i < 18; i++)
            {
                Assert.AreEqual(0, testTruck.Tires[i].Milage);
            }
        }

        [TestMethod()]
        public void OilChangeNeededTest()
        {
            Truck testTruck = new Truck("testMake");
            Assert.IsFalse(testTruck.OilChangeNeeded());
            testTruck.AddMilage(15000);
            Assert.IsTrue(testTruck.OilChangeNeeded());
        }
    }
}
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
    public class MotorcycleTests
    {
        [TestMethod()]
        public void MotorcycleTest()
        {
            Motorcycle testMotorcycle = new Motorcycle("testMake");
            Assert.IsNotNull(testMotorcycle.Make); Assert.IsInstanceOfType(testMotorcycle, typeof(Motorcycle));
            Assert.AreEqual(2, testMotorcycle.Tires.Length);
            for (int i = 0; i < testMotorcycle.Tires.Length; i++)
            {
                Assert.AreEqual(0, testMotorcycle.Tires[i].Milage);
            }
            Assert.AreEqual(0, testMotorcycle.Miles);
            Assert.AreEqual("testMake", testMotorcycle.Make);
            Assert.AreEqual(1000, testMotorcycle.OilChangeMilage);
        }


        [TestMethod()]
        public void ChangeOilTest()
        {
            Motorcycle testMotorcycle = new Motorcycle("testMake");
            testMotorcycle.AddMilage(3000);
            testMotorcycle.ChangeOil();
            Assert.AreEqual(4000, testMotorcycle.OilChangeMilage);
        }

        [TestMethod()]
        public void AddMilageTest()
        {
            Motorcycle testMotorcycle = new Motorcycle("testMake");
            Assert.AreEqual(0, testMotorcycle.Miles);
            testMotorcycle.AddMilage(1000);
            Assert.AreEqual(1000, testMotorcycle.Miles);
        }

        [TestMethod()]
        public void ChangeTireTest()
        {
            Motorcycle testMotorcycle = new Motorcycle("testMake");
            Assert.AreEqual(0, testMotorcycle.Tires[0].Milage);
            testMotorcycle.AddMilage(1000);
            Assert.AreEqual(1000, testMotorcycle.Tires[0].Milage);

            testMotorcycle.ChangeTire(1);
            Assert.AreEqual(0, testMotorcycle.Tires[0].Milage);

            testMotorcycle.ChangeTire(2);
            Assert.AreEqual(0, testMotorcycle.Tires[1].Milage);
        }

        [TestMethod()]
        public void ChangeTiresTest()
        {
            Motorcycle testMotorcycle = new Motorcycle("testMake");
            testMotorcycle.ChangeTires();

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(0, testMotorcycle.Tires[i].Milage);
            }
        }

        [TestMethod()]
        public void OilChangeNeededTest()
        {
            Motorcycle testMotorcycle = new Motorcycle("testMake");
            Assert.IsFalse(testMotorcycle.OilChangeNeeded());
            testMotorcycle.AddMilage(5000);
            Assert.IsTrue(testMotorcycle.OilChangeNeeded());
        }
    }
}
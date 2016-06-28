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
    public class CarTests
    {
        [TestMethod()]
        public void CarTest()
        {
            Car testCar = new Car("testMake");
            Assert.IsNotNull(testCar.Make);
            Assert.IsInstanceOfType(testCar, typeof(Car));
            Assert.AreEqual(4, testCar.Tires.Length);
            for (int i = 0; i < testCar.Tires.Length; i++)
            {
                Assert.AreEqual(0, testCar.Tires[i].Milage);
            }
            Assert.AreEqual(0, testCar.Miles);
            Assert.AreEqual("testMake", testCar.Make);
            Assert.AreEqual(3000, testCar.OilChangeMilage);
        }

        [TestMethod()]
        public void ChangeOilTest()
        {
            Car testCar = new Car("testMake");
            Assert.AreEqual(3000, testCar.OilChangeMilage);
            testCar.AddMilage(3000);
            testCar.ChangeOil();
            Assert.AreEqual(6000, testCar.OilChangeMilage);
        }

        [TestMethod()]
        public void AddMilageTest()
        {
            Car testCar = new Car("testMake");
            Assert.AreEqual(0, testCar.Miles);
            testCar.AddMilage(1000);
            Assert.AreEqual(1000, testCar.Miles);
        }

        [TestMethod()]
        public void ChangeTireTest()
        {
            Car testCar = new Car("testMake");
            Assert.AreEqual(0, testCar.Tires[0].Milage);
            testCar.AddMilage(1000);
            Assert.AreEqual(1000, testCar.Tires[0].Milage);

            testCar.ChangeTire(1);
            Assert.AreEqual(0, testCar.Tires[0].Milage);

            testCar.ChangeTire(2);
            Assert.AreEqual(0, testCar.Tires[1].Milage);

            testCar.ChangeTire(3);
            Assert.AreEqual(0, testCar.Tires[2].Milage);

            testCar.ChangeTire(4);
            Assert.AreEqual(0, testCar.Tires[3].Milage);
        }

        [TestMethod()]
        public void ChangeTiresTest()
        {
            Car testCar = new Car("testMake");
            testCar.AddMilage(5000);
            testCar.ChangeTires();

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(0, testCar.Tires[i].Milage);
            }
        }

        [TestMethod()]
        public void OilChangeNeededTest()
        {
            Car testCar = new Car("testMake");
            Assert.IsFalse(testCar.OilChangeNeeded());
            testCar.AddMilage(5000);
            Assert.IsTrue(testCar.OilChangeNeeded());
        }
    }
}
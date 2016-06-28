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
            Assert.IsNotNull(testMotorcycle.Make);
        }

        [TestMethod()]
        public void ChangeOilTest()
        {
            
        }

        [TestMethod()]
        public void AddMilageTest()
        {
            
        }

        [TestMethod()]
        public void ChangeTireTest()
        {
            
        }

        [TestMethod()]
        public void ChangeTiresTest()
        {
            
        }

        [TestMethod()]
        public void OilChangeNeededTest()
        {
            
        }
    }
}
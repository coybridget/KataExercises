using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataExercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataExercises.Tests
{
    [TestClass()]
    public class DriverLicenseTests
    {
        [TestMethod()]
        public void GetDriversLicenseTestFalse()
        {
            //arrange
            DriverLicense driverLicense = new DriverLicense();

            //act
            bool result = driverLicense.GetDriversLicense(16, 20, false, true);//false

            bool result1 = driverLicense.GetDriversLicense(16, 50, false, false);//false

            Assert.AreEqual(false, result);
            Assert.AreEqual(false, result1);

        }

        [TestMethod()]
        public void GetDriversLicenseTestTrue()
        {
            //arrange
            DriverLicense driverLicense = new DriverLicense();

            bool result2 = driverLicense.GetDriversLicense(16, 50, true, true);//true

            bool result3 = driverLicense.GetDriversLicense(18, 0, true, true);//true

            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);

        }
    }
}
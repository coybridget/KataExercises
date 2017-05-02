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
    public class PopulationGrowthTests
    {
        [TestMethod()]
        public void NbYearTest()
        {
            //Arrange
            //PopulationGrowth.NbYear( pg = new PopulationGrowth();
            //Act
            //int y = popGrowth.NbYear(1500, 5, 100, 5000);
            //Assert
            Assert.AreEqual(15, PopulationGrowth.NbYear(1500, 5, 100, 5000));
            Assert.AreEqual(10, PopulationGrowth.NbYear(1500000, 2.5, 10000, 2000000));
        }
    }
}
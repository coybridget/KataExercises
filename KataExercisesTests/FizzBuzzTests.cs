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
    public class FizzBuzzTests
    {
        [TestMethod()]
        public void GetFizzBuzzTest()
        {
            //arrange
            FizzBuzz fb = new FizzBuzz();

            //act
            string result = fb.GetFizzBuzz(3);

            //assert
            Assert.AreEqual("fizz", result);
        }
    }
}
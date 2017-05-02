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
    public class TwoToOneTests
    {
        [TestMethod()]
        public void LongestTest()
        {
            //arrage
            string s1 = "xyaabbbccccdefww";
            string s2 = "xxxxyyyyabklmopq";

            //act
            TwoToOne.Longest(s1, s2);

            //assert
            Assert.AreEqual("abcdefklmopqwxy", TwoToOne.Longest(s1, s2));
        }
    }
}
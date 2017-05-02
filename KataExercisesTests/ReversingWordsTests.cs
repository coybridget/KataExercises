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
    public class ReversingWordsTests
    {
        [TestMethod()]
        public void reverseWordsTestHelloWorld()
        {

            //Arrange
            ReversingWords r = new ReversingWords();

            //Act
            string result = r.reverseWords("Hello World");

            //Assert
            Assert.AreEqual("World Hello", result);
        }

        [TestMethod()]
        public void reverseWordsTest()
        {

            //Arrange
            ReversingWords r = new ReversingWords();

            //Act
            string result = r.reverseWords("This is my name");

            //Assert
            Assert.AreEqual("name my is This", result);
        }
    }
}

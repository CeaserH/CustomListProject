using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomListTest
{
    [TestClass]
    class AddTests
    {
        [TestMethod]

        public void AddOne()
        {

            int NumOne = 1;
            int NumTwo = 5;

            CustomList<int> numbers = new CustomList<int>();
            int sum = numbers.Add(NumOne, NumTwo);

            Assert.AreEqual(6, sum);

        }


    }
}

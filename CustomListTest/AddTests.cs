using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomListTest
{
    [TestClass]
    class AddTests
    {
        [TestMethod]

        public void AddOneItemToList()
        {

            CustomList<int> numbers = new CustomList<int>();

            int ListCount = numbers.Count;

            numbers.Add(1);

            int sum = numbers.Count;

            Assert.AreEqual(ListCount + 1, sum);

        }

        public void AddFiveItemsToList()
        {

            CustomList<int> numbers = new CustomList<int>();

            int ListCount = numbers.Count;


            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);


            int sum = numbers.Count;

            Assert.AreEqual(ListCount + 5, sum);

        }


    }
}

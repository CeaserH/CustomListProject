using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomListTest
{
    [TestClass]
    class AddTests
    {
        [TestMethod]


        // Checking to see if list count is accurately increase by 1
        public void AddOneIntToList()
        {

            CustomList<int> numbers = new CustomList<int>();

            int ListCount = numbers.count;

            numbers.Add(1);

            int sum = numbers.count;

            Assert.AreEqual(ListCount + 1, sum);

        }

        // Checking to see if list count is accurately increased by 5

        public void AddFiveIntsToList()
        {

            CustomList<int> numbers = new CustomList<int>();

            int ListCount = numbers.count;


            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);


            int sum = numbers.count;

            Assert.AreEqual(ListCount + 5, sum);

        }


        // Checking to see if capacity increases from 4 once reached, should increase to 8
        public void AddThreeStringsToList()
        {

            CustomList<string> stringTest = new CustomList<string>();

            stringTest.Add("Lets");
            stringTest.Add("test");

            int listCap = stringTest.capacity;

            stringTest.Add("this");
            stringTest.Add("And see");
            stringTest.Add("if it works.");

            int newListCap = stringTest.capacity;

            Assert.AreEqual(listCap + 3, newListCap);


        }

        // Checking to see if the correct string on index 0

        public void IsStringInIndexZeroRight()
        {

            CustomList<string> stringTest = new CustomList<string>();


            string testingIndex = stringTest.Add("Hello");

            Assert.AreEqual("Hello", testingIndex);


        }


        // Checking to see if correct string on index provided

        public void IsStringInIndexRight()
        {

            CustomList<string> stringTest = new CustomList<string>();

            stringTest.Add("Hello,");
            stringTest.Add("My name is,");
            stringTest.Add("Ceaser");

            var actual = stringTest[2];

            Assert.AreEqual("Ceaser", actual);


        }




    }
}

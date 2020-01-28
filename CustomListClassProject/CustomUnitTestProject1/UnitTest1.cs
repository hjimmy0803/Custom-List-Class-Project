using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;


namespace CustomUnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddItemToEmptyList_ItemGoesToIndexZero()
        {
            //Arange
            CustomList<int> testList = new CustomList<int>();
            int value = 4;
            int expected = 4;
            int actual;

            //Act
            testList.Add(value);
            actual = testList[0];


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToEmptyList_CountIncrements() 
        {

            //Arrange
            CustomList<string> testList = new CustomList<string>();
            int expected = 1;
            int actual;

            //Act
            testList.Add("Bold");
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_AddItemToListWithItemsAlreadyInIt_NewItemGoesTOLastIndex() 
        {

            //Arrange
            CustomList<bool> testList = new CustomList<bool>();
            bool expected = true;
            bool actual;

            testList.Add(false);
            testList.Add(true);
            testList.Add(false);
            testList.Add(false);
            testList.Add(true);

            //Act
            testList.Add(true);
            actual = testList[4];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddMultipleItemsToList_CheckItemCount() 
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);

            //Act
            testList.Add(4);
            actual = testList.count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemsToExceedList_CheckToSeeIfCapacityIncreases() 
        {

            //Arrange
            CustomList<string> testList = new CustomList<string>();
            int expected = 8;
            int actual;

            testList.Add("Eagles");
            testList.Add("Packers");
            testList.Add("Bears");
            testList.Add("Vikings");

            //Act
            testList.Add("Cowboys");
            actual = testList.capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemFromList_RemoveItemFromIndexThree()
        {

            //Arrange 
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);

            //Act
            testList.Remove(1);
            actual = testList[2];

            //Assert
            Assert.AreEqual(expected, actual);

        }
        public void Remove_RemoveItemFromList_CountIncrements()
        {

            //Arrange 
            CustomList<string> testList = new CustomList<string>();
            int expected = 1;
            int actual;

            testList.Add("Time");
            testList.Add("Bold");

            //Act
            testList.Remove("Bold");
            actual = testList.count;

            //Asseert
            Assert.AreEqual(expected, actual);
        }
        public void Remove_RemoveItemThatDoesNotExistInList_CountShouldNotChange()
        {

            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);

            //Act
            testList.Remove(8);
            actual = testList.count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Remove_RemoveItem
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListsDataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsDataStructure.Tests
{
    [TestClass()]
    public class MyArrayListTests
    {
        [TestMethod()]
        public void Append_AddSingleElement_ShouldAddToEnd()
        {
            //Arrange
            MyArrayList<int> list = new MyArrayList<int>();
            // Act
            list.Append(4);
            // Assert
            Assert.AreEqual(list.List[0], 4);
        }

        [TestMethod()]
        public void Append_AddMultipleElements_ShouldAddToEnd()
        {
            //Arrange
            MyArrayList<int> list = new MyArrayList<int>();
            // Act
            list.Append(4);
            list.Append(3);

            // Assert
            Assert.AreEqual(list.List[0], 4);
            Assert.AreEqual(list.List[1], 3);
        }

        [TestMethod()]
        public void Append_AddMoreElementsThan_ShouldAddToEnd()
        {
            //Arrange
            MyArrayList<int> list = new MyArrayList<int>();
            // Act
            list.Append(4);
            list.Append(5);
            list.Append(4);
            list.Append(5);
            list.Append(4);
            list.Append(5);
            list.Append(4);
            list.Append(5);
            list.Append(4);
            list.Append(5);
            list.Append(42);
            // Assert
            Assert.AreEqual(list.List[0], 4);
            Assert.AreEqual(list.List[list.Size - 1], 42);

        }
        [TestMethod()]
        public void AddStart_ListIsEmpty_ShouldAddToStart()
        {
            //Arrange
            MyArrayList<int> list = new MyArrayList<int>();
            // Act
            list.AddStart(4);
            // Assert
            Assert.AreEqual(list.List[0], 4);
        }

        [TestMethod()]
        public void AddStart_ListHasValues_ShouldAddToStart()
        {
            //Arrange
            MyArrayList<int> list = new MyArrayList<int>();
            list.Append(5);
            list.Append(4);
            // Act
            list.AddStart(10);
            // Assert
            Assert.AreEqual(5, list.List[1]);
            Assert.AreEqual(10, list.List[0]);
        }

        [TestMethod()]
        public void Insert_ListIsEmpty_ShouldAddToStart()
        {
            //Arrange
            MyArrayList<int> list = new MyArrayList<int>();
            // Act
            list.Insert(5, 0);

            // Assert
            Assert.AreEqual(5, list.List[0]);
        }

        [TestMethod()]
        public void Insert_ListIsEmptyIndexIsInvalid_ShouldThrowException()
        {
            //Arrange
            MyArrayList<int> list = new MyArrayList<int>();
            // Act

            // Assert
            Assert.ThrowsException<IndexOutOfRangeException>(() =>
            list.Insert(5, 2), "Index is invalid");
        }

        [TestMethod()]
        public void Insert_HasValues_ShouldInsertAtCorrectPosition()
        {
            //Arrange
            MyArrayList<int> list = new MyArrayList<int>();
            list.Append(4);
            list.Append(5);
            list.Append(7);
            // Act
            list.Insert(8, 1);
            // Assert
            Assert.AreEqual(4, list.List[0]);
            Assert.AreEqual(5, list.List[2]);
            Assert.AreEqual(8, list.List[1]);
        }

        [TestMethod()]
        public void DeleteStart_ListHasValues_ShouldDeleteFirstElement()
        {
            //Arrange
            MyArrayList<int> list = new MyArrayList<int>();
            list.Append(4);
            list.Append(5);
            list.Append(7);
            // Act
            list.DeleteStart();
            // Assert
            Assert.AreEqual(5, list.List[0]);
            Assert.AreEqual(7, list.List[1]);
            Assert.AreEqual(0, list.List[2]);
            Assert.IsTrue(list.Size == 2);
        }

        [TestMethod()]
        public void DeleteStart_ListIsFull_ShouldDeleteFirstElement()
        {
            //Arrange
            MyArrayList<int> list = new MyArrayList<int>(3);
            list.Append(4);
            list.Append(5);
            list.Append(7);
            // Act
            list.DeleteStart();
            // Assert
            Assert.AreEqual(5, list.List[0]);
            Assert.AreEqual(7, list.List[1]);
            Assert.AreEqual(0, list.List[2]);
            Assert.IsTrue(list.Size == 2);
        }

        [TestMethod()]
        public void DeleteEnd_ListHasValues_ShouldDeleteFromEnd()
        {
            //Arrange
            MyArrayList<int> list = new MyArrayList<int>();
            list.Append(4);
            list.Append(5);
            list.Append(7);
            // Act
            list.DeleteEnd();
            // Assert
            Assert.IsTrue(list.Size == 2);
            Assert.AreEqual(4, list.List[0]);
            Assert.AreEqual(5, list.List[1]);
            Assert.AreEqual(0, list.List[2]);
        }

        [TestMethod()]
        public void DeleteStart_ListHasStringValues_ShouldDeleteFirstElement()
        {
            //Arrange
            MyArrayList<string> list = new MyArrayList<string>();
            list.Append("Hello"); 
            list.Append("World");
            list.Append("Howdy");

            //Act
            list.DeleteStart();

            //Assert
            Assert.IsTrue(list.Size == 2);
            Assert.AreEqual("World", list.List[0]);
            Assert.AreEqual("Howdy", list.List[1]);
        }
    }
}
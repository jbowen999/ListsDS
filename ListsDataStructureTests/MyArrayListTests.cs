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
            MyArrayList list = new MyArrayList();
            // Act
            list.Append(4);
            // Assert
            Assert.AreEqual(list.List[0], 4);
        }

        [TestMethod()]
        public void Append_AddMultipleElements_ShouldAddToEnd()
        {
            //Arrange
            MyArrayList list = new MyArrayList();
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
            MyArrayList list = new MyArrayList();
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
            MyArrayList list = new MyArrayList();
            // Act
            list.AddStart(4);
            // Assert
            Assert.AreEqual(list.List[0], 4);
        }

        [TestMethod()]
        public void AddStart_ListHasValues_ShouldAddToStart()
        {
            //Arrange
            MyArrayList list = new MyArrayList();
            list.Append(5);
            list.Append(4);
            // Act
            list.AddStart(10);
            // Assert
            Assert.AreEqual(list.List[0], 10);
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearchTree;
namespace BinarySearchTreeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Number_Check_Count()
        {
            // arrange
            Node node = new Node();
            int expected = 10;
            int actual;

            // act
            node.Add(10);
            actual = node.data;

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Search_Number_Check_Count()
        {
            // assert


            // act 


            //assert


        }
    }
}

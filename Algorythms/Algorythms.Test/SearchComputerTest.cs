using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Algorythms.Test
{
    [TestClass]
    public class SearchComputerTest : BaseTestClass
    {
        #region Properties
        #endregion

        #region Constructor

        public SearchComputerTest()
        {
            this._searchComputer = new SearchComputer();
        }

        #endregion


        #region Private Methods




        #endregion


        #region Test Methods

        #region Linear Search

        [TestMethod]
        public void LinearSearchOrdinaryTest()
        {
            // Arrange
            var entryArray = this.Init(10);
            var searchValue = 7;

            // Act
            var result = _searchComputer.LinearSearch(entryArray, searchValue);

            // Assert
            Assert.AreEqual(result, 7);
            Assert.AreEqual(entryArray[result], searchValue);
        }

        [TestMethod]
        public void LinearSearchBiggerOrdinaryTest()
        {
            // Arrange
            var searchValue = 77;
            var entryArray = this.InitWithRange(10000, searchValue, 10);

            // Act
            var result = _searchComputer.LinearSearch(entryArray, searchValue);

            // Assert
            //Assert.AreEqual(result, 7);
            Assert.AreEqual(entryArray[result], searchValue);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void LinearSearchNoTargetValueTest()
        {
            // Arrange
            var entryArray = this.Init(10);
            var searchValue = 11;

            // Act
            var result = _searchComputer.LinearSearch(entryArray, searchValue);

            // Assert
            // exception expected
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void LinearSearchEmptyArrayTest()
        {
            // Arrange
            var entryArray = new int[0];
            var searchValue = 11;

            // Act
            var result = _searchComputer.LinearSearch(entryArray, searchValue);

            // Assert
        }

        //[TestMethod]
        //public void LinearSearchNegativeNumsTest()
        //{
        //    // Arrange
        //    var entryArray = this.Init(10, -4);
        //    var searchValue = 0;

        //    // Act
        //    var result = _searchComputer.LinearSearch(entryArray, searchValue);

        //    // Assert
        //    Assert.AreEqual(result, 4);
        //    Assert.AreEqual(entryArray[result], searchValue);
        //}

        #endregion

        #region Binary Search Test

        [TestMethod]
        public void BinarySearchOrdinaryTest()
        {
            // Arrange
            var entryArray = this.Init(10);
            var searchValue = 7;

            // Act
            var result = _searchComputer.BinarySearch(entryArray, searchValue);

            // Assert
            Assert.AreEqual(result, 7);
            Assert.AreEqual(entryArray[result], searchValue);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void BinarySearchEmptyArrayTest()
        {
            // Arrange
            var entryArray = this.Init(10);
            var searchValue = -1;

            // Act
            var result = _searchComputer.BinarySearch(entryArray, searchValue);

            // Assert
            // exception expected
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void BinarySearchNoTargetValueTest()
        {
            // Arrange
            var entryArray = this.Init(10);
            var searchValue = 11;

            // Act
            var result = _searchComputer.BinarySearch(entryArray, searchValue);

            // Assert
            // exception expected
        }

        #endregion

        //#region Sentinel Linear Search

        //[TestMethod]
        //public void SentinelLinearSearchOrdinaryTest()
        //{
        //    // Arrange
        //    var entryArray = this.Init(10);
        //    var searchValue = 7;

        //    // Act
        //    var result = _searchComputer.SentinelLinearSearch(entryArray, searchValue);

        //    // Assert
        //    Assert.AreEqual(result, 7);
        //    Assert.AreEqual(entryArray[result], searchValue);
        //}

        //[TestMethod]
        //public void SentinelLinearSearchBiggerOrdinaryTest()
        //{
        //    // Arrange
        //    var searchValue = 77;
        //    var entryArray = this.InitWithRange(100000, searchValue, 77);

        //    // Act
        //    var result = _searchComputer.SentinelLinearSearch(entryArray, searchValue);

        //    // Assert
        //    //Assert.AreEqual(result, 7);
        //    Assert.AreEqual(entryArray[result], searchValue);
        //}

        //[TestMethod]
        //public void SentinelLinearSearchNoTargetValueTest()
        //{
        //    var entryArray = this.Init(10);
        //    var searchValue = 11;

        //    // Act
        //    var result = _searchComputer.SentinelLinearSearch(entryArray, searchValue);

        //    // Assert
        //    Assert.AreEqual(result, -1);
        //    Assert.IsFalse(Array.Exists<int>(entryArray, x => x == searchValue));
        //}

        //[TestMethod]
        //public void SentinelLinearSearchEmptyArrayTest()
        //{
        //    // Arrange
        //    var entryArray = new int[0];
        //    var searchValue = 11;

        //    // Act
        //    var result = _searchComputer.SentinelLinearSearch(entryArray, searchValue);

        //    // Assert
        //    Assert.AreEqual(result, -1);
        //    Assert.IsFalse(Array.Exists<int>(entryArray, x => x == searchValue));
        //}

        //[TestMethod]
        //public void SentinelLinearSearchNegativeNumsTest()
        //{
        //    // Arrange
        //    var entryArray = this.Init(10, -4);
        //    var searchValue = 0;

        //    // Act
        //    var result = _searchComputer.SentinelLinearSearch(entryArray, searchValue);

        //    // Assert
        //    Assert.AreEqual(result, 0);
        //    Assert.AreEqual(entryArray[result], searchValue);
        //}

        //#endregion

        #endregion

    }
}

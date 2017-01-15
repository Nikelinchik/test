using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorythms.Test
{
    [TestClass]
    public class SearchTest
    {
        #region Properties

        private Search _search = new Search();

        #endregion

        #region Private Methods

        private int[] Init(int count, int? valueFrom = null)
        {
            var result = new int[count];

            if (!valueFrom.HasValue)
            {
                for (int i = 0; i < count; i++)
                {
                    result[i] = i;
                }
            }
            else
            {
                var value = valueFrom.Value;
                for (int i = 0; i < count; i++)
                {
                    result[i] = value;
                    value++;
                }
            }
            return result;
        }

        #endregion


        #region Test Methods


        [TestMethod]
        public void LinearSearchOrdinaryTest()
        {
            // Arrange
            var entryArray = this.Init(10);
            var searchValue = 7;

            // Act
            var result = _search.LinearSearch(entryArray, searchValue);

            // Assert
            Assert.AreEqual(result, searchValue);
            Assert.AreEqual(result, entryArray[7]);
        }

        [TestMethod]
        public void LinearSearchDefaultValueTest()
        {
            // Arrange
            var entryArray = this.Init(10);
            var searchValue = -1;

            // Act
            var result = _search.LinearSearch(entryArray, searchValue);

            // Assert
            Assert.AreEqual(result, searchValue);
            Assert.IsFalse(Array.Exists<int>(entryArray, x => x == result));
        }

        [TestMethod]
        public void LinearSearchNoTargetValueTest()
        {
            // Arrange
            var entryArray = this.Init(10);
            var searchValue = 11;

            // Act
            var result = _search.LinearSearch(entryArray, searchValue);

            // Assert
            Assert.AreNotEqual(result, searchValue);
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void LinearSearchEmptyArrayTest()
        {
            // Arrange
            var entryArray = new int[0];
            var searchValue = 11;

            // Act
            var result = _search.LinearSearch(entryArray, searchValue);

            // Assert
            Assert.AreNotEqual(result, searchValue);
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void LinearSearchNegativeNumsTest()
        {
            // Arrange
            var entryArray = this.Init(10, -4);
            var searchValue = 0;

            // Act
            var result = _search.LinearSearch(entryArray, searchValue);

            // Assert
            Assert.AreEqual(result, searchValue);
            Assert.AreEqual(result, entryArray[4]);
        }

        #endregion;

    }
}

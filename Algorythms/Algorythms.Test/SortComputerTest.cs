using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms.Test
{
    //class SortComputerTest
    //{
    //}

    [TestClass]
    public class SortComputerTest : BaseTestClass
    {
        #region Properties       

        #endregion

        #region Constructor

        public SortComputerTest()
        {
            this._sortComputer = new SortComputer();
        }

        #endregion

        #region Private Methods

        #endregion


        #region Test Methods

        [TestMethod]
        public void SelectionSortTest()
        {
            // arrange 
            var entryArray = new int[20]
            { 1, 54, 52, 687, 96, 2, 7, 9, 0, 4, 2, 1, 2, 5, 87, 3, 76, 33, 21, 26 };

            // act
            var sortedArray = this._sortComputer.SelectionSort(entryArray);

            // assert
            Assert.AreEqual(sortedArray.First(), sortedArray.Min());
            Assert.AreEqual(sortedArray.Last(), sortedArray.Max());

            Assert.AreEqual(sortedArray.Last(), 687);
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            // arrange 
            var entryArray = new int[20]
            { 1, 54, 52, 687, 96, 2, 7, 9, 0, 4, 2, 1, 2, 5, 87, 3, 76, 33, 21, 26 };

            // act
            var sortedArray = this._sortComputer.InsertionSort(entryArray);

            // assert
            Assert.AreEqual(sortedArray.First(), sortedArray.Min());
            Assert.AreEqual(sortedArray.Last(), sortedArray.Max());

            Assert.AreEqual(sortedArray.Last(), 687);
        }

    }
    #endregion
}


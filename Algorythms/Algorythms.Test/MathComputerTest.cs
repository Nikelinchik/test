using Algorythms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms.Test
{
    [TestClass]
    public class MathComputerTest : BaseTestClass
    {
        #region Properties       

        #endregion

        #region Constructor

        public MathComputerTest()
        {
            this._mathComputer = new MathComputer();
        }

        #endregion

        #region Private Methods

        #endregion


        #region Test Methods

        [TestMethod]
        public void FactorialTest()
        {
            var N = 6;
            var result = _mathComputer.Factorial(N);

            Assert.AreEqual(result, 720);

        }
        #endregion
    }
}

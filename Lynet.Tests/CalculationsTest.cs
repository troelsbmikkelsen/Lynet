using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lynet;

namespace Lynet.Tests {
    [TestClass]
    public class CalculationsTest {
        [TestMethod]
        public void TestCalcPace() {
            // Expected results are taken from this calculator: http://www.coolrunning.com/engine/4/4_1/96.shtml
            Assert.AreEqual(new DateTime(1, 1, 1, 0, 5, 0), Calculations.CalcPace(10, 0, 50));
        }
    }
}

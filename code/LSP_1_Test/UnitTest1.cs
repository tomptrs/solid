using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LSP_1;

namespace LSP_1_Test
{
    [TestClass]
    public class TestLSP_1
    {
        [TestMethod]
        public void ZesTwoXThreeRectangle()
        {
            var mRect = new Rechthoek() { Width = 2, Height = 3 };

            Assert.AreEqual(6, AreaCalculator.CalculateObject(mRect));
        }

        [TestMethod]
        public void VierTwoXTwoVierkant()
        {
            var mVierk = new Vierkant() { Width = 2, Height = 2 };

            Assert.AreEqual(4, AreaCalculator.CalculateObject(mVierk));
        }

        [TestMethod]
        public void TwentyForFourXFiveRechthoekVanVierkant()
        {
            Rechthoek mVierk = new Vierkant() { Width = 2, Height = 3 };

            Assert.AreEqual(6, AreaCalculator.CalculateObject(mVierk));
        }
    }
}

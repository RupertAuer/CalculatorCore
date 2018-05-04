using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests

{
    [TestClass]
    public class CalculatorOPTest
    {
        [TestMethod]
        public void ShouldAddReturnNineWhenPassFiveandFour()
        {
            CalculatorOP sut = new CalculatorOP();

            int result = sut.Add(5, 4);

            Assert.AreEqual(9, result);
        }

        [TestMethod]

        public void ShoulMulReturnTwentyWhenPassFiveandFour()
        {
            CalculatorOP sut = new CalculatorOP();

            int result = sut.Mul(5, 4);

            Assert.AreEqual(20, result);
        }

        [TestMethod]

        public void ShouldSubReturnZeroWhenPassFiveandFive()
        {
            CalculatorOP sut = new CalculatorOP();

            int result = sut.Sub(5, 5);

            Assert.AreEqual(0, result);

        }

        [TestMethod]

        public void ShouldDivReturn1Point5WhenPassThreeand2()
        {
            CalculatorOP sut = new CalculatorOP();

            double result = sut.Div(3, 2);

            Assert.AreEqual(1.5 , result);
        }

    }
}

using calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest {
    [TestClass]
    public class ProgramTest {
        [TestMethod]
        public void GetSumWithDigitsExpectSum() {
           Assert.AreEqual(3, Program.GetSum("1 2"));
        }

        [TestMethod]
        public void GetSumWithLettersExpectnull() {
           Assert.AreEqual(null, Program.GetSum("a 2"));
        }
        [TestMethod]
        public void GetSumWithLettersExpectnull2() {
           Assert.AreEqual(null, Program.GetSum("a 2"));
        }
    }



}

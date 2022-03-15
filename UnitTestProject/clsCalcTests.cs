using SampleCalc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleCalc.Tests
{
    [TestClass()]
    public class clsCalcTests
    {
        clsCalc cc = new clsCalc();

        [TestMethod()]
        public void CalcTest()
        {
            string result = cc.Calc("3", "3");
            Assert.AreNotEqual(result, "15");
        }

        [TestMethod()]
        public void XXXTest()
        {
            cc.XXX();
            Assert.AreEqual(cc.InText, "TEST");
        }

        [TestMethod()]
        public void YYYTest()
        {
            int result = cc.YYY("1", "2", "3");
            Assert.AreEqual(result, 0);
        }
    }
}
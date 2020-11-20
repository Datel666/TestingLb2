using NUnit.Framework;
using Math;

namespace TestingLb2
{
    public class UnitTest2
    {
        
        [Test]
        public void TestMinus1()
        {
            var actual = Formula.formula(-1);
            var expected = -19.9;

            Assert.AreEqual(expected, actual, 0.1);
        }

        [Test]
        public void TestMinus2()
        {
            var actual = Formula.formula(-2);
            var expected = 14.1;

            Assert.AreEqual(expected, actual, 0.1);
        }

        [Test]
        public void TestMinus10()
        {
            var actual = Formula.formula(-10);
            var expected = 3.7;

            Assert.AreEqual(expected, actual, 0.1);
        }

        [Test]
        public void TestPlus1()
        {
            var actual = Formula.formula(1);
            var expected = double.NaN;

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TestPlus2()
        {
            var actual = Formula.formula(2);
            var expected = 0.4;

            Assert.AreEqual(expected, actual, 0.1);
        }

        [Test]
        public void TestPlus5()
        {
            var actual = Formula.formula(5);
            var expected = 88.8;

            Assert.AreEqual(expected, actual, 0.1);
        }

        [Test]
        public void TestPlus10()
        {
            var actual = Formula.formula(10);
            var expected = 2927.337;

            Assert.AreEqual(expected, actual, 0.1);
        }
    }
}

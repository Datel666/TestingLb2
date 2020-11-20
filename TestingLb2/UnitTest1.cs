using NUnit.Framework;
using Functions;

namespace TestingLb2
{
    public class Tests
    {
        
        [Test]
        public void TestSin()
        {
            var x = -10;
            var actual = Func.Sin(x);
            var expected = System.Math.Sin(x);

            Assert.AreEqual(expected, actual, 0.01);
        }

        [Test]
        public void TestCos()
        {
            var x = 10;
            var actual = Func.Cos(x);
            var exp = System.Math.Cos(x);

            Assert.AreEqual(exp, actual, 0.01);
        }

        [Test]
        public void TestCos2()
        {
            var x = 10;
            var actual = Func.Cos2(x);
            var exp = System.Math.Cos(x) * System.Math.Cos(x);

            Assert.AreEqual(exp, actual, 0.01);
        }

        [Test]
        public void TestLn1()
        {
            var x = 1;
            var actual = Func.Ln(x);
            var expected = System.Math.Log(x);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestLn10()
        {
            var x = 10;
            var actual = Func.Ln(x);
            var expected = System.Math.Log(x);

            Assert.AreEqual(expected, actual, 0.01);
        }

        [Test]
        public void TestLog()
        {
            var x = 16;
            var newBase = 3;

            var actual = Func.Log(x, newBase);
            var expected = System.Math.Log(x, newBase);

            Assert.AreEqual(expected, actual, 0.01);
        }

        [Test]
        public void TestExp()
        {
            var x = 16;

            var actual = Func.Exp(x);
            var expected = System.Math.Exp(x);

            Assert.AreEqual(expected, actual, 0.01);
        }


        [Test]
        public void TestPow()
        {
            var x = 10;
            var radix = 15;

            var actual = Func.Pow(x, radix);
            var expected = System.Math.Pow(x, radix);

            Assert.AreEqual(expected, actual, 0.01);
        }

        [Test]
        public void TestNegativeAbs()
        {
            var x = -10;

            var actual = Func.Abs(x);
            var expected = System.Math.Abs(x);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestPositiveAbs()
        {
            var x = 15;

            var actual = Func.Abs(x);
            var expected = System.Math.Abs(x);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSqrt()
        {
            var x = 20;

            var actual = Func.Sqrt(x);
            var expected = System.Math.Sqrt(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
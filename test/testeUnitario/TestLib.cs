namespace MyProject.Tests.UnitTest
{
    using MyProject.Lib;

    using NUnit.Framework;

    /// <summary>
    /// Tests for lib.
    /// </summary>
    [TestFixture]
    public class TestLib
    {
        /// <summary>
        /// Test: Should sum two integers.
        /// </summary>
        [Test]
        public void ShouldSumTwoIntegers()
        {
            var calc = new Calc();
            var ret = calc.Sum(1, 2);
            Assert.AreEqual(3, ret);
        }
    }
}
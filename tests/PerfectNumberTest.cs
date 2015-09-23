namespace CSharp.Training.Tests
{
    using CSharp.Training;
    using NUnit.Framework;
    [TestFixture]
    public class PerfectNumberTest
    {
        PerfectNumber Test = new PerfectNumber();
        [Test]
        public void TestingPerfectNumber()
        {
            Assert.That(Test.PerfectNumberMethod(6), Is.EqualTo("Perfect number"));
            Assert.That(Test.PerfectNumberMethod(15), Is.EqualTo("Not Perfect number"));
            Assert.That(Test.PerfectNumberMethod(28), Is.EqualTo("Perfect number"));
            Assert.That(Test.PerfectNumberMethod(39), Is.EqualTo("Not Perfect number"));
        }
    }
}

namespace CSharp.Training.Tests
{
    using CSharp.Training;
    using NUnit.Framework;
    [TestFixture]
    public class LeapYearTests
    {
        
            LeapYear Test = new LeapYear();
            [Test]
            public void TestingLeapYear()
            {
                Assert.That(Test.LeapYearMethod(400), Is.EqualTo("LeapYear"));
                Assert.That(Test.LeapYearMethod(100), Is.EqualTo("Not LeapYear"));
                Assert.That(Test.LeapYearMethod(1992), Is.EqualTo("LeapYear"));
                Assert.That(Test.LeapYearMethod(1867), Is.EqualTo("Not LeapYear"));
            }
        
    }
}

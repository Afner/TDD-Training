namespace CSharp.Training.Tests
{
    using CSharp.Training;
    using NUnit.Framework;
    [TestFixture]
    public class FizzBuzzTests
    {
        FizzBuzz Test = new FizzBuzz();
        [Test]
         public void TestingFizzBuzz()
         {
             Assert.That(Test.Fizz(3), Is.EqualTo("Fizz"));
             Assert.That(Test.Fizz(5), Is.EqualTo("Buzz"));
             Assert.That(Test.Fizz(15), Is.EqualTo("FizzBuzz"));
             Assert.That(Test.Fizz(1), Is.EqualTo("nope"));
         }
    }
}

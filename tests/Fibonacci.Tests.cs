namespace CSharp.Training.Tests
{
    using CSharp.Training;
    using NUnit.Framework;
    [TestFixture]
    public class FibonacciTests
    {
        
        Fibonacci Test = new Fibonacci();
        [Test]
        public void TestingFibonacci(){
       
            Assert.That(Test.FibonMethod(4),Is.EqualTo(3));
            Assert.That(Test.FibonMethod(5), Is.EqualTo(5));
            Assert.That(Test.FibonMethod(2), Is.EqualTo(1));
        }

    }
}

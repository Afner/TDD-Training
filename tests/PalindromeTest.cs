namespace CSharp.Training.Tests
{
    using CSharp.Training;
    using NUnit.Framework;
    [TestFixture]
    public class PalindromeTest
    {
        Palindrome Test = new Palindrome();
        [Test]
        public void TestingPalindrome()
        {
            Assert.That(Test.PalindromeMethod("Hola"), Is.EqualTo("Is not a palindrome"));
            Assert.That(Test.PalindromeMethod("anita lava la tina"), Is.EqualTo("Is a palindrome"));
            Assert.That(Test.PalindromeMethod("ola ke ase"), Is.EqualTo("Is not a palindrome"));
            Assert.That(Test.PalindromeMethod("in girum imus nocte et consumimur igni"), Is.EqualTo("Is a palindrome"));
      
        }
    }
}

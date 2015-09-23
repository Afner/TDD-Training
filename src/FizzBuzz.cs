using System;

namespace CSharp.Training
{
    public class FizzBuzz
    {
        /// <summary>
        /// FizzBuzz Compute Method
        /// * If the number is divisible by three then the result will be "Fizz"
        /// * If the number is divisible by five then the result will be "Buzz"
        /// * If the number is divisible by three and five then the result will be "FizzBuzz"
        /// </summary>
        /// <param name="number">Number to compute</param>
        /// <returns>Computed result</returns>
        public string Compute(int number)
        {
            throw new NotImplementedException("The trainee should implement this code");
        }
        public string Fizz(int number) {

            if (number % 3 == 0 && number %5 == 0)
            {
                return "FizzBuzz";
            }
            else
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            else
            if (number % 5 == 0)
            {
            return "Buzz";
            }
            else
            {
            return "nope";
            }
        }
    }
}

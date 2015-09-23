namespace CSharp.Training
{
    public class PerfectNumber
    {
        public string PerfectNumberMethod(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
            {
                return "Perfect number";
            }
            else
            {
                return "Not Perfect number";
            }
        }
        
    }
}

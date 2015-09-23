namespace CSharp.Training
{
    public class Fibonacci
    {
        int n=0;
        public int FibonMethod(int n)
        {

            int number = n; //Need to decrement by 1 since we are starting from 0
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            { 
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            
            for (int i = 2; i <= number; i++)
            {
               
                Fib[i] = Fib[i - 2] + Fib[i - 1];
                }
           
            return Fib[number];
            }
        }
    }
}

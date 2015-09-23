namespace CSharp.Training
{
    public class Palindrome
    {
       
        public string PalindromeMethod(string word)
        {
            word = word.Replace(" ", "");
            string revs = "";
            for (int i = word.Length - 1; i >= 0; i--) //String Reverse
            {
                revs += word[i].ToString();
            }
            if (revs == word) // Checking whether string is palindrome or not
            {
                return "Is a palindrome";
            }
            else
            {
                return "Is not a palindrome";
            }
        }

    }
}

using System;

namespace HighestPalindrome
{
    class Program
    {
        // Complete the highestValuePalindrome function below.
        public static string highestValuePalindrome(string s, int n, int k)
        {
           

            int cngCounter = k;
            char[] inputArray = s.ToCharArray();


            // Converted to palindrome
            for (int i = 0, j = n-1; i <= j && k > 0; i++, j--)
            {

                if(inputArray[i] != inputArray[j])
                {
                    inputArray[j] = inputArray[i];
                    k--;
                }
            }

            //bool isPalindrome = true;
            // Now check palindrome or not
            for(int i = 0, j = n-1; i < j; i++, j--)
            {
                if (inputArray[i] != inputArray[j])
                    return "-1";
            }

            return new string(inputArray);
        }


        static void Main(string[] args)
        {
            string result;
            result = highestValuePalindrome("1221", 4, 0);
            Console.WriteLine(result);

            result = highestValuePalindrome("3943", 4, 1);
            Console.WriteLine(result);

            result = highestValuePalindrome("092282", 6, 3);
            Console.WriteLine(result);

            result = highestValuePalindrome("0011", 4, 1);
            Console.WriteLine(result);


            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}

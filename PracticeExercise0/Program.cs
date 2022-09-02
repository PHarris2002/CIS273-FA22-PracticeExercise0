using System;
using System.Diagnostics.CodeAnalysis;

namespace PracticeExcercise0
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("mom "));
            Console.WriteLine(IsPalindrome("Mom"));
            Console.WriteLine(IsPalindrome("Race car"));
            Console.WriteLine(IsPalindrome("A nut for a jar of tuna"));

            Console.WriteLine(Reverse("coffee"));
            Console.WriteLine(Reverse("abcdefghijklmnopqrstuvwxyz"));
            Console.WriteLine(Reverse("Dad"));
            Console.WriteLine(Reverse(""));
            Console.WriteLine(Reverse("savannaH"));

            Console.WriteLine(ReverseInt(369));

            Console.WriteLine(IsUnique("mom"));
            IsUnique("");
            IsUnique("mom");
            IsUnique("Robbie");
            IsUnique("Judah");

            Console.WriteLine(IsNeilNumber(99999));

        }


        // #1
        public static bool IsPalindrome(string s)
        {
            // clean up the string; remove spaces and lowercase all capital letters
            // reverse the clean string
            string cleanString = s.ToLower().Replace(" ", "");

            // check if reverse string is the same as the clean string
            string reversed = Reverse(cleanString);

            // check if reverse string is the same as the clean string
            if (reversed == cleanString)
            {
                return true;
            }
            else
            {
                return false;
            }

            return true;
        }

        private static string Reverse(string s)
        {
            string result = "";

            foreach (char c in s)
            {
                result = result.Insert(0, c.ToString());
            }


            return result;
        }

        // #2 
        public static int ReverseInt(int i)
        {
            return 0;
            // 369 % 10 = 9
            // 369 / 10 = 36
            // 36 % 10 = 6
            // 36 / 10 = 3
            // 3 % 10 = 3
            // 3 / 10 = 0

            int x = i;
            int reverse = 0;

            while (x != 0 )
            {
                int remainder = x % 10;
                reverse = reverse * 10 + remainder;
                x = x / 10;
            }
            return reverse;
         }

        // #3
        public static bool IsUnique(string s)
        {
            string cleanString = s.ToLower().Replace(" ", "");

            for (int i=0; i < cleanString.Length; i++)
            {
                // compare cleanString[i] to every subsequent letter
                // in cleanString

                for(int j=i+1; j < cleanString.Length; j++)
                {
                    if (cleanString[i] == cleanString[j])
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }


        // #4
        public static bool IsNeilNumber(int i)
        {

            //counts digits so the digitCount can be used as an exponent
            int digitCount = 0;

            //makes input number iterable
            string stringNumber = i.ToString();

            //counter
            foreach (char number in stringNumber)
            {
                digitCount += 1;
            }

            //gets sum of each number powered by the number of digits in number input
            int poweredSum = 0;

            foreach (char number in stringNumber)
            {
                string convertedNumber = number.ToString();
                int poweredNumber = (int)Math.Pow(int.Parse(convertedNumber), digitCount);
                poweredSum += poweredNumber;
                Console.WriteLine(poweredSum);

            }

            if (i == poweredSum)
            {
                return true;
            }

            else
            {
                return false;
            }
            
        }

    }
}

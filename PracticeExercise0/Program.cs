﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace PracticeExcercise0
{
    public class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine(IsPalindrome("mom "));
            //Console.WriteLine(IsPalindrome("Mom"));
            Console.WriteLine(IsPalindrome("Race car"));
            Console.WriteLine(IsPalindrome("A nut for a jar of tuna"));

            //Console.WriteLine(Reverse("coffee"));
            //Console.WriteLine(Reverse("abcdefghijklmnopqrstuvwxyz"));
            //Console.WriteLine(Reverse("Dad"));
            //Console.WriteLine(Reverse(""));
            //Console.WriteLine(Reverse("savannaH"));

            Console.WriteLine(ReverseInt(369)); // 963
            Console.WriteLine(ReverseInt(-369)); // -963


            //Console.WriteLine(IsUnique("mom"));
            //IsUnique("");
            //IsUnique("mom");
            //IsUnique("Robbie");
            //IsUnique("Judah");

            Console.WriteLine(IsNeilNumber(99999));

        }


        // #1
        public static bool IsPalindrome(string s)
        {
            return true;
        }

            return true;
        }

        private static string Reverse(string s)
        {
            string result = "";
            

            return result;
        }

        // #2 
        public static int ReverseInt(int i)
        {
            return 0;
        }

        // #3
        public static bool IsUnique(string s)
        {
            
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

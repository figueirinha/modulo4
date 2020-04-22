using System;
using System.Collections.Generic;
using System.IO;

namespace Ficha21
{
    public static class Ficha21Solucao
    {
        public static int SumArrayElements(this int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++) sum += array[i];
            
            return sum;
        }
        public static bool BetweenTwoNums(this int num)
        {
            int min = 0;
            int max = 5;

            return num >= min && num <= max;
        }
        public static string DateMonth(this DateTime date)
        {
            return date.ToString("MMMM");
        }
        public static string DateDayOfWeek(this DateTime date)
        {
            return date.DayOfWeek.ToString();
        }
        public static bool IsVowel(this char vowel)
        {            
            return "aeiou".ToLower().Contains(vowel);
        }
        public static bool IsConsonant(this char consonant)
        {            
            return "bcdfghjklmnpqrstwvxyz".ToLower().Contains(consonant);
        }
        public static void Vowels(this string str)
        {
            List<string> vowelList = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {
                if (IsVowel(str[i])) vowelList.Add(str[i].ToString());
            }

            for (int i = 0; i < vowelList.Count; i++) Console.WriteLine(vowelList[i]);

        }
        public static void Consonants(this string str)
        {
            List<string> consonantList = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {
                if (IsConsonant(str[i])) consonantList.Add(str[i].ToString());
            }

            for (int i = 0; i < consonantList.Count; i++) Console.WriteLine(consonantList[i]);
        }
        public static void Nums(this string str)
        {
            string newStr = str;

            for (int i = 0; i < newStr.Length; i++)
            {
                if (!"0123456789".Contains(newStr[i])) newStr = newStr.Replace(newStr[i], ' ');                
            }
            var numArray = newStr.Trim().Split(' ');

            for (int i = 0; i < numArray.Length; i++) Console.WriteLine(numArray[i]);            
        }
        public static void SpecialChars(this string str)
        {
            string newStr = str.ToLower();

            for (int i = 0; i < newStr.Length; i++)
            {
                if ("0123456789abcdefghijklmnokqrstuvwxyz".Contains(newStr[i]))
                {
                    newStr = newStr.Replace(newStr[i],' ');
                }
            }
            
            for (int i = 0; i < newStr.Length; i++)
            {
                if (newStr[i]!=' ') Console.WriteLine(newStr[i]);
            }
        }        
    }
}

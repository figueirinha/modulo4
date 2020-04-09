using System;

namespace Ficha14
{
    public class Ficha14Solucao
    {
        #region Exercicio1
        public static void ShowNum(int starter, int limit)
        {
            if (starter == limit)
            {
                Console.WriteLine(limit);
            }
            else
            {
                Console.WriteLine(starter);
                ShowNum(starter + 1, limit);
            }
        }
        
        public static void ShowFirstNNaturals(int limit)
        {
            ShowNum(1, limit);
        }
        #endregion

        #region Exercicio2
        public static void ShowNaturalsDown(int start)
        {
            if (start == 0)
            {
                Console.WriteLine(start);
            }
            else
            {
                Console.WriteLine(start);
                ShowNaturalsDown(start - 1);
            }
        }
        #endregion

        #region Exercicio3
        public static void SumNFirstNaturals(int num, int sum = 0)
        {
            if (num == 0)
            {
                Console.WriteLine(sum);
            }
            else
            {
                SumNFirstNaturals(num - 1, sum += num);
            }
        }
        #endregion

        #region Exercicio4
        public static void EvenNums(int m, int n)
        {
            if (m <= n)
            {
                if (m % 2 == 0)
                {
                    Console.WriteLine(m);
                }

                EvenNums(m + 1, n);
            }
        }
        #endregion

        #region Exercicio5
        public static int Fibonacci(int i, ref string list)
        {
            if (i <= 1)
            {
                list += i + " ";
                return 1;
            }
            string u = " ";
            var fibo = Fibonacci(i - 1, ref list) + Fibonacci(i - 2, ref u);
            list += fibo + " ";
            return fibo;
            
        }
        #endregion

        #region Exercicio6
        public static int Factorial(int num)
        {
            if (num == 1)
            {
                return num;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }
        #endregion 
    }
}

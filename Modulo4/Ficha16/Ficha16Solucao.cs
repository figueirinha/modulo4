using System;
using System.Collections.Generic;

namespace Ficha16
{
    public class Ficha16Solucao
    {
        #region Exercicio1
        public static void Exercicio1()
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduzir número:");
                int num = int.Parse(Console.ReadLine());

                list.Add(num);
            }

            Console.WriteLine("Elementos na lista: ");

            for (int j = 0; j < list.Count; j++)
            {
                Console.WriteLine(list[j]);
            }
        }
        #endregion

        #region Exercicio2
        public static void Exercicio2()
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduzir número:");
                int num = int.Parse(Console.ReadLine());

                list.Add(num);
            }

            Console.WriteLine("Elementos listados por ordem inversa:");

            for (int j = list.Count - 1; j >= 0; j--)
            {
                Console.WriteLine(list[j]);
            }
        }
        #endregion

        #region Exercicio3
        public static void Exercicio3()
        {
            List<int> list = new List<int>();
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduza número:");
                int num = int.Parse(Console.ReadLine());

                list.Add(num);
            }

            for (int j = 0; j < list.Count; j++)
            {
                sum += list[j];
            }

            Console.WriteLine("A soma de todos os elementos listados é " + sum);
        }
        #endregion

        #region Exercicio4
        public static void Exercicio4(List<int> inputList)
        {
            List<int> countList = new List<int>();
            int count = 1;
            int duplicate = 0;

            for (int i = 0; i < inputList.Count; i++)
            {
                for (int j = i; j < inputList.Count; j++)
                {
                    if (inputList[i] == inputList[j])
                    {                        
                        countList.Add(count);
                        count++;
                    }
                }
                count = 1;
            }

            for (int k = 0; k <  countList.Count; k++)
            {
                if (countList[k] == 2)
                {
                    duplicate++;
                }
            }
            Console.WriteLine("Encontram-se repetidos " + duplicate + " elementos na lista.");
        }
        #endregion

        #region Exercicio5
        public static void Exercicio5(List<int> inputList)
        {
            List<int> uniqueList = new List<int>();
            int count = 0;

            for (int i = 0; i < inputList.Count; i++)
            {
                for (int j = 0; j < inputList.Count; j++)
                {
                    if (inputList[i] == inputList[j])
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    uniqueList.Add(inputList[i]);
                }
                count = 0;
            }

            for (int k = 0; k < uniqueList.Count; k++)
            {
                Console.WriteLine("O elemento " + uniqueList[k] + " é unico nesta lista.");
            }

        }
        #endregion

        #region Exercicio6
        public static void Exercicio6(List<int> inputList)
        {
            List<int> listSorted = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                listSorted.Add(inputList[i]);
            }

            for (int j = 0; j < listSorted.Count; j++)
            {
                for (int k = j + 1; k < listSorted.Count; k++)
                {
                    if (listSorted[j] > listSorted[k])
                    {
                        int help = listSorted[k];
                        listSorted[k] = listSorted[j];
                        listSorted[j] = help;
                    }
                }
            }

            Console.WriteLine("O menor valor da lista é " + listSorted[0] + " e o maior valor é " + listSorted[listSorted.Count - 1]);
        }
        #endregion

        #region Exercicio7
        public static void Exercicio7(List<int> inputList)
        {
            List<int> even = new List<int>();
            List<int> notEven = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] % 2 == 0)
                {
                    even.Add(inputList[i]);
                }
                else
                {
                    notEven.Add(inputList[i]);
                }
            }

            Console.WriteLine("Os números pares são:");
            for (int j = 0; j < even.Count; j++)
            {
                Console.WriteLine(even[j]);
            }

            Console.WriteLine("Os números impares são:");
            for (int k = 0; k < notEven.Count; k++)
            {
                Console.WriteLine(notEven[k]);
            }
        }
        #endregion

        #region Exercicio8
        public static void Exercicio8(List<int> inputList, int element)
        {
            bool confirm = false;

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] == element)
                {
                    Console.WriteLine(element + " encontra-se na lista.");
                    confirm = true;
                }
            }

            if (!confirm)
            {
                Console.WriteLine(element + " não se encontra na lista.");
            }
        }
        #endregion 
    }
}

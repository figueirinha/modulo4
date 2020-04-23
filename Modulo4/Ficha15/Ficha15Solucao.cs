using System;

namespace Recodme.Formacao.Exercicios.Ficha15
{
    public class Ficha15Solucao
    {
        #region Exercicio1
        public static void Exercicio1()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("qual o " + (i + 1) + "º número do array?");
                int num = int.Parse(Console.ReadLine());

                array[i] = num;
            }

            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine("índice " + j + " tem o valor " + array[j]);
            }
        }
        #endregion

        #region Exercicio2
        public static void Exercicio2()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("qual o " + (i + 1) + "º número do array?");
                int num = int.Parse(Console.ReadLine());

                array[i] = num;
            }

            for(int j = (array.Length - 1); j >= 0 ; j--)
            {
                Console.WriteLine("Índice " + j + " tem o valor " + array[j]);
            }
        }
        #endregion

        #region Exercicio3
        public static void Exercicio3()
        {
            int[] array = new int[10];
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("qual o " + (i + 1) + "º número do array?");
                int num = int.Parse(Console.ReadLine());

                array[i] = num;
            }

            for (int j = 0; j < array.Length; j++)
            {
                sum += array[j];
            }

            Console.WriteLine("A soma de todos os vetores no array é " + sum);
        }
        #endregion

        #region Exercicio4
        public static void Exercicio4(int[] array)
        {
            Console.WriteLine("O número de elementos no array é " + array.Length);
        }
        #endregion

        #region Exercicio5
        public static void Exercicio5(int[] array)
        {
            int count = 1;
            int duplicate = 0;
            int[] emptyArray = new int[array.Length];
           
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        emptyArray[i]=count;
                        count++;
                    }
                }
                count = 1;
            }

            for (int k = 0; k < array.Length; k++)
            {
                if (emptyArray[k] >= 2)
                {
                    duplicate++;
                }
            }
            Console.WriteLine("Encontram-se repetidos " + duplicate + " elementos.");
        }
        #endregion

        #region Exercicio6
        public static void Exercicio6(int[] array)
        {
            int[] emptyArray = new int[array.Length];
            int count = 0;
            int indexCounter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    emptyArray[indexCounter] = array[i];
                    indexCounter++;
                }
                count = 0;
            }

            int[] newArray = new int[indexCounter];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = emptyArray[i];
            }

            for (int j = 0; j < newArray.Length; j++)
            {
                Console.WriteLine("O elemento " + emptyArray[j] + " é único neste array.");
            }
            
        }
        #endregion

        #region Exercicio7
        public static void Exercicio7(int[] array)
        {
            int[] arraySorted = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                arraySorted[i] = array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (arraySorted[i] > arraySorted[k])
                    {
                        int help = arraySorted[k];  //para ajudar a trocar os elementos
                        arraySorted[k] = arraySorted[i];
                        arraySorted[i] = help;
                    }
                 
                }
                
            }

            Console.WriteLine("O menor valor do array é " + arraySorted[0] +
                " e o maior valor é " + arraySorted[arraySorted.Length - 1] + ".");
        }
        #endregion

        #region Exercicio8
        public static void Exercicio8(int[] array)
        {
            int[] emptyArrayEven = new int[array.Length];
            int[] emptyArrayNotEven = new int[array.Length];
            int countEven = 0;
            int countNotEven = 0;


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    emptyArrayEven[countEven] = array[i];
                    countEven++;
                }
                else
                {
                    emptyArrayNotEven[countNotEven] = array[i];
                    countNotEven++;
                }
            }

            int[] newArrayEven = new int[countEven];
            int[] newArrayNotEven = new int[countNotEven];

            for (int i = 0; i < newArrayEven.Length; i++)
            {
                newArrayEven[i] = emptyArrayEven[i];
            }

            for (int i = 0; i < newArrayNotEven.Length; i++)
            {
                newArrayNotEven[i] = emptyArrayNotEven[i];
            }

            Console.WriteLine("Números pares: ");
            for (int k = 0; k < newArrayEven.Length; k++)
            {
                Console.WriteLine(newArrayEven[k]);
            }

            Console.WriteLine("Números impares: ");
            for (int k = 0; k < newArrayNotEven.Length; k++)
            {
                Console.WriteLine(newArrayNotEven[k]);
            }
        }
        #endregion

        #region Exercicio9
        public static void Exercicio9(int[] array, int element)
        {
            bool confirm = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    Console.WriteLine(element + " encontra-se no array.");
                    confirm = true;
                }
                
            }
            if (!confirm)
            {
                Console.WriteLine(element + " não se encontra no array.");
            }
        }
        #endregion 
    }
}

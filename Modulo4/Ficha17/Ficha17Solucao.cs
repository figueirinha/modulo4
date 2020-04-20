using System;

namespace Ficha17
{
    public class Ficha17Solucao
    {
        #region Exercicio1
        public static void Exercicio1()
        {
            Console.WriteLine("Introduza uma string:");
            string str = Console.ReadLine();
            Console.WriteLine("Introduza o índice:");
            int index = int.Parse(Console.ReadLine());

            if(index < str.Length)
            {
                Console.WriteLine($"O índice {index} da string {str} é {str[index]}");
            }
            else
            {
                Console.WriteLine("Índice maior que o tamanho da string introduzida.");
            }
        }
        #endregion

        #region Exercicio2
        public static void Exercicio2()
        {
            Console.WriteLine("Introduza uma string:");
            string strOne = Console.ReadLine();
            Console.WriteLine("Introduza outra string:");
            string strTwo = Console.ReadLine();
            int lengthOfString;

            if (strOne.Length >= strTwo.Length)
            {
                lengthOfString = strTwo.Length;
            }
            else
            {
                lengthOfString = strOne.Length;
            }

            for (int i = 0; i < lengthOfString; i++)
            {
                if (strOne[i] != strTwo[i])
                {
                    Console.WriteLine($"No índice '{i}' as strings têm caracteres diferentes " +
                        $"(string 1 é '{strOne[i]}' e string 2 é '{strTwo[i]}').");
                }
                else
                {
                    Console.WriteLine($"No índice '{i}' as strings têm os mesmos caracteres " +
                        $"(string 1 é '{strOne[i]}' e string 2 é '{strTwo[i]}')");
                }                
            }

            if (strOne.Length != strTwo.Length)
            {
                Console.WriteLine("As strings têm tamanhos diferentes e apenas foram comparados os caracteres até" +
                    " ao maior índice da string de menor dimensão.");
            }
        }
        #endregion  

        #region Exercicio3
        public static void Exercicio3()
        {
            Console.WriteLine("Introduza uma string:");
            string str = Console.ReadLine();
            string strTrim = str.Trim();

            string[] strs = strTrim.Split(" ");

            Console.WriteLine($"Encontram-se {strs.Length} palavras na string introduzida.");
        }
        #endregion 

        #region Exercicio4
        public static void Exercicio4()
        {
            Console.WriteLine("Introduza uma string:");
            string str = Console.ReadLine();

            Console.WriteLine($"Os primeiros 10 caracteres da string introduzida são: {str.Substring(0, 10)}");
        }
        #endregion 

        #region Exercicio5
        public static void Exercicio5()
        {
            Console.WriteLine("Introduza uma string:");
            string str = Console.ReadLine();

            Console.WriteLine($"Os últimos 10 caracteres da string introduzida são: {str.Substring(str.Length - 10, 10)}");
        }
        #endregion 

        #region Exercicio6
        public static void Exercicio6()
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine("Introduza uma string:");
            string str = Console.ReadLine();
            string strSpaces = str.Replace(" ", "");
            int count = 0;

            for (int i = 0; i < abc.Length; i++)
            {
                if (str.ToLower().Contains(abc[i]))
                {
                    Console.WriteLine($"{strSpaces[count]} corresponde ao número {i + 1} no alfabeto.");
                    count++;
                }
            }
        }
        #endregion 

        #region Exercicio7
        public static void Exercicio7()
        {
            Console.WriteLine("Introduza uma string:");
            string str = Console.ReadLine();
            string strInverse = "";

            for (int i = 0; i < str.Length; i++)
            {
                strInverse = str[i] + strInverse;
            }
            Console.WriteLine($"A string inversa é '{strInverse}'");
        }
        #endregion 

        #region Exercicio8
        public static void Exercicio8()
        {
            Console.WriteLine("Introduza uma string:");
            string str = Console.ReadLine();
            string abc = "abcdefghijklmnopqrstuvwxyz";
            string strAbc = "";

            for (int i = 0; i < abc.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (abc[i] == str[j])
                    {
                        strAbc += abc[i];
                    }
                }
            }

            Console.WriteLine("caracteres da string por ordem alfabética: " + strAbc);

        }
        #endregion 

        #region Exercicio9
        public static void Exercicio9()
        {
            Console.WriteLine("Introduza o nome:");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}");
        }
        #endregion 

        #region Exercicio10
        public static void Exercicio10()
        {
            Console.WriteLine("Introduza uma string:");
            string str = Console.ReadLine();

            string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string num = "0123456789";
            int countAbc = 0;
            int countNum = 0;
            int countChar = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (abc.Contains(str[i]))
                {
                    countAbc++;
                }
                else if (num.Contains(str[i]))
                {
                    countNum++;
                }
                else
                {
                    countChar++;
                }
            }
            Console.WriteLine($"A string introduzida contém {countAbc} letras, {countNum} números e {countChar} caracteres.");
        }
        #endregion 

        #region Exercicio11
        public static void Exercicio11()
        {
            Console.WriteLine("Introduza uma string:");
            string str = Console.ReadLine();

            string vowels = "aeiouAEIOU";
            string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
            int countVowel = 0;
            int countConsonant = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    countVowel++;
                }
                if (consonants.Contains(str[i]))
                {
                    countConsonant++;
                }
            }
            Console.WriteLine($"A string introduzida contém {countVowel} vogal(ais) e {countConsonant} consoante(s).");
        }
        #endregion 

        #region Exercicio12
        public static void Exercicio12()
        {
            Console.WriteLine("Introduza uma string:");
            string str = Console.ReadLine();
            string strTwo = str.Replace(" ", "");
            int count = 0;
            int max = 0;
            int indexOf = 0;
            string result = "";
            string resultNum = "";

            for (int i = 0; i < strTwo.Length; i++)
            {
                for (int j = i; j < strTwo.Length; j++)
                {
                    if (strTwo[i] == strTwo[j])
                    {
                        count++;
                        result += strTwo[i];
                        resultNum += count;
                    }
                }
                count = 0;
            }

            for (int i = 0; i < resultNum.Length; i++)
            {
                if (resultNum[i] > max)
                {
                    indexOf = i;
                    max = resultNum[i];
                }
            }
            Console.WriteLine("O caracter com maior ocorrência é o " + result[indexOf]);
        }
        #endregion 

        #region Exercicio13 não resolvido
        public static void Exercicio13()
        {
            Console.WriteLine("Introduza uma string:");
            string str = Console.ReadLine();

        }
        #endregion 
    }
}

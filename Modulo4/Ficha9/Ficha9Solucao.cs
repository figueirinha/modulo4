using System;

namespace Ficha9
{
    public class Ficha9Solucao
    {
        #region Exercicio1
        public static void Exercicio1()
        {
            double produto = 1;

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Introduza Número");
                double numero = double.Parse(Console.ReadLine());
                produto *= numero;
            }

            Console.WriteLine("O produto dos dos 3 números é " + produto);
        }
        #endregion

        #region Exercicio2
        public static void Exercicio2()
        {
            Console.WriteLine("Número1?");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Número2?");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("A soma de num1 com num2 é " + (num1 + num2));
            Console.WriteLine("A subtração de num1 com num2 é " + (num1 - num2));
            Console.WriteLine("A multiplicação de num1 com num2 é " + (num1 * num2));
            Console.WriteLine("A divisão de num1 com num2 é " + (num1 / num2));
            Console.WriteLine("o resto da divisão de num1 por num2 é " + (num1 % num2));

        }
        #endregion

        #region Exercicio3
        public static void Exercicio3()
        {
            Console.WriteLine("Número1?");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Número2?");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Número3?");
            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("(num1 + num2) x num 3 = " + ((num1 + num2) * num3));
            Console.WriteLine("num1 x num2 + num2 x num3 = " + (num1 * num2 + num2 * num3));

        }
        #endregion

        #region Exercicio4
        public static void Exercicio4()
        {
            Console.WriteLine("Número ate que se deve apresentar todos os primos");
            int num = int.Parse(Console.ReadLine());
            int counterA = 2;

            while (counterA < num)
            {
                bool isPrime = true;
                int counterB = 2;

                while (counterB < counterA)
                {
                    if (counterA % counterB == 0)
                    {
                        isPrime = false;
                    }
                    counterB++; 
                }
                if (isPrime)
                {
                    Console.WriteLine(counterA);
                }
                counterA++;
            }
        }
        #endregion

        #region Exercicio5
        public static void Exercicio5()
        {
            Console.WriteLine("Hello?");
            string phrase = Console.ReadLine();
            string song = "is it me you're looking for?";

            if (phrase == song)
            {
                Console.WriteLine("I can see it in your eyes");
            }
            else
            {
                Console.WriteLine("bye");
            }
        }
        #endregion

        #region Exercicio6
        public static void Exercicio6()
        {
            Console.WriteLine("Pense num número entre 1 e 100");
        
            bool encontrado = false;
            int low = 1;
            int high = 100;

            while (!encontrado)
            {
                
                int guess = (low + high) / 2;
                Console.WriteLine("É menor que " + guess + "? S ou N");
                string resposta = Console.ReadLine();

                if (resposta == "S")
                {
                    high = guess - 1;
                }
                if (resposta == "N")
                {
                    low = guess;
                }
                if ((high - low) <= 2)
                {
                    Console.WriteLine("É " + (guess - 1));
                    string respostaFinal = Console.ReadLine();
                    
                    if (respostaFinal == "N")
                    {
                        Console.WriteLine("É " + guess);
                        respostaFinal = Console.ReadLine();
                        
                    }
                    else
                    {
                        Console.WriteLine("É " + (guess + 1));
                        respostaFinal = Console.ReadLine();
                        
                    }

                    encontrado = true;
                }
            }
        }
        #endregion 

    }
}

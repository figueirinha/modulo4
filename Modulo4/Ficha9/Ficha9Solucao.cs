using System;

namespace Ficha9
{
    public class Ficha9Solucao
    {
        #region Exercicio1
        public static void Exercicio1()
        {
            double produto = 1.0;

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
                        break;
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
            int low = 0;
            int high = 100;

            while (!encontrado)
            {
                
                int guess = (low + high) / 2;
                Console.WriteLine("É menor que " + guess + "? S ou N");
                string resposta = Console.ReadLine();

                if ((resposta == "S") || (resposta == "s"))
                {
                    high = guess - 1;
                }
                if ((resposta == "N") || (resposta == "n"))
                {
                    low = guess;
                }
                if ((high - low) <= 1)
                {
                    Console.WriteLine("É " + (guess - 1));
                    string respostaFinal = Console.ReadLine();
                    
                    if ((respostaFinal == "S") || (respostaFinal == "s")) 
                    {
                        Console.WriteLine("É " + guess);
                        respostaFinal = Console.ReadLine();
                        encontrado = true;

                    }
                    else if ((respostaFinal == "N") || (respostaFinal == "n"))
                    {
                        Console.WriteLine("É " + (guess + 1));
                        respostaFinal = Console.ReadLine();
                        encontrado = true;

                    }

                    
                }
            }
        }
        #endregion

        #region Exercicio7
        public static void Exercicio7()
        {
            Console.WriteLine("Qual o ano?");
            int ano = int.Parse(Console.ReadLine());

            if ((ano % 4 == 0) && (ano % 100 != 0) || (ano % 400 == 0))
            {
                Console.WriteLine("É bissexto sim senhora!");
            }
            else
            {
                Console.WriteLine("Não é bissexto :( ");
            }
           
        }
        #endregion

        #region Exercicio8
        public static void Exercicio8()
        {
            int counter = 99;

            do
            {
                Console.WriteLine(counter + " bottles of beer on the wall, "
                    + counter + " bottles of beer. \n Take one down and pass it around, " 
                    + (counter - 1) + " bottles of beer on the wall.");

                counter--;
            } while (counter != 0);

            Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer. \n" 
                + "Go to the Store and buy some more, 99 bottles of beer on the wall.");
        }
        #endregion

        #region Exercicio9
        public static void Exercicio9()
        {
            Console.WriteLine("Comprimento 1º lado?");
            double l1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Comprimento 2º lado?");
            double l2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Comprimento 3º lado?");
            double l3 = double.Parse(Console.ReadLine());

            if ((l1 == l2) && (l1 == l3))
            {
                Console.WriteLine("Equilátero");
            }
            else if((l1 == l2) || (l1 == l3) || (l2 == l3))
            {
                Console.WriteLine("Isóscele");
            }
            else
            {
                Console.WriteLine("Escaleno");
            }

        }
        #endregion

        #region Exercicio10
        public static void Exercicio10()
        {
            Console.WriteLine("valor inicial?");
            double valorInicial = double.Parse(Console.ReadLine());
            Console.WriteLine("valor total?");
            double valorTotal = double.Parse(Console.ReadLine());

            if ((valorTotal - valorInicial) > 0)
            {
                Console.WriteLine("Lucro");
            }
            else
            {
                Console.WriteLine("Prejuízo :( ");
            }
        }
        #endregion

        #region Exercicio6New
        public static void Exercicio6New()
        {
            Console.WriteLine("Quantos items?");
            int contagem = int.Parse(Console.ReadLine());

            while(contagem > 0)
            {
                if (contagem % 2 == 0)
                {
                    Console.WriteLine("um pra ti");
                }
                else
                {
                    Console.WriteLine("Um para mim");
                }
                contagem--;
            }
        }
        #endregion

        #region Exercicio11
        public static void Exercicio11()
        {
            Console.WriteLine("Número do mês? 1 - 12");
            int mes = int.Parse(Console.ReadLine());

            if (mes == 1)
            {
                Console.WriteLine("Jan, 31 dias"); 
            }
            else if (mes == 2)
            {
                Console.WriteLine("Fev, 28/29");
            }
            else if (mes == 3)
            {
                Console.WriteLine("Mar, 31");
            }
            else if (mes == 4)
            {
                Console.WriteLine("Abr, 30");
            }
            else if (mes == 5)
            {
                Console.WriteLine("Mai, 31");
            }
            else if (mes == 6)
            {
                Console.WriteLine("Jun, 30");
            }
            else if (mes == 7)
            {
                Console.WriteLine("Jul, 31");
            }
            else if (mes == 8)
            {
                Console.WriteLine("Ago, 31");
            }
            else if (mes == 9)
            {
                Console.WriteLine("Set, 30");
            }
            else if (mes == 10)
            {
                Console.WriteLine("Out, 31");
            }
            else if (mes == 11)
            {
                Console.WriteLine("Nov, 30");
            }
            else
            {
                Console.WriteLine("Dez, 31");
            }
        }
        #endregion 
    }
}

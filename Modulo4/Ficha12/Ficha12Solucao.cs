using System;

namespace Ficha12
{
    public class Ficha12Solucao
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
        #endregion#region Exercicio16

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

        #region Exercicio12
        public static void Exercicio12()
        {
            Console.WriteLine("Qual é a dimensão do triangulo?");
            int n = int.Parse(Console.ReadLine());
            int nFixo = n;
            int i = (n - 1) + n;

            while (n > 0)
            {
                n--;
                int a = 0;

                while (a != (nFixo - n)) 
                {
                    Console.Write(" ");
                    a++;
                }

                int b = 0;

                while (b != i)
                {
                    Console.Write("*");
                    b++;
                }

                i -= 2;
                Console.Write("\n");
            }


        }
        #endregion

        #region Exercicio13
        public static void Exercicio13()
        {
            Console.WriteLine("Quantidade de unidades de água consumidas?");
            double quantidade = double.Parse(Console.ReadLine());
            Console.WriteLine("Em que região se encontra? A, B C ou D?");
            string regiao = Console.ReadLine();
            double fatura = 1;

            if (regiao == "A" || regiao == "a")
            {
                fatura = quantidade * 2;
            }
            else if (regiao == "B" || regiao == "b")
            {
                fatura = quantidade * 1.20;
            }
            else if (regiao == "C" || regiao == "c")
            {
                fatura = quantidade * 1;
            }
            else if (regiao == "D" || regiao == "d")
            {
                fatura = quantidade * 0.75;
            }
            else
            {
                Console.WriteLine("Região inexistente");
            }

            Console.WriteLine("A sua fatura da água para o presente mês é " + fatura + " euros");

        }
        #endregion

        #region Exercicio14
        public static void Exercicio14()
        {
            Console.WriteLine("n números de Fibonacci (> 1)");
            int n = int.Parse(Console.ReadLine());
            int nMenosUm = 1;
            int nMenosDois = 0;
            int f;
            int counter = 2;

            Console.WriteLine(nMenosDois);
            Console.WriteLine(nMenosUm);

            while (counter < n)
            {
                f = nMenosUm + nMenosDois;
                Console.WriteLine(f);
                nMenosDois = nMenosUm;
                nMenosUm = f;
                counter++;
            }
           
        }
        #endregion

        #region Exercicio15
        public static void Exercicio15()
        {
            Console.WriteLine("Qual o número");
            int n = int.Parse(Console.ReadLine());

            int op1 = 5 * n * n + 4;
            int test1 = (int)Math.Sqrt(op1);
            int op2 = 5 * n * n - 4;
            int test2 = (int)Math.Sqrt(op2);


            if (((test1 * test1) == op1) || ((test2 * test2) == op2)) 
            {
                Console.WriteLine("Não é Fibonice!");
            }
            else
            {
                Console.WriteLine("É Fibonice!");
            }
        }
        #endregion 

        #region Exercicio16
        public static void Exercicio16()
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

    }
}
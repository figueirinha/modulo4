using System;

namespace Ficha13
{
    public class Ficha13Solucao
    {
        #region Exercicio1
        public static void Exercicio1()
        {
            #region Código repetitivo com o design da calculadora
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("   WELCOME TO THE CALCULATOR  ");
            Console.WriteLine("                              ");
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" 7 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" 8 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" 9 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("      ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" / ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" % ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine(" ");
            Console.WriteLine("                              ");
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" 4 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" 5 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" 6 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("      ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" X ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" - ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine(" ");
            Console.WriteLine("                              ");
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" 1 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" 2 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" 3 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("      ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" = ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" + ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine(" ");
            Console.WriteLine("                              ");
            Console.Write("       ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" 0 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" C ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("      ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ON/OFF ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------");
            Console.ResetColor();
            #endregion 

            Console.WriteLine("Calculadora on:");
            Console.WriteLine("número");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("operador");
            string operador = Console.ReadLine();
            double resultadoFinal = n;

            while (operador != "=")
            {
                if (operador == "+")
                {
                    Console.WriteLine("número");
                    double nA = double.Parse(Console.ReadLine());
                    resultadoFinal += nA;
                }
                else if (operador == "-")
                {
                    Console.WriteLine("número");
                    double nB = double.Parse(Console.ReadLine());
                    resultadoFinal -= nB;
                }
                else if (operador == "*")
                {
                    Console.WriteLine("número");
                    double nC = double.Parse(Console.ReadLine());
                    resultadoFinal *= nC;
                }
                else if (operador == "/")
                {
                    Console.WriteLine("número");
                    double nD = double.Parse(Console.ReadLine());
                    if (nD != 0)
                    {
                        resultadoFinal /= nD;
                    }
                    else
                    {
                        Console.WriteLine("ERRO! Divisão por zero!");
                        break;
                    }
                }
                else if (operador == "%")
                {
                    Console.WriteLine("número");
                    double nE = double.Parse(Console.ReadLine());
                    if (nE != 0)
                    {
                        resultadoFinal %= nE;
                    }
                    else
                    {
                        Console.WriteLine("ERRO! Resto da divisão por zero!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("operador não encontrado");
                }
                Console.WriteLine("operador");
                operador = Console.ReadLine();
            }
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("------------------------------");
            Console.Write("           O RESULTADO É ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" " + resultadoFinal + " ");
            Console.ResetColor();

        }
        #endregion

        #region Exercicio2
        public static void Exercicio2()
        {

        }
        #endregion 
    }
}

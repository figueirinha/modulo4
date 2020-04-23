using System;
using System.Text;

namespace Recodme.Formacao.Exercicios.Ficha13
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
                        resultadoFinal = 0;
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
                        resultadoFinal = 0;
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
            Console.Write("                O RESULTADO É ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" " + resultadoFinal + " ");
            Console.ResetColor();

        }
        #endregion

        #region Exercicio2 não resolvido
        public static void Exercicio2()
        {
            //resultados vencedores 
            string a = "_X_|___|___\n___|_X_|___\n   |   | X ";
            string b = "_O_|___|___\n___|_O_|___\n   |   | O ";
            string c = "___|___|_X_\n___|_X_|___\n X |   |   ";
            string d = "___|___|_O_\n___|_X_|___\n O |   |   ";
            string e = "_X_|_X_|_X_\n___|___|___\n   |   |   ";
            string f = "_O_|_O_|_O_\n___|___|___\n   |   |   ";
            string g = "___|___|___\n_X_|_X_|_X_\n   |   |   ";
            string h = "___|___|___\n_O_|_O_|_O_\n   |   |   ";
            string i = "___|___|___\n___|___|___\n X | X | X ";
            string j = "___|___|___\n___|___|___\n O | O | O ";
            string k = "_X_|___|___\n_X_|___|___\n X |   |   ";
            string l = "_O_|___|___\n_O_|___|___\n O |   |   ";
            string m = "___|_X_|___\n___|_X_|___\n   | X |   ";
            string n = "___|_O_|___\n___|_O_|___\n   | O |   ";
            string o = "___|___|_X_\n___|___|_X_\n   |   | X ";
            string p = "___|___|_O_\n___|___|_O_\n   |   | O ";

            string resultado = "_1_|_2_|_3_\n_4_|_5_|_6_\n 7 | 8 | 9 ";
            Console.WriteLine(resultado);
            int counter = 0;

            while(resultado != a|| resultado != b || resultado != c || resultado != d 
                || resultado != e || resultado != f || resultado != g || resultado != h 
                || resultado != i || resultado != j || resultado != k || resultado != l 
                || resultado != m || resultado != n || resultado != o || resultado != p)
            {
                counter++;

                Console.WriteLine("Player 1");
                int pOne = int.Parse(Console.ReadLine());

                if (pOne == 1)
                {
                    resultado = resultado.Replace("1", "X");
                    Console.WriteLine(resultado);
                }
                else if (pOne == 2)
                {
                    resultado = resultado.Replace("2", "X");
                    Console.WriteLine(resultado);
                }
                else if (pOne == 3)
                {
                    resultado = resultado.Replace("3", "X");
                    Console.WriteLine(resultado);
                }
                else if (pOne == 4)
                {
                    resultado = resultado.Replace("4", "X");
                    Console.WriteLine(resultado);
                }
                else if (pOne == 5)
                {
                    resultado = resultado.Replace("5", "X");
                    Console.WriteLine(resultado);
                }
                else if (pOne == 6)
                {
                    resultado = resultado.Replace("6", "X");
                    Console.WriteLine(resultado);
                }
                else if (pOne == 7)
                {
                    resultado = resultado.Replace("7", "X");
                    Console.WriteLine(resultado);
                }
                else if (pOne == 8)
                {
                    resultado = resultado.Replace("8", "X");
                    Console.WriteLine(resultado);
                }
                else
                {
                    resultado = resultado.Replace("9", "X");
                    Console.WriteLine(resultado);
                }

                Console.WriteLine("Player 2");
                int pTwo = int.Parse(Console.ReadLine());

                if (pTwo == 1)
                {
                    resultado = resultado.Replace("1", "O");
                    Console.WriteLine(resultado);
                }
                else if (pTwo == 2)
                {
                    resultado = resultado.Replace("2", "O");
                    Console.WriteLine(resultado);
                }
                else if (pTwo == 3)
                {
                    resultado = resultado.Replace("3", "O");
                    Console.WriteLine(resultado);
                }
                else if (pTwo == 4)
                {
                    resultado = resultado.Replace("4", "O");
                    Console.WriteLine(resultado);
                }
                else if (pTwo == 5)
                {
                    resultado = resultado.Replace("5", "O");
                    Console.WriteLine(resultado);
                }
                else if (pTwo == 6)
                {
                    resultado = resultado.Replace("6", "O");
                    Console.WriteLine(resultado);
                }
                else if (pTwo == 7)
                {
                    resultado = resultado.Replace("7", "O");
                    Console.WriteLine(resultado);
                }
                else if (pTwo == 8)
                {
                    resultado = resultado.Replace("8", "O");
                    Console.WriteLine(resultado);
                }
                else
                {
                    resultado = resultado.Replace("9", "O");
                    Console.WriteLine(resultado);
                }

                if (counter >= 3)
                {
                    resultado = resultado.Replace("1", "_");
                    resultado = resultado.Replace("2", "_");
                    resultado = resultado.Replace("3", "_");
                    resultado = resultado.Replace("4", "_");
                    resultado = resultado.Replace("5", "_");
                    resultado = resultado.Replace("6", "_");
                    resultado = resultado.Replace("7", " ");
                    resultado = resultado.Replace("8", " ");
                    resultado = resultado.Replace("9", " ");

                    Console.WriteLine(resultado);
                    Console.WriteLine("Jogo terminado");
                    break;
                }
                
            }

        }
        #endregion

        #region Exercicio3 
        public static void Exercicio3()
        {
            string errado1 = "   o   \n \n";
            string errado2 = "   o   \n   |   ";
            string errado3 = "   o   \n  (|   \n";
            string errado4 = "   o   \n  (|)  \n";
            string errado5 = "   o   \n  (|)  \n  (   ";
            string errado6 = "   o   \n  (|)  \n  ( )  ";

            string opOne = "ovelha";
            string opTwo = "ananas";
            string opThree = "macaco";
            string opFour = "banana";

            var selectWord = RandomWord(opOne, opTwo, opThree, opFour);
          
            string result = "******";
            Console.WriteLine(result);

            int guessCount = 0;

            while (result != selectWord)
            {
                Console.WriteLine("introduzir letra: ");
                var charac = Console.ReadLine();

                if (selectWord.Contains(charac))
                {
                    for (int i = 0; i < selectWord.Length; i++)
                    {
                        if (selectWord[i].ToString() == charac)
                        {
                            result = ReplaceChar(charac, new StringBuilder(result), i);
                           
                        }
                    }                 
                }
                else
                {
                    guessCount++;
                    Console.WriteLine("Oh no! The hangman is growing! You have left "
                        + (6 - guessCount) + " oportunities.");
                    switch (guessCount)
                    {
                        case 1:
                            Console.WriteLine(errado1);
                            break;
                        case 2:
                            Console.WriteLine(errado2);
                            break;
                        case 3:
                            Console.WriteLine(errado3);
                            break;
                        case 4:
                            Console.WriteLine(errado4);
                            break;
                        case 5:
                            Console.WriteLine(errado5);
                            break;
                        default:
                            Console.WriteLine(errado6);
                            break;
                    }
                    Console.WriteLine("Caracter " + charac + " não se encontra na palavra");
                }

                Console.WriteLine(result);          

                if (guessCount == 6) //numero de errados para completar o boneco
                {
                    Console.WriteLine("You lose, the man died.");
                    break;
                }

            }
            if (result == selectWord)
            {
                Console.WriteLine("You win!");
            }    
        }
        public static string RandomWord(string p1, string p2, string p3, string p4)
        {
            var result = (new Random()).Next(4) + 1;
            if (result == 1) return p1;
            else if (result == 2) return p2;
            else if (result == 3) return p3;
            else return p4;
        }
        public static string ReplaceChar(string c1, StringBuilder s1, Index i)
        {
            s1[i] = char.Parse(c1);
            return s1.ToString();
        }
        #endregion
    }
}

using System;

namespace Ficha11
{
    public class Ficha11Solucao
    {
        #region Exercicio1
        public static void Exercicio1()
        {
            Console.WriteLine("Número?");
            double num = double.Parse(Console.ReadLine());

            if (num > 9.44)
            {
                Console.WriteLine("Passou");
            }
            else
            {
                Console.WriteLine("Chumbou :(");
            }
        }

        #endregion

        #region Exercicio2
        public static void Exercicio2()
        {
            Console.WriteLine("Qual a sua altura?");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o seu peso?");
            double peso = double.Parse(Console.ReadLine());

            double bmi = peso / (altura * altura);

            if (bmi < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if ((bmi > 18.5) && (bmi < 24.9))
            {
                Console.WriteLine("Normal");
            }
            else if ((bmi > 25) && (bmi < 29.9))
            {
                Console.WriteLine("Acima do peso");
            }
            else
            {
                Console.WriteLine("Obeso");
            }
        }
        #endregion

        #region Exercicio3
        public static void Exercicio3()
        {
            Console.WriteLine("Número?");
            double num = double.Parse(Console.ReadLine());

            if ((num % 3 == 0) && (num % 7 == 0))
            {
                Console.WriteLine("Multiplo de 3 e 7");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Multiplo de 3 mas não de 7");
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine("Multiplo de 7 mas não de 3");
            }
            else
            {
                Console.WriteLine("Não é multiplo de 3 nem de 7");
            }
        }
        #endregion

        #region Exercicio4
        public static void Exercicio4()
        {
            Console.WriteLine("Número?");
            double num = double.Parse(Console.ReadLine());

            if ((num >= 30) && (num <= 50))
            {
                Console.WriteLine("Encontra-se entre 30 e 50 inclusive");
            }
            else
            {
                Console.WriteLine("Não se encontra entre 30 e 50 inclusive");
            }
        }
        #endregion

        #region Exercicio5
        public static void Exercicio5()
        {
            Console.WriteLine("Número?");
            double num = double.Parse(Console.ReadLine());

            if ((num > 10) && (num < 20))
            {
                Console.WriteLine("Encontra-se entre 10 e 20 exclusive");
            }
            else
            {
                Console.WriteLine("Não se encontra entre 10 e 20 exclusive");
            }
        }
        #endregion

        #region Exercicio6
        public static void Exercicio6()
        {
            Console.WriteLine("Andar?");
            double andar = double.Parse(Console.ReadLine());

            if ((andar < -2) || (andar == 3) || (andar == 5) || (andar > 6))
            {
                Console.WriteLine("Indisponivel :( ");
            }
            else
            {
                Console.WriteLine("A ir para o andar " + andar);
            }
        }

        #endregion

        #region Exercicio7
        public static void Exercicio7()
        {
            int i = 0;
            double soma = 0;

            while (i < 10)
            {
                Console.WriteLine("Número?");
                double num = double.Parse(Console.ReadLine());

                soma += num;
                i++;
                Console.WriteLine("Soma é igual a " + soma);
            }
        }
        #endregion

        #region Exercicio8
        public static void Exercicio8()
        {
            double total = 0;
            string lista = "";
            int i = 1;

            while (i != 0)
            {
                Console.WriteLine("Nome do produto? enter para terminar");
                string nome = Console.ReadLine();
                Console.WriteLine("Preço do produto? zero para terminar");
                double preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade desse produto? zero para terminar");
                double quantidade = double.Parse(Console.ReadLine());

                lista += "O produto " + nome + " teve um custo de " + (preco * quantidade) + "\n";
                total += preco * quantidade;

                Console.WriteLine("Deseja terminar? S ou N");
                string resposta = Console.ReadLine();
                if (resposta == "S")
                {
                    i = 0;
                }

            } 
            Console.WriteLine(lista);
            Console.WriteLine("O custo total da compra foi " + total);
        }
        #endregion

        #region Exercicio9
        public static void Exercicio9()
        {
            int i = 0;
            double soma = 0;
            double num;
            
            do
            {
                Console.WriteLine("Introduza um número, zero para terminar");
                num = double.Parse(Console.ReadLine());

                if (num != 0)
                {
                    soma += num;
                    i++;
                }

            } while (num != 0);

            Console.WriteLine("A média é " + (soma / i));
    
        }
        #endregion

        #region Exercicio10
        public static void Exercicio10()
        {
            Console.WriteLine("Primeiro número ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a operação? + - * / % ");
            var operador = Console.ReadLine();

            if (operador == "+")
            {
                Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
            }
            else if (operador == "-")
            {
                Console.WriteLine(num1 + " - "+ num2 + " = " + (num1 - num2));
            }
            else if (operador == "*")
            {
                Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
            }
            else if (operador == "/")
            {
                Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
            }
            else if (operador == "%")
            {
                Console.WriteLine(num1 + " % " + num2 + " = " + (num1 % num2));
            }
            else
            {
                Console.WriteLine("Operador não válido");
            }

        }
        #endregion

        #region Exercicio11
        public static void Exercicio11()
        {
            Console.WriteLine("Caracter?");
            var car = Console.ReadLine();

            for(int i = 0; i < 3; i++)
            {
                for( int j = 0; j < 3; j++)
                {
                    Console.Write(car + " ");
                }
                Console.WriteLine("\n");
            }
        }
        #endregion

        #region Exercicio12
        public static void Exercicio12()
        {
            Console.WriteLine("Caracter?");
            var car = Console.ReadLine();
            Console.WriteLine("Número?");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write(car + " ");
                }
                Console.WriteLine("\n");
            }
        }
        #endregion

        #region Exercicio13
        public static void Exercicio13()
        {
            Console.WriteLine("Caracter1?");
            var car1 = Console.ReadLine();
            Console.WriteLine("Caracter2?");
            var car2 = Console.ReadLine();
            Console.WriteLine("Número1?");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Número2?");
            int num2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < num1; i++) 
            {
                for (int j = 0; j < num2; j++) 
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(car1 + " ");
                    }
                    else
                    {
                        Console.Write(car2 + " ");
                    }
                        
                }
                Console.WriteLine("\n");
            }
        }
        #endregion

        #region Exercicio21
        public static void Exercicio21()
        {
            Console.WriteLine("Temperatura?");
            double temp = double.Parse(Console.ReadLine());
            string escala = "";

            while ((escala != "C") && (escala != "K") && (escala != "F"))
            {
                Console.WriteLine("Em que escala? C K ou F");
                escala = Console.ReadLine();
            }

            switch (escala)
            {
                case "C": Console.WriteLine(temp + " ºC é equivalente a " 
                    + (temp + 273.15) + " K e " + (temp * 9 / 5 + 32) + " F.");
                break;
                case "K": Console.WriteLine(temp + " K é equivalente a "
                    + (temp - 273.15) + " ºC e " + (temp * 9 / 5 - 459.67) + " F.");
                break;
                case "F": Console.WriteLine(temp + " F é equivalente a "
                    + ((temp - 32) * 5 / 9) + " ºC e " + ((temp + 459.67) * 5 / 9) + " K.");
                break;
                default: Console.WriteLine("Escala errada"); break; //nao acontece pq while em cima asegura-se disso

            }

        }
        #endregion

        #region Exercicio22
        public static void Exercicio22()
        {
            Console.WriteLine("Qual é o número limite?");
            int num = int.Parse(Console.ReadLine());

            for(int cont = 0; cont <= num; cont++)
            {
                if (cont % 2 == 1)
                {
                    Console.WriteLine(cont);
                }
            }
        }
        #endregion

        #region Exercicio23
        public static void Exercicio23()
        {
            string caracteres = "";
            string caracter;

            do
            {
                Console.WriteLine("Introduz um número, ou enter para terminar");
                caracter = Console.ReadLine();

                caracteres = caracter + caracteres;

            } while (caracter != "");

            Console.WriteLine(caracteres + " ");
        }
        #endregion

        #region Exercicio31
        public static void Exercicio31()
        {
            Console.WriteLine("Introduz um número");
            double num = double.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine(num * 3);
            }
            else
            {
                Console.WriteLine(num * 2); 
            }
        }
        #endregion

        #region Exercicio32
        public static void Exercicio32()
        {
            Console.WriteLine("Qual é a dimensão do triangulo?");
            int n = int.Parse(Console.ReadLine());
            int i = 1;

            while (n > 0)
            {
                n--;
                int a = 0;

                while (a != n)
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

                i += 2;
                Console.Write("\n");
            }

        }

        #endregion 

    }
}

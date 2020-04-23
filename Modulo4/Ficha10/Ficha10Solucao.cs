using System;

namespace Recodme.Formacao.Exercicios.Ficha10
{
    public class Ficha10Solucao
    {
        #region Exercicio1

        public static void Exercicio1()
        {
            Console.WriteLine("Qual é o nome?");
            var nome = Console.ReadLine();
            OlaNome(nome);
        }
       
        private static void OlaNome(string nome)
        {
            Console.WriteLine("Olá " + nome);
        }
        #endregion

        #region Exercicio2
        public static void Exercicio2()
        {
            Console.WriteLine("Num 1?");
            var num1 = Console.ReadLine();
            Console.WriteLine("Num 2?");
            var num2 = Console.ReadLine();
            var num1Conv = ConverterStringParaNumero(num1);
            var num2Conv = ConverterStringParaNumero(num2);
            ApresentarSoma(num1Conv, num2Conv);
            
        }

        public static int ConverterStringParaNumero(string num)
        {
            var parseOk = int.TryParse(num, out int parsedNum); 
            if (parseOk){
                return parsedNum;
            }
            return -1;
        }
        public static void ApresentarSoma( int numA, int numB)
        {
            Console.WriteLine(numA + " + " + numB + " = " + (numA + numB));
        }
        #endregion

        #region Exercicio3
        public static int LerEConverter()
        {
            Console.WriteLine("Número?");
            var num = Console.ReadLine();
            var numParsed = ConverterStringParaNumero(num);
            return numParsed;
        }
        public static void Exercicio3()
        {
            var total = LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            Console.WriteLine(total);

        }
        #endregion

        #region Exercicio4
        public static void Exercicio4()
        {
            Console.WriteLine("Num 1?");
            var a = Console.ReadLine();
            Console.WriteLine("Num 2?");
            var b = Console.ReadLine();
            var c = a;
            a = b;
            b = c;
            Console.WriteLine("Num 1 = " + a + " e Num 2 = " + b);
        }
        #endregion

        #region Exercicio5a
        public static void Exercicio5a()
        {
            Console.WriteLine("Num 1?");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Num 2?");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Num 3?");
            var c = double.Parse(Console.ReadLine());

            double x = a + (b * c);
            Console.WriteLine("Num1 + Num2 X Num3 = " + x);


        }
        #endregion

        #region Exercicio5b
        public static void Exercicio5b()
        {
            Console.WriteLine("Num 1?");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Num 2?");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Num 3?");
            var c = double.Parse(Console.ReadLine());

            double x = (a + b) % c;
            Console.WriteLine("(Num1 + Num2) % Num3 = " + x);
        }
        #endregion

        #region Exercicio5c
        public static void Exercicio5c()
        {
            Console.WriteLine("Num 1?");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Num 2?");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Num 3?");
            var c = double.Parse(Console.ReadLine());
            Console.WriteLine("Num 4?");
            var d = double.Parse(Console.ReadLine());

            double x = a + (b * c / d);
            Console.WriteLine("Num1 + Num2 X Num3 / Num4 = " + x);
        }
        #endregion

        #region Exercicio5d
        public static void Exercicio5d()
        {
            Console.WriteLine("Num 1?");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Num 2?");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Num 3?");
            var c = double.Parse(Console.ReadLine());
            Console.WriteLine("Num 4?");
            var d = double.Parse(Console.ReadLine());
            Console.WriteLine("Num 5?");
            var e = double.Parse(Console.ReadLine());
            Console.WriteLine("Num 6?");
            var f = double.Parse(Console.ReadLine());

            double x = a + (b / c * d) - (e % f);
            Console.WriteLine("num1 + num2 / num3 * num4 - num5 % num6 é igual a " + x);
        }
        #endregion

        #region Exercicio6
        public static void Exercicio6()
        {
            Console.WriteLine("Num para apresentar a tabuada desse num ate 10?");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine(a + " X 1 = " + (a * 1));
            Console.WriteLine(a + " X 2 = " + (a * 2));
            Console.WriteLine(a + " X 3 = " + (a * 3));
            Console.WriteLine(a + " X 4 = " + (a * 4));
            Console.WriteLine(a + " X 5 = " + (a * 5));
            Console.WriteLine(a + " X 6 = " + (a * 6));
            Console.WriteLine(a + " X 7 = " + (a * 7));
            Console.WriteLine(a + " X 8 = " + (a * 8));
            Console.WriteLine(a + " X 9 = " + (a * 9));
            Console.WriteLine(a + " X 10 = " + (a * 10));
        }
        #endregion

        #region Exercicio7
        public static void Exercicio7()
        {
            Console.WriteLine("Num 1?");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Num 2?");
            var b = double.Parse(Console.ReadLine());

            double m = (a + b) / 2;
            Console.WriteLine("A média de num1 e num2 é " + m);
        }
        #endregion

        #region Exercicio8
        public static void Exercicio8()
        {
            Console.WriteLine("Num 1?");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Num 2?");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Num 3?");
            var c = double.Parse(Console.ReadLine());
            Console.WriteLine("Num 4?");
            var d = double.Parse(Console.ReadLine());
            Console.WriteLine("Num 5?");
            var e = double.Parse(Console.ReadLine());

            double m = (a + b + c + d + e) / 5;
            Console.WriteLine("A média dos 5 números é " + m);
        }
        #endregion

        #region Exercicio9
        public static void Exercicio9()
        {
            double total = LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();

            double m = total / 10;
            Console.WriteLine("A média dos 10 números é " + m);
        }
        #endregion

        #region Exercicio10
        public static void Exercicio10()
        {
            Console.WriteLine("Caracter?");
            var a = Console.ReadLine();

            Console.WriteLine(a + " " + a + " " + a + "\n" 
                + a + " " + a + " " + a + "\n" 
                + a + " " + a + " " + a);
      
        }
        #endregion

        #region Exercicio11
        public static void Exercicio11()
        {
            Console.WriteLine("Nome do 1o produto?");
            var nome1 = Console.ReadLine();
            Console.WriteLine("Preço do 1o produto?");
            var preco1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade do 1o produto?");
            var quantidade1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nome do 2o produto?");
            var nome2 = Console.ReadLine();
            Console.WriteLine("Preço do 2o produto?");
            var preco2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade do 2o produto?");
            var quantidade2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nome do 3o produto?");
            var nome3 = Console.ReadLine();
            Console.WriteLine("Preço do 3o produto?");
            var preco3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade do 3o produto?");
            var quantidade3 = double.Parse(Console.ReadLine());

            double gasto1 = preco1 * quantidade1;
            double gasto2 = preco2 * quantidade2;
            double gasto3 = preco3 * quantidade3;

            double total = gasto1 + gasto2 + gasto3;

            Console.WriteLine("O produto " + nome1 + " teve um preço de " + gasto1);
            Console.WriteLine("O produto " + nome2 + " teve um preço de " + gasto2);
            Console.WriteLine("O produto " + nome3 + " teve um preço de " + gasto3);
            Console.WriteLine("A compra teve um total de " + total);
        }
        #endregion

        #region Exercicio21
        public static void Exercicio21()
        {
            Console.WriteLine("Diz-me algo que eu não saiba");
            var x = Console.ReadLine();
            Console.WriteLine("Eu já sabia que " + x);
        }
        #endregion

        #region Exercicio22
        public static void Exercicio22()
        {
            Console.WriteLine("Introduz dois números");
            var fstNum = Console.ReadLine();
            var sndNum = Console.ReadLine();
            Console.WriteLine("O primeiro número é " + fstNum + " e o segundo número é " + sndNum);
        }
        #endregion

        #region Exercicio23
        public static void Exercicio23()
        {
            Console.WriteLine("Introduz a temperatura");
            var temp = double.Parse(Console.ReadLine());

            var tempF = (temp * 9 / 5) + 32;
            var tempK = temp + 275.15;
            Console.WriteLine("A temperatura " + temp + " ºC é " + tempF + " ºF e " + tempK + " K");
        }
        #endregion

        #region Exercicio31
        public static void Exercicio31()
        {
            Console.WriteLine("Quantas horas?");
            var horas = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos minutos?");
            var minutos = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos segundos?");
            var segundos = double.Parse(Console.ReadLine());

            var total = (horas * 3600) + (minutos * 60) + segundos;
            Console.WriteLine(horas + " : " + minutos + " : " + segundos + 
                " é equivalente a " + total + " segundos.");
        }
        #endregion

        #region Exercicio32
        public static void Exercicio32()
        {
            Console.WriteLine("Qual é o raio");
            var raio = double.Parse(Console.ReadLine());

            var perimetro = CalcPerimetro(raio);
            var area = CalcArea(raio);
            Console.WriteLine("A área do circulo é " + area + " e o perímetro é " + perimetro);
        }
        public static double CalcPerimetro(double raio)
        {
            return (2 * Math.PI * raio);
        }
        public static double CalcArea(double raio)
        {
            return (Math.PI * raio * raio);
        }
        #endregion 
    }
}

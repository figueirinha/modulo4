using System;

namespace Ficha19
{
    public class Ficha19Solucao
    {
        #region Exercicio1
        public static string Exercicio1(double raio)
        {
            double area = Math.Round(Math.PI * Math.Pow(raio, 2), 2);
            double perimetro = Math.Round(2 * Math.PI * raio, 2);
            return $"A área é {area} e o perimetro {perimetro}";
        }
        #endregion 

        #region Exercicio2
        public static double Exercicio2(double num)
        {
            return Math.Ceiling(num);
        }
        #endregion 

        #region Exercicio3
        public static double Exercicio3(double num)
        {
            return Math.Floor(num);
        }
        #endregion 

        #region Exercicio4
        public static double Exercicio4(double num)
        {
            return Math.Round(num);
        }
        #endregion 

        #region Exercicio5
        public static double Exercicio5(double num)
        {
            return Math.Round(Math.Pow(num, 2), 2);
        }
        #endregion 

        #region Exercicio6
        public static double Exercicio6(double num)
        {
            return Math.Round(Math.Sqrt(num), 2);
        }
        #endregion 

        #region Exercicio7
        public static double Exercicio7(double num)
        {
            return Math.Round(Math.Log(num), 2);
        }
        #endregion 

        #region Exercicio8
        public static double Exercicio8(double num)
        {
            double radian = num * Math.PI / 180;
            return Math.Round(radian, 2);
        }
        #endregion 

        #region Exercicio9
        public static double Exercicio9(double num)
        {
            return Math.Abs(num);
        }
        #endregion 

        #region Exercicio10
        public static string Exercicio10(double num)
        {
            if (Math.Sign(num) == - 1)
            {
                return "The number is negative";
            }

            return "The number is positive";
        }
        #endregion 


    }
}

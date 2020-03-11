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

        }
        #endregion 


    }
}

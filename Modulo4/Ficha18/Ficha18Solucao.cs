using System;

namespace Recodme.Formacao.Exercicios.Ficha18
{
    public class Ficha18Solucao
    {
        #region Exercicio1
        public static void Exercicio1()
        {
            Console.WriteLine("Ano 1");
            int yearOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Ano 2");
            int yearTwo = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = yearOne; i <= yearTwo; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    count++;
                }
            }
            Console.WriteLine($"Entre {yearOne} e {yearTwo} existiram {count} anos bissextos.");
        }
        #endregion

        #region Exercicio2
        public static void Exercicio2()
        {
            Console.WriteLine("Dia:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Mês:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Ano:");
            int year = int.Parse(Console.ReadLine());

            try
            {            
                var date = new DateTime(year, month, day);
                Console.WriteLine(date.DayOfWeek);
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("A data inserida é inválida.");
            }                     
            
        }
        #endregion

        #region Exercicio3
        public static void Exercicio3()
        {
            var dateNow = DateTime.Now.Month;

            switch (dateNow)
            {
                case 1: Console.WriteLine("January"); break;
                case 2: Console.WriteLine("February"); break;
                case 3: Console.WriteLine("March"); break;
                case 4: Console.WriteLine("April"); break;
                case 5: Console.WriteLine("May"); break;
                case 6: Console.WriteLine("June"); break;
                case 7: Console.WriteLine("July"); break;
                case 8: Console.WriteLine("August"); break;
                case 9: Console.WriteLine("September"); break;
                case 10: Console.WriteLine("October"); break;
                case 11: Console.WriteLine("November"); break;
                case 12: Console.WriteLine("December"); break;
                default: Console.WriteLine("Data inválida"); break;
            }
        }
        #endregion

        #region Exercicio4
        public static void Exercicio4()
        {
            var dateNow = DateTime.Now.Month;

            if (dateNow == 2)
            {                
                Console.WriteLine("Fevereiro tem 28 ou 29 dias");
            }
            else if (dateNow == 1 || dateNow == 3 || dateNow == 5 || dateNow == 7 || dateNow == 8 || dateNow == 10 || dateNow == 12)
            {
                Console.WriteLine("O presente mês tem 31 dias");
            }
            else
            {
                Console.WriteLine("O presente mês tem 30 dias.");
            }
        }
        #endregion 

        #region Exercicio5
        public static void Exercicio5()
        {
            Console.WriteLine("Amanhã será " + DateTime.Now.AddDays(1).ToString("dd/MM/yyyy"));
        }
        #endregion 

        #region Exercicio6
        public static void Exercicio6()
        {
            Console.WriteLine("Ontem foi " + DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy"));

        }
        #endregion 

        #region Exercicio7
        public static void Exercicio7()
        {
            var date = new DateTime(2010, 3, 22);
            var newDate = date.ToString("dd/MM/yyyy");
            Console.WriteLine(newDate);
        }
        #endregion 

        #region Exercicio8
        public static void Exercicio8()
        {
            var date = "01/02/2020";
            var newDate = DateTime.Parse(date);
            Console.WriteLine(newDate);
        }
        #endregion 

        #region Exercicio9
        public static void Exercicio9()
        {
            var date = new DateTime(2020, 2, 23, 18, 23, 20);
            Console.WriteLine(date.ToString("dd/MM/yyyy HH:mm:ss"));
        }
        #endregion 

        #region Exercicio10
        public static void Exercicio10()
        {
            var today = DateTime.Now;
            Console.WriteLine($"Hoje, {today.DayOfWeek}, dia {today.Day} do mês {today.Month} de {today.Year}," +
                $" às {today.Hour} hora(s), {today.Minute} minuto(s) e {today.Second} segundos, estudei.");
        }
        #endregion 
    }
}

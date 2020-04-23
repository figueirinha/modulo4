using Ficha22.Enums;
using System;

namespace Ficha22
{
    public class Ficha22Solucao
    {
        public static void DateAndPrice(int km, Urgency urge, Dimension dim, Transport trans)
        {
            var datenow = DateTime.Now;
            int treatment = 1 + urge.HoursByUrgency();
            var shippingDay = datenow.AddHours(treatment);
            var finalPrice = dim.PriceBySize() + dim.PriceBySize()*urge.PriceByUrgency();
            var travellingHours = km.HoursBasedOnKm() * trans.HourByTransport();

            int i = 1;
            while (shippingDay.Hour != 17)
            {
                shippingDay = shippingDay.AddHours(1);
                i++;
            }
            
            var arrivelDate = shippingDay.AddHours(travellingHours);

            if (arrivelDate.DayOfWeek.ToString() == "Saturday") arrivelDate = arrivelDate.AddDays(2);
            if (arrivelDate.DayOfWeek.ToString() == "Sunday") arrivelDate = arrivelDate.AddDays(1);
                                
            // se for antes das 9 chega nesse dia (não se faz nada)
            //Se for depois das 20 e antes das 00, chega no dia seguinte entre as 9 e as 12.
            if (arrivelDate.Hour > 20 && arrivelDate.Hour <= 23) arrivelDate = arrivelDate.AddHours(12);

            Console.WriteLine($"Your order, with a total price of {finalPrice} euro(s), will arrive approximately on {arrivelDate.ToString("dd/MM/yyyy")}");

        }
    }
}

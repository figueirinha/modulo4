using Recodme.Formacao.Exercicios.Ficha22.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Formacao.Exercicios.Ficha22
{
    public static class ExtensionMethods
    {
        public static double HoursBasedOnKm(this int km)
        {
            double hours;
            if (km >= 0) hours = (km / 10);
            else hours = 0;
            return hours;
        }
        public static double PriceBySize(this Dimension dim)
        {
            double price;
            if (dim == Dimension.XS) price = 2.5;
            else if (dim == Dimension.S) price = 5;
            else if (dim == Dimension.M) price = 10;
            else if (dim == Dimension.L) price = 20;
            else if (dim == Dimension.XL) price = 40;
            else price = 80;
            return price;
        }
        public static double PriceByUrgency(this Urgency urge)
        {
            double pricePercentage;
            if (urge == Urgency.Green) pricePercentage = 0;
            else if (urge == Urgency.Yellow) pricePercentage = 0.25;
            else if (urge == Urgency.Orange) pricePercentage = 0.50;
            else pricePercentage = 1;
            return pricePercentage;
        }
        public static int HoursByUrgency(this Urgency urge)
        {
            int hours;
            if (urge == Urgency.Green) hours = 24;
            else if (urge == Urgency.Yellow) hours = 12;
            else if (urge == Urgency.Orange) hours = 6;
            else hours = 3;
            return hours;
        }
        public static double HourByTransport(this Transport trans)
        {
            double hours;
            if (trans == Transport.Land) hours = 1;
            else if (trans == Transport.Sea) hours = 0.5;
            else hours = 0.25;
            return hours;
        }
       
    }
}

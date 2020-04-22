using Ficha22.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha22
{
    public static class ExtensionMethods
    {
        public static double HoursBasedOnKm(this int km)
        {
            if (km >= 0) return (km / 10);
            else return 0;
        }
        public static double PriceBySize(this Dimension dim)
        {
            if (dim == Dimension.XS) return 2.5;
            else if (dim == Dimension.M) return 5;
            else if (dim == Dimension.L) return 20;
            else if (dim == Dimension.XL) return 40;
            else return 80;
        }
        public static double PriceByUrgency(this Urgency urge)
        {
            return 0;
        }
    }
}

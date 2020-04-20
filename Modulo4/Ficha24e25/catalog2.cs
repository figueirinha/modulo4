using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha24
{
    /// <summary>
    /// Class catalog with properties get set and constructor example for a product with name price and its type.
    /// </summary>
    class catalog2
    {
        
        // constructor example (1st one empty)      
        public catalog2()
        {

        }
        public catalog2(string name, double price, string typeOf)
        {
            Name = name;
            Price = price;
            TypeOf = typeOf;
        }

        // properties
        private string name;
        private double price;
        private string typeOf;

        // methods get set
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value)) name = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0) price = value;
            }
        }
        public string TypeOf
        {
            get
            {
                return typeOf;
            }
            set
            {
                if (!string.IsNullOrEmpty(value)) typeOf = value;
            }
        }
    }
}

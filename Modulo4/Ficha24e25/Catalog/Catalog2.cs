using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Formacao.Exercicios.Ficha24e25.Catalog
{
    /// <summary>
    /// Class catalog with properties get set and constructor example for a product with name price and its type.
    /// </summary>
    public class Catalog2
    {

        // constructor example 
        public Catalog2(string name, double price, string typeOf)
        {
            this.name = name;
            this.price = price;
            this.typeOf = typeOf;
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

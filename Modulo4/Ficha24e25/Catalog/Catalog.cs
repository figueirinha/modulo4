using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Formacao.Exercicios.Ficha24e25.Catalog
{
    /// <summary>
    /// Class catalog for a product with a name price and its type
    /// </summary>
    class Catalog
    {
        // properties
        private string name;
        private double price;
        private string typeOf;

        // methods
        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name)) this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetPrice(double price)
        {
            if (price > 0) this.price = price;
        }
        public double GetPrice()
        {
            return price;
        }
        public void SetTypeOf(string typeOf)
        {
            if (!string.IsNullOrEmpty(typeOf)) this.typeOf = typeOf;
        }
        public string GetTypeOf()
        {
            return typeOf;
        }
    }
}

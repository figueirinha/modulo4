using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha24
{
    /// <summary>
    /// Class vehicle with properties get set and a constructor example for the brand, model, registration year and the gears options.
    /// </summary>
    class vehicle2
    {
        // cosntrutor example (1st empty)
        public vehicle2()
        {

        }
        public vehicle2(string brand, string model, int registrationYear)
        {
            Brand = brand;
            Model = model;
            RegistrationYear = registrationYear;
            Gear = Gears.reverse; // we going back
        }

        // properties
        private string brand;
        private string model;
        private int registrationYear;
        //private bool isTurnedOn;
        //private bool isSpeeding;
        //private Gears gear;

        // methods get set
        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                if (!string.IsNullOrEmpty(value)) brand = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (!string.IsNullOrEmpty(value)) model = value;
            }
        }
        public int RegistrationYear
        {
            get
            {
                return registrationYear;
            }
            set
            {
                if (value > 0 && value <= DateTime.UtcNow.Year) registrationYear = value;
            }
        }
        public bool IsTurnedOn { get; set; }
        
        public bool IsSpeeding { get; set; }
        
        public Gears Gear { get; set; }
    }
}

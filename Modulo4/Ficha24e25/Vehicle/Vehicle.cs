using System;
using System.Collections.Generic;
using System.Text;
using Ficha24e25.EnumGears;

namespace Ficha24e25.Vehicle
{
    /// <summary>
    /// Class vehicle for the brand, model, registration year and the gears options.
    /// </summary>
    class Vehicle
    {
        // properties
        private string brand;
        private string model;
        private int registrationYear;
        private bool isTurnedOn;
        private bool isSpeeding;
        private Gears gear;

        // methods
        public void SetBrand(string brand)
        {
            if (!string.IsNullOrEmpty(brand)) this.brand = brand;
        }
        public string GetBrand()
        {
            return brand;
        }
        public void SetModel(string model)
        {
            if (!string.IsNullOrEmpty(model)) this.model = model;
        }
        public string GetModel()
        {
            return model;
        }
        public void SetRegistrationYear(int registrationYear)
        {
            if (registrationYear > 0 && registrationYear <= DateTime.UtcNow.Year) this.registrationYear = registrationYear;
        }
        public int GetRegistrationYear()
        {
            return registrationYear;
        }
        public void SetIsTurnedOn(bool isTurnedOn)
        {
            this.isTurnedOn = isTurnedOn;
        }
        public bool GetIsTurnedOn()
        {
            return isTurnedOn;
        }
        public void SetIsSpeeding(bool isSpeeding)
        {
            this.isSpeeding = isSpeeding;
        }
        public bool GetIsSpeeding()
        {
            return isSpeeding;
        }
        public void SetGear(Gears gear)
        {
            this.gear = gear;
        }

        public Gears GetGear()
        {
            return gear;
        }
    }
}

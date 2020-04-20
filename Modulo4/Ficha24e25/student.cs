using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha24
{
    /// <summary>
    /// Class student with properties get set and construtor example for a student with name, age, best grade, hours of sleep and amount of coffee
    /// </summary>
    class student
    {
        // construtor example (1st empty)
        public student()
        {

        }
        public student(string name, int age, double bestGrade, int hoursOfSleep, int amountOfCoffee)
        {
            Name = name;
            Age = age;
            BestGrade = bestGrade;
            HoursOfSleep = hoursOfSleep;
            AmountOfCoffee = amountOfCoffee;
        }

        // properties
        private string name;
        private int age;
        private double bestGrade;
        private int hoursOfSleep;
        private int amountOfCoffee;

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
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0) age = value;  
            }
        }
        public double BestGrade
        {
            get
            {
                return bestGrade;
            }
            set
            {
                if (value >= 0 && value <= 20) bestGrade = value;
            }
        }
        public int HoursOfSleep
        {
            get
            {
                return hoursOfSleep;
            }
            set
            {
                if (value >= 0) hoursOfSleep = value;
            }
        }
        public int AmountOfCoffee
        {
            get
            {
                return amountOfCoffee;
            }
            set
            {
                if (value > 0) amountOfCoffee = value;
            }
        }
    }
}

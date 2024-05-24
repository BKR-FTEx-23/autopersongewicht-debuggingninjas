using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gewichtsberechnung_1
{
    public class Person
    {
        private double gewicht;

        public Person(double gewicht)
        {
            this.gewicht = gewicht;
        }

        public double GetGewicht()
        {
            return gewicht;
        }
    }
}
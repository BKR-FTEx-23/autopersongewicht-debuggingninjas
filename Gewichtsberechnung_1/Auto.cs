using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gewichtsberechnung_1
{
    public class Auto
    {
        private List<Person> personen;
        private double autoGewicht;
        private double fuehrerscheinID;

        public Auto(double autoGewicht, double fuehrerscheinID)
        {
            this.autoGewicht = autoGewicht;
            personen = new List<Person>();
            this.fuehrerscheinID = fuehrerscheinID;
        }

        public void Hinzufuegen(Person p)
        {
            personen.Add(p);
        }

        public bool Entfernen(Person p)
        {
            Person zuEntfernendePerson = null;
            foreach (var person in personen)
            {
                if (person.GetGewicht() == p.GetGewicht())
                {
                    zuEntfernendePerson = person;
                    break;
                }
            }
            if (zuEntfernendePerson != null)
            {
                return personen.Remove(zuEntfernendePerson);
            }
            return false;
        }

        public double Gesamtgewicht()
        {
            double gesamtGewicht = autoGewicht;
            foreach (Person p in personen)
            {
                gesamtGewicht += p.GetGewicht();
            }
            return gesamtGewicht;
        }


    }
}
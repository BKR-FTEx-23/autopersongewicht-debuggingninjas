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

        public Auto(double autoGewicht)
        {
            this.autoGewicht = autoGewicht;
            personen = new List<Person>();
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

        public int AnzahlPersonen()
        {
            return personen.Count;
        }


    }
}
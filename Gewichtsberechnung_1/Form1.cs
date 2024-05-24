using System;

namespace Gewichtsberechnung_1
{
    public partial class Form1 : Form
    {
        private Auto auto;
        public Form1()
        {
            InitializeComponent();
            auto = new Auto(1500); // Gewicht des Autos in kg
        }

        private void btnPersonHinzufügen_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtGewichtPerson.Text, out double gewicht))
            {
                Person person = new Person(gewicht);
                auto.Hinzufuegen(person);
                lstPersonen.Items.Add(gewicht);
                AktualisiereGesamtgewicht();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie ein gültiges Gewicht ein.");
            }
            
        }

        private void btnAusgewähltePersonentfernen_Click(object sender, EventArgs e)
        {
            if (lstPersonen.SelectedItem != null)
            {
                double gewicht = (double)lstPersonen.SelectedItem;
                Person person = new Person(gewicht);
                bool entfernt = auto.Entfernen(person);
                if (entfernt)
                {
                    lstPersonen.Items.Remove(lstPersonen.SelectedItem);
                    AktualisiereGesamtgewicht();
                }
                else
                {
                    MessageBox.Show("Person konnte nicht entfernt werden.");
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Person aus der Liste aus.");
            }

        }
        private void AktualisiereGesamtgewicht()
        {
            txtAutoGewicht.Text = "Gesamtgewicht: " + auto.Gesamtgewicht() + " kg";
        }
    }
}

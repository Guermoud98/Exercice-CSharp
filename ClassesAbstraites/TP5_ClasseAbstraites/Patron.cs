using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_ClasseAbstraites
{
    internal class Patron : Employe 
    {
        private static double CA; //chiffre d'affaire est commun entre les patrons
        private double salaireAnnuel;
        private double pourcentage;
        public Patron(double pourcentage, string nom, string prenom, DateTime d):base(nom, prenom, d)
        {
            this.pourcentage = pourcentage;
        }
        public override double CalculerSalaire()
        {
            salaireAnnuel = CA * (pourcentage/100);
            return salaireAnnuel;
        }
    }
}

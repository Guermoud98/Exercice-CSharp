using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_ClasseAbstraites
{
    internal class Ouvrier : Employe 
    {
        private DateTime dateEntree;
        private int smig = 2500;
        private double salaireMensuel;
        public Ouvrier(DateTime dateEntree, string nom, string prenom) : base(nom, prenom, dateEntree)
        {
            this.dateEntree = dateEntree;
        }
        public override double CalculerSalaire()
        {

            salaireMensuel = smig + (DateTime.Now.Year - dateEntree.Year)*100;
            if(salaireMensuel < smig*2)
            {
                return salaireMensuel;
            }
            return -1; 
        }
        public override string ToString()
        {
            return base.ToString() + ", dateENtree: " + dateEntree + ", smig: " + smig + ", salaireMens: " + salaireMensuel;
        }
    }
}

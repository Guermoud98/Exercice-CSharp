using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_ClasseAbstraites
{
    internal class Cadre : Employe
    {
        private int indice;
        private double salaireMensuel;
        public Cadre(int indice, string nom, string prenom, DateTime d): base(nom, prenom, d)
        {
            this.indice = indice;
        }
        public override double CalculerSalaire()
        {
            switch (indice)
            {
                case 1:
                    salaireMensuel = 13000;
                    break;
                case 2:
                    salaireMensuel = 15000;
                    break;
                case 3:
                    salaireMensuel = 17000;
                    break;
                case 4:
                    salaireMensuel = 20000;
                    break;
                default:
                    Console.WriteLine("vérifier l'indice (entre 1 et 4)");
                    break;
            }
            return salaireMensuel;
        }
        public override string ToString()
        {
            return base.ToString + ", indice: " + indice + ", salaireMens: " + salaireMensuel; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TP5_ClasseAbstraites
{
    abstract internal class Employe
    {
        protected static int matr;
        protected int nbr = 0;
        protected string nom;
        protected string prenom;
        protected DateTime ddn;
        public Employe(string nom, string prenom,DateTime ddn)
        {
            nbr++;
            matr = nbr;
            this.nom = nom;
            this.prenom = prenom;
            this.ddn = ddn;
        }
        public int Matr
        {
            get { return matr; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom =  value; }
        }
        public  DateTime Ddn
        {
            get { return ddn; }
            set { ddn = value; }
        }
        public override string ToString()
        {
            return "[matr: " + matr + ", nom: " + nom + ", prenom: " + prenom + ", dateNaissance: " + ddn.Year + "/" + ddn.Month + "/" + ddn.Day + "]" ;

        }
        public abstract double CalculerSalaire();





    }
}

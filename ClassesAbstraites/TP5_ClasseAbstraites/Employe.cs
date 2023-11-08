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
        protected DateTime d;
        public Employe(string nom, string prenom,DateTime d)
        {
            nbr++;
            matr = nbr;
            this.nom = nom;
            this.prenom = prenom;
            this.d = d;
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
        public  DateTime D
        {
            get { return d; }
            set { d = value; }
        }
        public override string ToString()
        {
            return "[matr: " + matr + ", nom: " + nom + ", prenom: " + prenom + ", dateNaissance: " + d + "]";

        }
        public abstract double CalculerSalaire();





    }
}

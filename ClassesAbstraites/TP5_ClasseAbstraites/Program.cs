using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_ClasseAbstraites
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cadre c = new Cadre(1, "guer", "maria", new DateTime(1998, 01, 20));
            Ouvrier o = new Ouvrier(new DateTime(1997, 02, 04), new DateTime(2020, 03, 01), "Naji", "Najlae");
            Patron p = new Patron(10, "Malek", "Mars", new DateTime(1990, 06, 22));
            //CA:
            p.setCA(10000);
            //CalculerSalaire for c
            c.CalculerSalaire();
            //CalculerSalaire for o
            o.CalculerSalaire();
            //CalculerSalaire for p
            p.CalculerSalaire();
            //Displaying informations:
            Console.WriteLine(c);
            Console.WriteLine(o);
            Console.WriteLine(p);



        }
    }
}

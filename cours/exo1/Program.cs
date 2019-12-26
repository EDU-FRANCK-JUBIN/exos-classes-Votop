using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire compte = new CompteBancaire("Vincent Claveau", 1337.19, "euros");
            Console.WriteLine("Création du compte n°" + CompteBancaire.NbCompte);
            Console.WriteLine(compte.Decrire());

            compte.Crediter(2000);
            Console.WriteLine("Crédit de 2000 euros");
            Console.WriteLine(compte.Decrire());

            compte.Debiter(1000);
            Console.WriteLine("Débit de 1000 euros");
            Console.WriteLine(compte.Decrire());

            Console.ReadLine();
        }
    }
}

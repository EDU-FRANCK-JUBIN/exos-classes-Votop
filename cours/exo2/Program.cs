using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte compte1 = new Compte(new Client("ABC123", "Dubois", "Robert"));
            Console.WriteLine("Creation compte1");
            Console.WriteLine(compte1.Afficher() + Environment.NewLine);

            Compte compte2 = new Compte(new Client("XYZ", "Coord", "Pascal", "0667645545058"));
            Console.WriteLine("Creation compte2");
            Console.WriteLine(compte2.Afficher() + Environment.NewLine);

            compte1.Crediter(1337);
            Console.WriteLine("Credit 1337 euros sur compte1");
            Console.WriteLine(compte1.Afficher() + Environment.NewLine);

            compte1.Crediter(compte2, 337);
            Console.WriteLine("Credit 337 euros du compte1 vers compte2");
            Console.WriteLine(compte1.Afficher());
            Console.WriteLine(compte2.Afficher() + Environment.NewLine);

            compte1.Debiter(compte2, 100);
            Console.WriteLine("Debit 100 euros du compte2 vers compte1");
            Console.WriteLine(compte1.Afficher());
            Console.WriteLine(compte2.Afficher() + Environment.NewLine);

            Console.ReadLine();
        }
    }
}

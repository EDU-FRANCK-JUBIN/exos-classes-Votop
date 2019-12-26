using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Article.TauxTVA = 20;
            Console.WriteLine("La TVA est fixée à " + Article.TauxTVA + "%" + Environment.NewLine);

            Article article1 = new Article("ABC123", "Apple MacBook Pro", 1790.50);
            Console.WriteLine("Ajout d'un article");
            Console.WriteLine(article1.Afficher() + Environment.NewLine);

            Console.WriteLine("Le prix TTC est " + article1.CalculerPrixTTC() + Environment.NewLine);

            Article article2 = new Article(article1);
            Console.WriteLine("Copie article1 et affichage article2");
            Console.WriteLine(article2.Afficher() + Environment.NewLine);

            Console.ReadLine();
        }
    }
}

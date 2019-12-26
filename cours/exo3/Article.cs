using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo3
{
    class Article
    {
        private string reference;
        private string designation;
        private double prixHT;
        private static double tauxTVA;

        public string Reference { get => reference; set => reference = value; }
        public string Designation { get => designation; set => designation = value; }
        public double PrixHT { get => prixHT; set => prixHT = value; }
        public static double TauxTVA { get => tauxTVA; set => tauxTVA = value; }

        public Article()
        {
        }

        public Article(string reference, string designation, double prixHT)
        {
            this.reference = reference;
            this.designation = designation;
            this.prixHT = prixHT;
        }

        public Article(string reference, string designation)
        {
            this.reference = reference;
            this.designation = designation;
        }

        public Article(Article article)
        {
            this.reference = article.reference;
            this.designation = article.designation;
            this.prixHT = article.prixHT;
        }

        public double CalculerPrixTTC()
        {
            return PrixHT + (PrixHT * TauxTVA / 100);
        }

        public string Afficher()
        {
            return "Reference: " + this.reference + " | Designation: " + this.designation + " | PrixHT: " + this.prixHT;
        }
    }
}

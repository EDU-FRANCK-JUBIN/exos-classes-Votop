using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours
{
    class CompteBancaire
    {
        private string titulaire;
        private double solde;
        private string devise;
        private static uint nbCompte = 0;

        public CompteBancaire(string titulaire, double solde, string devise)
        {
            this.titulaire = titulaire;
            this.solde = solde;
            this.devise = devise;
            nbCompte++;
        }

        public string Devise { get => devise; set => devise = value; }
        public double Solde { get => solde; set => solde = value; }
        public string Titulaire { get => titulaire; set => titulaire = value; }
        public static uint NbCompte { get => nbCompte; set => nbCompte = value; }

        public void Crediter(double montant)
        {
            this.solde += montant;
        }

        public void Debiter(double montant)
        {
            this.solde -= montant;
        }

        public string Decrire()
        {
            return titulaire + " - solde : " + solde + " " + devise;
        }
    }
}

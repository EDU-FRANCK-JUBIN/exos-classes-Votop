using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2
{
    class Compte
    {
        private double solde;
        private uint code;
        private Client proprietaire;
        private static uint total = 0;

        public double Solde { get => solde; }
        public uint Code { get => code; }
        public Client Proprietaire { get => proprietaire; set => proprietaire = value; }
        public static uint Total { get => total; }

        public Compte(Client proprietaire)
        {
            this.proprietaire = proprietaire;
            this.solde = 0;
            this.code = Compte.total++;
        }

        public void Crediter(double montant)
        {
            this.solde += montant;
        }

        public bool Crediter(Compte compte, double montant)
        {
            if (this.solde < montant)
                return false;
            this.solde -= montant;
            compte.solde += montant;
            return true;
        }

        public void Debiter(double montant)
        {
            this.solde += montant;
        }

        public bool Debiter(Compte compte, double montant)
        {
            if (compte.solde < montant)
                return false;
            compte.solde -= montant;
            this.solde += montant;
            return true;
        }

        public string Afficher()
        {
            return "#" + this.code + " - proprietaire:  [" + this.proprietaire.Afficher() + "] | solde: " + this.solde;
        }

        public uint NbCompte()
        {
            return Compte.total;
        }
    }
}

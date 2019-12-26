using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2
{
    class Client
    {
        private string cin;
        private string nom;
        private string prenom;
        private string tel;

        public Client(string cin, string nom, string prenom, string tel)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
        }

        public Client(string cin, string nom, string prenom)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
        }

        public string Cin { get => cin; set => cin = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Tel { get => tel; set => tel = value; }

        public string Afficher()
        {
            return "CIN: " + this.cin + " | nom: " + this.nom + " | prenom: " + this.prenom + " | tel: " + this.tel;
        }
    }
}

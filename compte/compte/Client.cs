using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compte
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adresse; 
       public Client(string n , string p , string ad)
        {
            this.nom = n;
            this.prenom = p;
            this.adresse = ad; 

        }
        public String affichCl()
        {
            String S = this.nom+this.prenom+this.adresse.ToString();

            return S;
        }


    }
}

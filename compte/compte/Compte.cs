using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace compte
{
    class Compte
    {
        private static int cpt = 0;
        private int numc;
        private readonly Client tutulaire;
        private MAD Solde;
      static  private MAD plafond =new MAD(1000); 
       public Compte (MAD s, Client t)
        {
           
            this.numc = cpt++;
            this.Solde = s;
            this.tutulaire = t; 
        }
        public bool Créditer(MAD mt)
        {
         
                this.Solde.ajouter(mt);

                return true; 
        }

        public bool debiter(MAD mt)
        {
            if(mt.comparer(plafond)==false && mt.comparer(this.Solde) == false)
            {
                this.Solde.dep(mt);

                return true;

            }

            else
            {
                Console.WriteLine(" votre solde insuffisant ");
                return false;
            }
        }

         public void consulter()
        {
            Console.Write("le num : " + numc + " tutulaire : " + tutulaire.affichCl()+ " le solde : " + Solde.affichMAD()+ " plafond est : " + plafond.affichMAD());
        }
    }
}

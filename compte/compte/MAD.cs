using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compte
{
    class MAD
    {
        private double valeurs;
       
       public MAD(double v=0)
        {
            this.valeurs = v;
        }
         public bool comparer(MAD val)
        {
            if (this.valeurs >= val.valeurs)
            {
                return true;
            }
            return false;
        }

        public MAD ajouter(MAD mt)
        {
            MAD s = new MAD(); 
            s.valeurs = this.valeurs+mt.valeurs;
            return s;
        }

        public MAD dep(MAD mt)
        {
            MAD s = new MAD();
            s.valeurs = this.valeurs - mt.valeurs;
            return s;

        }
        public String affichMAD()
        {
            String S = this.valeurs.ToString();

            return S;
        }
    

    }


}

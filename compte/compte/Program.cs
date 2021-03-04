using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compte
{
    class Program
    {
        static void Main(string[] args)
        {
            Client C1 = new Client("yassine", "moustamid",  " oulfa,casa");
            MAD val1 = new MAD(2000);
            Compte Cp1 = new Compte(val1,C1);

            Cp1.consulter();

            Console.ReadKey();
        }
    }
}

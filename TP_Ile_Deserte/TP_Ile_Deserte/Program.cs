using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Ile_Deserte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enfant e = new Enfant();
            Console.WriteLine(e);
            Travailleur travailleur = new Travailleur();
            Console.WriteLine(travailleur);
            TravailleurFaineant f = new TravailleurFaineant();
            Console.WriteLine(f);
            Chat chat = new Chat();
            Console.WriteLine(chat);
            

        }
    }
}

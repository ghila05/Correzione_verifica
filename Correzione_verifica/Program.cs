using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correzione_verifica
{
    class Program
    {
        static void Main(string[] args)
        {
            Conto c1, c2;
            c1 = new Conto("123","GhilardiN","Intesa San Paolo");
            c2 = new Conto("123", "GhilardiN", "Intesa San Paolo");

            c1.Deposita(100);
            c1.Preleva(50);
            Console.WriteLine("saldo c1:"+c1.saldo);

            c2.Deposita(1000);
            c2.Preleva(2000);
            Console.WriteLine("saldo c2:"+c2.saldo);

            Carta card1;
            Carta card2;

            

           


           


        }
        


    }
}

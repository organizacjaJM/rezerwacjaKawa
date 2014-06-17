using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegacjeGeneryczne
{
    class Program
    {
        delegate void Delegacja(string s);

        static void Main(string[] args)
        {

            // delegacje void z max 16 argumentami typowymi. Liczba parematerow musi buyc taka sama jak typów
            Action<string, string> delAction   = (p, q) => Console.WriteLine("Czy działa: " + p + q);
            delAction("ala", " ala kota");

            Func<string, string> delFunc = p => p.ToUpper();

            Console.WriteLine(delFunc("csharp"));


        }
    }
}

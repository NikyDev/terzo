using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venturi.Nicolas._4J.datadelgiorno.models;

namespace Venturi.Nicolas._4J.datadelgiorno
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Data d = new Data(1, 1, 2003);
            Data r = new Data(2, 6, 2006);
            Data z = new Data();

            d.aggiungigiorni(95,d);
            //d.togligiorni(18, d);
            //Console.WriteLine(d.giorno + "/" + d.mese + "/" + d.anno);
            Console.WriteLine(d == r);
            Console.WriteLine(d > r);
            s= d.ToString();
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}

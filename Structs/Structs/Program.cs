using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        public struct Account
        {
            public string name;
            public string cpr;
            public double saldo;
        }
        static void Main(string[] args)
        {
            //Opgave 1
            Account p1;
            p1.name = "Frederik H K";
            p1.cpr = "2203891567";
            p1.saldo = 22345.13;

            Account p2;
            p2.name = "Benjamin G D";
            p2.cpr = "1506023359";
            p2.saldo = 1598.5435;

            Account p3;
            p3.name = "Franz F";
            p3.cpr = "0501671113";
            p3.saldo = 77668.2314;
            /*
            Console.WriteLine("Name: " + p1.name + " CPR: " + p1.cpr + " Saldo: " + p1.saldo);
            Console.WriteLine("Name: " + p2.name + " CPR: " + p2.cpr + " Saldo: " + p2.saldo);
            Console.WriteLine("Name: " + p3.name + " CPR: " + p3.cpr + " Saldo: " + p3.saldo);
            */
            Console.WriteLine(Udskriv(p1));
            Console.WriteLine(Udskriv(p2));
            Console.WriteLine(Udskriv(p3));

           
        }
        public static string Udskriv(Account dataUdtræk)
        {
            return "Name: " + dataUdtræk.name + " CPR: " + dataUdtræk.cpr + " Saldo: " + dataUdtræk.saldo;
        }
    }
}

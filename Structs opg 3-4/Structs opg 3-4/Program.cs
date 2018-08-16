using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_opg_3_4
{
    class Program
    {
        public struct Beer
        {
            public string Fabrikant;
            public string Type;
            public string Procent;
            public string Volumen;
        }
        static void Main(string[] args)
        {
            Beer b1;
            b1.Fabrikant = "Carlsberg";
            b1.Type = "Classic";
            b1.Procent = "6.3%";
            b1.Volumen = "330ML";

            Console.WriteLine(Udskriv(b1));

        }
        public static string Udskriv(Beer udskrivdata)
        {
            return "Fabrikant: " + udskrivdata.Fabrikant +
                "\nType: " + udskrivdata.Type +
                "\nProcent: " + udskrivdata.Procent +
                "\nVolumen: " + udskrivdata.Volumen;
        }
    }
}

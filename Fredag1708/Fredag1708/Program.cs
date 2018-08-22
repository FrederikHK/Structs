using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fredag1708
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Hvad hedder du? :");
            char[] schar = { ' ' };
            name = Console.ReadLine().Trim();
            string[] splitName = name.Split(schar, StringSplitOptions.RemoveEmptyEntries);
            string totalName = "";
            foreach (string xname in splitName)
            {
                totalName += UpperandLower(xname) + " "; //Join the names
               
            }
            Console.WriteLine(totalName.TrimEnd());
            //Here is our function(method because it's placed inside of the class - Main)
            string UpperandLower(string iname)
            {
                if (iname.Length != 0)
                {
                    return iname.Substring(0, 1).ToUpper() + iname.Substring(1).ToLower();
                }
                else
                {
                    return "";
                }
            }

        }
    }
}

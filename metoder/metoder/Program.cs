using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoder
{
    
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            string totalPerson = "";
            string person;
            string testPerson = "";
            char[] schar = { ' ' };
            List<string> stringList = new List<string>();
            List<string> aliasList = new List<string>();
            Dictionary<string, int> newDictionary = new Dictionary<string, int>();
            
            do
            {
                Console.WriteLine("Vælg om du vil: \n'a' Indsætte ny person eller \n'b' Printe listen ud med personer.\n'q' For at afslutte");

                string svar = Console.ReadLine();
                switch (svar)
                {
                    case "a":
                        
                        Console.Write("Indtast venligst dit navn: ");
                        person = Console.ReadLine().Trim();
                        string[] splitName = person.Split(schar, StringSplitOptions.RemoveEmptyEntries);
                      
                        totalPerson = "";
                        
                        foreach (string xpersons in splitName)
                        {
                            if (xpersons != splitName[splitName.Length - 1])
                            {
                                testPerson += Persons(xpersons) + " ";
                            }
                            else
                            {
                                break;
                            }
                            
                        }
                        string alias = splitName[0].Substring(0, 1) + splitName[splitName.Length - 1].Substring(0, 1);
                        totalPerson = Persons(splitName[splitName.Length - 1]) + ", " + testPerson + "dit alias er: " + alias;
                        stringList.Add(totalPerson.TrimEnd());
                        if (newDictionary.ContainsKey(alias))
                        {
                            newDictionary[alias]++;
                        }
                        else
                        {
                            newDictionary.Add(alias, 1);
                        }
                        break;

                    case "b":
                        stringList.Sort();
                        foreach (var element in stringList)
                        {
                                Console.WriteLine(element);
                        }
                        foreach (var newitem in newDictionary)
                        {
                            Console.WriteLine(newitem);                        
                        }

                        break;

                    case "q":
                        loop = false;
                        break;
                }
                
            } while (loop);
        }
        public static string Persons(string xName)
        {
            if (xName.Length != 0)
            {
                return xName.Substring(0, 1).ToUpper() + xName.Substring(1).ToLower();
            }
            else
            {
                return "";
            }
        }

    }
    

}

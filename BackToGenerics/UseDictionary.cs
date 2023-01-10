using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToGenerics
{
    public class UseDictionary
    {
        public static void UseMyDictionary()
        {
            // Populate using Add() method
            Dictionary<string, Person> peopleA = new Dictionary<string, Person>();
            peopleA.Add("Homer", new Person
            {
                FirstName = "Homer",
                LastName = "Simpson",
                Age = 47
            });

            peopleA.Add("Marge", new Person
            {
                FirstName = "Marge",
                LastName = "Simpson",
                Age= 45
            });

            peopleA.Add("Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });
            // Get Homer.
            Person homer = peopleA["Homer"];
            Console.WriteLine(homer);






            // Populate with initialization syntax.
            Dictionary<string, Person> peopleB = new Dictionary<string, Person>()
             {
             { "Homer", new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 } },
             { "Marge", new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 } },
             { "Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 } }
             };
                        // Get Lisa.
            Person lisa = peopleB["Lisa"];
            Console.WriteLine(lisa);




            // Populate with dictionary initialization syntax.
            Dictionary<string, Person> peopleC = new Dictionary<string, Person>()
            {
                ["Homer"] = new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 },
                ["Marge"] = new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 },
                ["Lisa"] = new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 }
            };

            Person marge = peopleC["Marge"];
            Console.WriteLine(marge);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToGenerics
{
    internal class UseGenericsList
    {

        //Here is a short list of the benefits generic
        //containers provide over their nongeneric counterparts:
        //•	 Generics provide better performance because they do not result in boxing or
        //unboxing penalties when storing value types.
        //•	 Generics are type-safe because they can contain only the type of type you specify.
        //•	 Generics greatly reduce the need to build custom collection types because you
        //specify the “type of type” when creating the generic container


        //Only classes, structures, interfaces, and delegates can be written generically; enum types cannot.



        public static void myGenerics()
        {
            Console.WriteLine("***** Fun with Generics *****\n");
            // This List<> can hold only Person objects.
            List<Person> morePeople = new List<Person>();
            morePeople.Add(new Person("Frank", "Black", 50));

            Console.WriteLine(morePeople[0]);

            // This List<> can hold only integers.
            List<int> moreInts = new List<int>();
            moreInts.Add(10);

            moreInts.Add(2);

            int sum = moreInts[0] + moreInts[1];
            // Compile-time error! Can't add Person object
            // to a list of ints!
            // moreInts.Add(new Person());
        }


        public static void AnotherGenericMethod()
        {
            // Make a List of Person objects, filled with
            // collection/object init syntax.
            List<Person> people = new List<Person>()
             {
             new Person {FirstName= "Homer", LastName="Simpson", Age=47},
             new Person {FirstName= "Marge", LastName="Simpson", Age=45},
             new Person {FirstName= "Lisa", LastName="Simpson", Age=9},
             new Person {FirstName= "Bart", LastName="Simpson", Age=8}
             };

            // Print out # of items in List.
            Console.WriteLine("Items in list: {0}", people.Count);

            // Enumerate over list.
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }

            // Insert a new person.
            Console.WriteLine("\n->Inserting new person.");
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            Console.WriteLine("Items in list: {0}", people.Count);

            // Copy data into a new array.
            Person[] arrayOfPeople = people.ToArray();

            foreach (Person p in arrayOfPeople)
            {
                Console.WriteLine("First Names: {0}", p.FirstName);
            }
        }
    }



    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person() { }
        public Person(string firstName, string lastName, int age)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }
    }
}

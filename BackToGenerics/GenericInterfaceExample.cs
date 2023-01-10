using BackToGenerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToGenerics
{
    internal class GenericInterfaceExample
    {

    }

            public interface IComparable<T>
            {
                int CompareTo(T obj);
            }
            //In this case, your implementation code will be cleaned up considerably.
        //public class Car : IComparable<Car>
        //    {
        
         // IComparable<T> implementation.
//         int IComparable<Car>.CompareTo(Car obj)
//                {
//                    if (this.CarID > obj.CarID)
//                    {
//                        return 1;
//                    }
//                    if (this.CarID < obj.CarID)
//                    {
//                        return -1;
//                    }
//                    return 0;
//                }






           }


//Here, you do not need to check whether the incoming parameter is a Car because it can only be a 
//Car! If someone were to pass in an incompatible data type, you would get a compile-time error



class SortPeopleByAge : IComparer<Person>
{
    public int Compare(Person firstPerson, Person secondPerson)
    {
        if (firstPerson?.Age > secondPerson?.Age)
        {
            return 1;
        }
        if (firstPerson?.Age < secondPerson?.Age)
        {
            return -1;
        }
        return 0;
    }




    public static void UseSortedSet()
    {
        // Make some people with different ages.
        SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
         {
         new Person {FirstName= "Homer", LastName="Simpson", Age=47},
         new Person {FirstName= "Marge", LastName="Simpson", Age=45},
         new Person {FirstName= "Lisa", LastName="Simpson", Age=9},
         new Person {FirstName= "Bart", LastName="Simpson", Age=8}
         };
        // Note the items are sorted by age!
        foreach (Person p in setOfPeople)
        {
            Console.WriteLine(p);
        }
        Console.WriteLine();
        // Add a few new people, with various ages.
        setOfPeople.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 1 });
        setOfPeople.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 32 });
        // Still sorted by age!
        foreach (Person p in setOfPeople)
        {
            Console.WriteLine(p);
        }
    }
}




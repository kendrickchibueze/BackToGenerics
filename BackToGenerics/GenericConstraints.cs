using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BackToGenerics
{
    internal class GenericConstraints
    {
        //GenericTypeName<T> where T  : contraint1, constraint2
    }


    class DataStoreTwo<T> where T : class
    {
        public T Data { get; set; }






        //Above, we applied the class constraint, 
        //which means only a reference type can be passed as an argument while creating the DataStore class object. 
        //So, you can pass reference types such as class, interface, delegate, 
        //or array type.Passing value types will give a compile-time error, so we cannot pass primitive data types or struct types.





        DataStoreTwo<string> store = new DataStoreTwo<string>(); // valid
        //DataStoreTwo<MyClass> store = new DataStoreTwo<MyClass>(); // valid
        //DataStoreTwo<IMyInterface> store = new DataStoreTwo<IMyInterface>(); // valid
       // DataStoreTwo<IEnumerable> store = new DataStoreTwo<IMyInterface>(); // valid
        //DataStoreTwo<ArrayList> store = new DataStoreTwo<ArrayList>(); // valid
        //DataStoreTwo<int> store = new DataStoreTwo<int>(); // compile-time error 
    }



    //The following example demonstrates the struct constraint that restricts type argument to be non-nullable value type only
    class DataStoreThree<T> where T : class, new()
    {
        public T Data { get; set; }






        //DataStoreThree<MyClass> store = new DataStoreThree<MyClass>(); // valid
        //DataStoreThree<ArrayList> store = new DataStoreThree<ArrayList>(); // valid
        //DataStoreThree<string> store = new DataStoreThree<string>(); // compile-time error 
        //DataStoreThree<int> store = new DataStoreThree<int>(); // compile-time error 
        //DataStoreThree<IMyInterface> store = new DataStoreThree<IMyInterface>(); // compile-time error 


    }



    //The following example demonstrates the base class constraint
    //that restricts type argument to be a derived class of the specified class, abstract class, or an interface.
    class DataStoreFour<T> where T : IEnumerable
    {
        public T Data { get; set; }
    

    DataStoreFour<ArrayList> store = new DataStoreFour<ArrayList>(); // valid
    //DataStoreFour<List> store = new DataStoreFour<List>(); // valid
    //DataStoreFour<string> store = new DataStoreFour<string>(); // compile-time error 
    //DataStoreFour<int> store = new DataStoreFour<int>(); // compile-time error 
    //DataStoreFour<IMyInterface> store = new DataStoreFour<IMyInterface>(); // compile-time error 
    //DataStoreFour<MyClass> store = new DataStoreFour<MyClass>(); // compile-time error 

        }
}

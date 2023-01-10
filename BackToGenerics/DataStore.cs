using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToGenerics
{

    class DataStore<T>
    {
        public T Data { get; set; }

       // public T data; this is a generic field which cannot be initialized

        public T[] _data = new T[10];     //this is a generic array



        //we can now instantiate the generic class and pass in an actual datatype
        public static void callMethod()
        {
            // DataStore<string> store = new DataStore<string>();
            //store.Data = "Hello World!";


            DataStore<string> cities = new DataStore<string>();

            cities.AddOrUpdate(0, "Mumbai");
            cities.AddOrUpdate(1, "Chicago");
            cities.AddOrUpdate(2, "London");


            DataStore<int> intStore = new DataStore<int>();
            intStore.Data = 100;
        }


        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }





        // A generic class can be a base class to other generic or non-generic classes or abstract classes.
        //A generic class can be derived from other generic or non-generic interfaces, classes, or abstract classes.

    }
}

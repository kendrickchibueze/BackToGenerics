using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToGenerics
{
    class Printer
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }





        public static void callPrinter()
        {
            Printer printer = new Printer();
            printer.Print<int>(100);
            printer.Print(200); // type infer from the specified value
            printer.Print<string>("Hello");
            printer.Print("World!"); // type infer from the specified value
        }
    
    }

}

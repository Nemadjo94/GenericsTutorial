using System;

namespace GenericsTutorial
{

    //Declare the generic class
    public class GenericList<T>
    {
        void Add(T input)
        {

        }
    }

    class Program 
    {
        private class ExampleClass { }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp; temp = lhs; lhs = rhs; rhs = temp;
        }
       
        static void Main(string[] args)
        {
            //Declare a list of type int
            GenericList<int> list1 = new GenericList<int>();

            //Declare a list of type string
            GenericList<string> list2 = new GenericList<string>();

            //Declare a list of type ExampleClass
            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();

            int a, b;
            char c, d;
            a = 10;
            b = 20;
            c = 'I';
            d = 'V';

            //Display values before the swap:
            Console.WriteLine("Int values before calling swap:");
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine("Char values before calling swap:");
            Console.WriteLine($"c = {c}, d = {d}");

            //Call Generic Swap
            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);

            //Display values after swap:
            Console.WriteLine("Int values after calling swap:");
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine("Char values after calling swap:");
            Console.WriteLine($"c = {c}, d = {d}");
        
        }
    }
}

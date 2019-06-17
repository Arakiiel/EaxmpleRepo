using ExampleProject.Classes;
using System;

namespace ExampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var examples = new ExampleClass();
            examples.InitialiseNames();

            examples.ReturnNames().ForEach(x => Console.WriteLine(x.ReturnFullName()));

            examples.AlterNames();
            examples.ReturnNames().ForEach(x => Console.WriteLine(x.ReturnFullName()));
        }
    }
}

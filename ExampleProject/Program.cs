using ExampleProject.Classes;
using System;
using System.Collections;
using System.Linq;

namespace ExampleProject
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            //static local functions
            var x = 2;

            //static int TotalValue2(int value1, int value2) => (x + value2);
            static int TotalValue(int value1, int value2) => (value1 + value2);

            Console.WriteLine("Total value of 12 and 3 is " + TotalValue(12, 3));


            var examples = new ExampleClass();
            examples.InitialiseNames();

            //examples.ReturnNames().ForEach(x => Console.WriteLine(x.ReturnFullName()));

            //examples.AlterNames();
            //examples.ReturnNames().ForEach(x => Console.WriteLine(x.ReturnFullName()));
            //var example2 = examples.ReturnNames().FirstOrDefault();

            //default interface example
            //Console.WriteLine("default interface inplementation");
            //Console.WriteLine((example2 as IFullName).ReturnFullName("asdf"));



            //indices and ranges
            var lastName = examples.NameArray[..^1];
            var betweenFirstAndLastName = examples.NameArray[0..^1];
            var everyName = examples.NameArray[..];

            var rangeExamples = 0..3;

            var namesZeroTo4 = examples.NameArray[rangeExamples];

            foreach(string s in lastName)
            {
                Console.WriteLine(s);
            }

            //async example
            await foreach(string s in examples.AsyncExample())
            {
                Console.WriteLine(s);
            }

            //property pattern
            Console.WriteLine(examples.PropertyPatternExample(examples.Names.FirstOrDefault(), "random string"));

            if (examples.Names.FirstOrDefault() is FullName { FirstName: "first name 1"})
            {
                Console.WriteLine("first name is first name one");
            }

            //tuple pattern
            if(("test","test") is ("test", "test"))
            {
                Console.WriteLine("wow apparently these values are the same TUPLE");
            }

            //positional pattern
            if(examples.Names.FirstOrDefault() is ("first name 1", "middle name 1", "last name 1"))
            {
                Console.WriteLine("wow apparently these values are the same POSITIONAL");
            }

        }
    }
}

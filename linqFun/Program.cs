using System;

namespace linqFun
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Enumerable
                .range(1,10)
                .Select(i => doubleit)
                .Select(i => add1);
            foreach(var number in numbers) 
            { 
                Console.WriteLine(number)
                    }
            private static int add1(int n) { Console.WriteLine($"legger1 til {n}")}
            //var orders = ...;
            //foreach (var n in numbersSequence)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.WriteLine("---");
            //foreach(var o in orders)
            //{
            //    deliver(o);
            //}
            //    dosomething<int>(5);
            //    dosomething<string>("ijf");
            //}
            //static void dosomething<t>(t value)where t : class
            //{
            //    Console.WriteLine(value);
            //}
        }
    }
}

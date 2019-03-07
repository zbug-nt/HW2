using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello2
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld.Hello();
            HelloWorld.PrintArgs(args);
        }
    }

    class HelloWorld
    {
        public static void Hello()
        {
            Console.WriteLine("Hello World!");
        }

        public static void PrintArgs(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("There is no argument.");
                return;
            }
            Console.WriteLine($"There are {args.Length} argument(s).\nThey are:");
            for (int i = 0; i < args.Length; ++i)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello1
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld helloWorld = new HelloWorld();
            helloWorld.printArgs(args);
        }
    }

    class HelloWorld
    {
        public HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        public void printArgs(string[] args)
        {
            Console.WriteLine($"There are {args.Length} argument(s).\nThey are:");
            for (int i = 0; i < args.Length; ++i)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}

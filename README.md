# HW2
C# homework 2
## Hello1: Instance HelloWorld
Print "Hello World!" in ***constructor*** and print arguments in ***PrintArgs*** method.

    class HelloWorld
    {
        public HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        public void PrintArgs(string[] args)
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

### Screenshot
![Hello1](/Hello1/Hello1.png)
## Hello2: Static Method HelloWorld
Print "Hello World!" in static method ***Hello*** and print arguments in static method ***PrintArgs***.

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

### Screenshot
![Hello2](/Hello2/Hello2.png)
## Hello3: WPF Hello World
Use ***Environment.GetCommandLineArgs()*** to get commandline arguments. A MessageBox saying "Hello World!" will show up when the button "Say Hello" is clicked. A MessageBox displaying arguments will show up when the button "Show Args" is clicked. Notice that there will always be at least one argument and the first argument will always be the path of the program.
### Screenshot
Click "Say Hello":

![before click](/Hello3/Hello3_1.png)

Click "Show Args":

![after click](/Hello3/Hello3_2.png)
## Hello4: WindowsForm Hello World
A new class called ***Helloer*** is created. It contains a static method called ***GenerateHelloString***, which returns a string showing the commandline arguments. The string will be shown when the button is pushed.
### Screenshot

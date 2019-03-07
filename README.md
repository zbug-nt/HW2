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
A label and a button is added to the MainWindow. A messagebox saying "Hello World!" will show up when the button is clicked.

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Hello World!");
    }

### Screenshot
Before click:

![before click](/Hello3/Hello3_1.png)

After click:

![after click](/Hello3/Hello3_2.png)

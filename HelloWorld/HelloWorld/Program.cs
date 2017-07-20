using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to say?");
            string say = Console.ReadLine();
            if (say == "Hello World")
            {
                Console.WriteLine("That's what I was thinking!");
            }
            else
            {
                Console.WriteLine('\"'+say + "\" to you, too.");
            }
        }
    }
}

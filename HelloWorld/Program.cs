using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, today is {date:d} and the time is {date:t}!");
            Console.Write("\nPress key to exit Now...");           
           // Console.Write("\nGoodBye Cruel world, especially 2020! Break on through");
           // Console.Write("Lord of the rings");
            System.Threading.Thread.Sleep(8000);
            Console.ReadKey(true);
        }
    }
}

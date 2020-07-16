using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your full name according to your passport? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name} from AET Eurofins, on {date:d} at {date:t}!");
            Console.Write("\nPress key to exit Now...Checking simple change to show changes july16_1");
            System.Threading.Thread.Sleep(8000);
            Console.Write("\nGoodBye Cruel world, especially 2020! Break on through");
            Console.Write("Lord of the rings");
            Console.ReadKey(true);
        }
    }
}

using System;

namespace Lady
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MyCountry = "canada";
            const string BelovedCountry = "france";
            const string WeirdCountry = "gabon";
            string name;
            Console.WriteLine("What is your country?");
            name = Console.ReadLine();
            switch (name.ToLower())
            {
                case MyCountry:
                    Console.WriteLine("You have the same country as me!");
                    break;
                case BelovedCountry:
                    Console.WriteLine("You live in my beloved country!");
                    break;
                case WeirdCountry:
                    Console.WriteLine("You live in a very weird country!!!");
                    break;
            }
            Console.WriteLine("Good bye, {0}!", name);
            Console.ReadKey();
            //It looks like this code is ok, but it doesn't work on my laptap
        }
    }
}

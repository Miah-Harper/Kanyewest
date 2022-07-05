using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KayneWest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new findQuote(client);

            

            Console.WriteLine("Would you like to hear the ramblings of Kanye West and Ron Swanson?");

           
            var userAnswer = Console.ReadLine().ToLower();

            Console.WriteLine();

            int i = 0;

            if (userAnswer == "yes")
            {

                

                do
                {
                    Console.WriteLine($"Kanye says: {quote.KanyeWest()}");
                    Console.WriteLine();
                    Console.WriteLine($"Ron Swanson returns with: {quote.RonSwanson()}");
                    Console.WriteLine();



                    i++;
                }

                while (i < 5);
                {
                   
                }
                
            }

            if (userAnswer == "no")
            {

                Console.WriteLine("I'd wish you best of luck, but I believe luck is a concept created by the weak to explain their failures.");

            }



        }

        

    }
}


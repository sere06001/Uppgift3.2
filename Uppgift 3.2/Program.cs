using System;
namespace Uppgift3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut ur gymnasiet?");
            Console.WriteLine("Skriv \"j\" för ja och \"n\" för nej");
            string svar = (Console.ReadLine());
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (svar == "j" && ålder < 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig!");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
            }
            Console.ReadKey();
        }
    }
}
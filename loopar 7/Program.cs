using System; 

namespace loopar_7
{
    class program
    {
        static void Main(string[] args)
        {
            int tal;
            Console.WriteLine("skriv in ett positiv tal. Negativ tal när du vill avsluta");

            while (true)
            {
                Console.WriteLine("skriv in ett tal");
                tal=int.Parse(Console.ReadLine());
                if (tal < 0 )
                {
                    Console.WriteLine("du skrev ett negativit tal programmet avslutas");
                    break;

                }

                    


            }

        }

    }


}
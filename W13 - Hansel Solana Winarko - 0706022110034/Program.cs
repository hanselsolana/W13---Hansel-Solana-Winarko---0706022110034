using System;

namespace W13___Hansel_Solana_Winarko___0706022110034
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("3. Search Scroll\n4. Remove Scroll\nChoose what to do: ");
            int pilihan = Convert.ToInt16(Console.ReadLine());

            if (pilihan == 3)
            {
                Console.WriteLine("Insert scroll name");
                string insert = Console.ReadLine();
            }
            while (true)
            {
                Console.Write("Book found. Queue number: ");
                int queue = Convert.ToInt16(Console.ReadLine());
            }
            while (false)
            {
                Console.Write("Book not found. Queue number: ");
                int queue1 = Convert.ToInt16(Console.ReadLine());
            }
            if (pilihan == 4)
            {
                Console.WriteLine("Remove from list by scroll name? Y/N: ");
                string insert2 = Console.ReadLine();
            }
            else if (pilihan == Y)
            {
                Console.WriteLine("Input scroll name: ");
                string scrollName = Console.ReadLine();
            }
            else if (pilihan == N)
            {
                Console.WriteLine("Input scroll queue: ");
                string scrollQueue = Console.ReadLine();
            }
        }
    }
}
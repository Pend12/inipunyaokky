using System;

namespace Trytry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka: ");
            int bil = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            for (int i = 2; i <= bil / 2; i++)
            {
                if (bil % i == 0)
                {
                    Console.Write("Angka bukan prima");
                    counter = 1;
                    break;
                }
            }
            if (counter == 0)
                Console.Write("Angka prima");
        }
        }
    }
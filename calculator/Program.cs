using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kalkulator";
            Console.WriteLine("Masukan nilai A = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukan nilai B = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("Pilih Menu");
            int pilih;
            pilih = Convert.ToInt32(Console.ReadLine());
            switch (pilih)
            {
                case 1:
                    Console.WriteLine(a + b);
                    Console.ReadKey(); break;
                case 2:
                    Console.WriteLine(a - b);
                    Console.ReadKey(); break;
                case 3:
                    Console.WriteLine(a * b);
                    Console.ReadKey(); break;
                case 4:
                    Console.WriteLine(a / b);
                    Console.ReadKey(); break;
                default: 
                    Console.WriteLine("Menu tidak tersedia");
                    Console.ReadKey(); break;   
            }

        }
    }
}

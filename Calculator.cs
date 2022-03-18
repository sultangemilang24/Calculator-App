using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculatorConsoleApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator App";

            Console.WriteLine("\nSilahkan pilih pengoprasian yang di inginkan:\n");
            Console.WriteLine("Penambahan\t(1)");
            Console.WriteLine("Pengurangan\t(2)");
            Console.WriteLine("Perkalian\t(3)");
            Console.WriteLine("Pembagian\t(4)");

            Console.WriteLine("\nInput (1-4) : ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x < 5 && x > 0)
            {

            Console.WriteLine("\n================================================================\n");
            
            Console.WriteLine("Masukan Nilai 1 : ");
            int a = Convert.ToInt32(Console.ReadLine()); //Deklarasi Variabel a, Konversi menggunakan Parse

            Console.WriteLine("Masukan Nilai 2 : ");
            int b = Convert.ToInt32(Console.ReadLine());  //Deklarasi Variabel b, Konversi menggunakan Convert

            Console.WriteLine("\n================================================================\n");

            if (x == 1)
            {
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            } else if (x == 2)
            {
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Penguragan(a, b));
            } else if (x == 3)
            {
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            } else if (x == 4)
            {
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }

            Console.WriteLine("\nTekan sembarang tombol untuk melanjutkan!");
            Console.ReadKey();

            } else
            {
                Console.WriteLine("\nInput Salah!");

                Console.WriteLine("\n================================================================\n");

                Console.WriteLine("\nTekan sembarang tombol untuk melanjutkan!");
                Console.ReadKey();
            }
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Penguragan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a - b;
        }
    }
}



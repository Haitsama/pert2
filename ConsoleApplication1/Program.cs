using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "äplikasi calculator";

            //int a = 10; // deklarasi variable a, dg nilai awal 10;
            //int b = 6; //dekalasari variable b,dg nilai awal 6;

            Console.Write("inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine()); //proses casting
            Console.Write("inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine()); //proses casting

            Console.WriteLine(); //tambahakan baris kosong

            Console.WriteLine("Hasil penambah " + a + "+" + b + "=" + penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, pengurangan(a, b));
            Console.WriteLine("Hasil perkalian {0} * {1} = {2} ", a, b, perkalian(a, b));
            Console.WriteLine("Hasil pembagian {0} / {1} = {2} ", a, b, pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();

        }
        static int penambahan (int a,int b)
        {
            return a+b;
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }

        static int pembagian(int a, int b)
        {
            return a / b;
        }

    }
}

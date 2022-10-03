using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1214062
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("== Aplikasi Penghitung Gaji Karyawan ==");
            Console.Write("Masukkan Nominal Gaji Anda : ");
            var gaji = int.Parse(Console.ReadLine());

            double tunjangan = 20.0 / 100.0 * gaji;
            double bonus = 15.0 / 100.0 * gaji;
            double pph = 3.5 / 100.0 * gaji;
            double total_gaji = gaji + tunjangan + bonus;
            double gaji_bersih = total_gaji - pph;

            Console.WriteLine("Gaji Pokok    =   " + gaji);
            Console.WriteLine("Tunjangan     =   " + tunjangan);
            Console.WriteLine("Bonus         =   " + bonus);
            Console.WriteLine("PPH           =   " + pph);
            Console.Write("Total Gaji    =   ");
            Console.WriteLine(total_gaji);
            Console.Write("Gaji Bersih   =   ");
            Console.WriteLine(gaji_bersih);
            Console.ReadKey();

        }
    }
}

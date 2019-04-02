using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarasi Variabel
            int hasil;
            
            //Membuat Objek  Dari Class Calculator
            Calculator calculator = new Calculator();

            //Panggil Method Penjumlahan
            hasil = calculator.Penjumlah(10, 2);
            CetakHasil("Hasil Penjumlahan : " + hasil);

            //Panggil Method Penjumlah Dengan 3 Parameter (Overload Method)
            hasil = calculator.Penjumlah(10, 2, 3);
            CetakHasil("Hasil Penjumlah Overload : " + hasil);

            //Panggil Method Pengurangan
            hasil = calculator.Pengurangan(7, 3);
            CetakHasil("Hasil Pengurangan : " + hasil);

            //Panggil Static Method, Langsung Dari Nama Classnya
            hasil = Calculator.Perkalian(5, 2);
            CetakHasil("Hasil Perkalian : " + hasil);

            Console.ReadKey();
        }
        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
}

using System;

namespace KonversiMataUang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("Rate USD ke RP:");
            Console.Write("");
            double RateUSD = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Jumlah USD");
            Console.Write("");
            double JumlahUSD = Convert.ToDouble(Console.ReadLine());

            double Hasil = RateUSD * JumlahUSD;
            Console.WriteLine("Hasil Konversi : Rp. "+Hasil);
            Console.ReadLine();
        }
    }
}

using System;

namespace TiketBioskop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string Harga;
            Console.Write("Nama : ");
            string Nama = Console.ReadLine();
            Console.Write("Tahun Lahir : ");
            int ThnLahir = Convert.ToInt32(Console.ReadLine());   
            int Usia = 2022 - ThnLahir;
            
            if(Usia < 10 || Usia > 60){
                Harga = "Rp. 10.000,-";
            }
            else{
                Harga = "Rp. 25.000,-";
            }
            Console.WriteLine("|****************************|");
            Console.WriteLine("|       -- STUDIO 1 --       |");
            Console.WriteLine("|****************************|");
            Console.WriteLine(String.Format("| {0,-10}{1,-10}       |", "Nama: ", Nama));
            Console.WriteLine(String.Format("| {0,-10}{1,-10}     |", "Harga: ", Harga));
            Console.WriteLine("+----------------------------+");
        }  
    }
}
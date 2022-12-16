using System;
// Drin Marsal Albari
namespace HelloWorldS
{
    class Program
    {
        static void Main(string[] args)
        {   
            const int a = 5;
            const int b = 4;
            const int c = 7;

            int Tambah = a+b+c;
            int Kali = a*b*c;
            int kurang = a-b-c;
            int bagi = a/b/c;

            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server" +
            "\nAkses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("- Password terdiri dari 4 angka");
            Console.WriteLine("- Jika ditambahkan hasilnya "+Tambah);
            Console.WriteLine("- Jika dikalikan hasilnya "+Kali);
            Console.WriteLine("- Jika dikurangi hasilnya "+kurang);
            Console.WriteLine("- Jika dibagikan hasilnya "+bagi);
            Console.Write("Enter Code : ");
        }
    }
}

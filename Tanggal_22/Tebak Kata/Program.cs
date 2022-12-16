//Drin Marsal Albari (2207113381)

using System;
using System.Collections.Generic;

namespace tebakkata
{
    class Program
    {
        static int kesempatan = 5;
        static string katamisteri = "bougenville";
        static List<string> listtebakan = new List<string>{};
        static void Main(string[] args)
        {            
            intro();
            playgame();
            showend();
        }
        
        static void intro()
        {
            Console.WriteLine("Welcome, \nMari kita main Tebak Kata ! ");
            Console.WriteLine($"Kamu punya : {kesempatan} kesempatan");
            Console.WriteLine("Petunjuknya, Kata ini adalah Nama bunga yang banyak jenis dan warnanya");
            Console.WriteLine($"Kata tersebut terdiri dari : {katamisteri.Length} huruf");
            Console.WriteLine("Kata apakah yang dimaksud?");
            Console.ReadKey();
            Console.WriteLine();
        }

        static void playgame()
        {
            while (kesempatan>0)
            {
                Console.Write("\nCoba huruf apa dulu nih? (pilih a-z) : ");string input = Console.ReadLine();
                listtebakan.Add(input);
                if(cekjawaban(katamisteri, listtebakan))
                {
                    Console.WriteLine("NICE GAME BRO! kamu menang.");
                    Console.WriteLine($"Kata Mistery nya adalah : {katamisteri}");
                    break;
                }else if(katamisteri.Contains(input))
                {
                    Console.WriteLine("\nNah ada tuh hurufnya");
                    Console.WriteLine("Tebak lagi yuk..");
                    //menampilkan huruf yang sudah tertebak
                    Console.WriteLine(cekhuruf(katamisteri, listtebakan));
                }else
                {
                    Console.WriteLine("\nGa ada huruf itu bray");
                    kesempatan--;//kesempatan = kesempatan - 1;
                    Console.WriteLine($"Kesempatan Tebak : {kesempatan}");
                }

                if (kesempatan==0)
                {
                    showend();
                    break;
                }
            }
        }
        static bool cekjawaban(string katarahasia, List<string> list)
        {
            bool status = false;

            for (int i = 0; i < katarahasia.Length; i++)
            {
                string c = Convert.ToString(katarahasia[i]);
                if(list.Contains(c))
                {
                    status = true;
                }else
                {
                    return status = false;
                }
            }
            return status;
        }
        static string cekhuruf(string katarahasia, List<string> list)
        {string x = "";

        for (int i = 0; i < katarahasia.Length; i++)
        {
            string c = Convert.ToString(katarahasia[i]);
            if(list.Contains(c))
            {
                x = x + c;
            }else
            {
                x = x + "-";
            }
        }
        return x;
        }
        static void showend()
        {
            if (kesempatan == 0)
            {
            Console.WriteLine("GAME OVER.");
            Console.WriteLine($"Kata Misteri : {katamisteri}");
            Console.WriteLine("Bye...");
            }
        }
    }
}

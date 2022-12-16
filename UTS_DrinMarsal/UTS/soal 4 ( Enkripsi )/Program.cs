using System;

namespace uts
{
    class Enkripsi
    {
        public static void Main(string[] args) {
            String alphabet = "abcdefghijklmnopqrstuvwxyzabcABCDEFGHIJKLMNOPQRSTUVWXYZABC";
            String teks, enkripsi = "";
            System.Console.Write("Teks : ");
            teks = Console.ReadLine();

            char sementara = ' ';
            for(int character=0;character<teks.Length;character++)
            {
                Char t = teks[character];
                for(int Kelipatan=0;Kelipatan<alphabet.Length;Kelipatan++)
                {
                    Char c = alphabet[Kelipatan];
                    if (t.Equals(c)) { 
                        sementara = alphabet[character+3];
                    } else if (t.Equals(' ')) {
                        sementara = ' ';
                    }
                }
                enkripsi = enkripsi + sementara;
            }
            System.Console.Write("Hasil enkripsi : " + enkripsi);
        }
    }
}
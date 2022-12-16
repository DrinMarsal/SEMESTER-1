using System;

namespace GAME_DADU
{
    class Program
    {
        static int nilaikomputer;
        static int nilaianda;
        static int ronde = 1;
        static int skoranda;
        static int skorkomputer;
        static int komputer;

        static bool gameDimulai;

        static void Main(string[] args)
        {
            gameDimulai = true;
            while (ronde <= 10)
            {
                Console.Clear();
                gameDimulai = playgame();
                showend();
                if(gameDimulai && ronde < 10)
                {
                    Console.WriteLine("Anda memenangkan ronde ini." +skoranda);
                } else if(gameDimulai && ronde < 10)
                {
                    Console.WriteLine("Komputer memenangkan ronde ini." +komputer);
                }
                ronde++;
            }
            Console.ReadKey();
        }
        static void introGame()
        {
            gameDimulai = true;
            if(gameDimulai && ronde == 1)
            {
                Console.WriteLine("\nMulai main...");
            }
        }
        static void showend()
        {
            if(skoranda > skorkomputer && ronde == 10)
            {
                Console.WriteLine("Selamat, Anda Menang!\nBye...");
            }
            if(skorkomputer > skoranda && ronde == 10)
            {
                Console.WriteLine("Anda Kalah.");
            }
        }
        static bool playgame()
        {
            Random rng = new Random();
            nilaikomputer = rng.Next(1,6);
            nilaianda = rng.Next(1,6);

            introGame();
            Console.WriteLine("Ronde "+ronde);
            Console.WriteLine("Nilai Komputer : "+nilaikomputer);
            Console.ReadKey();
            Console.WriteLine("Nilai Anda : "+nilaianda);

            if(nilaianda > nilaikomputer)
            {
                skoranda++;
                Console.WriteLine("Skor - Anda : "+skoranda+". Komputer : "+skorkomputer);
                Console.WriteLine("Lanjutkan Ke Ronde Selanjutnya...");
                Console.ReadKey();
                return true;
            } else if (nilaikomputer > nilaianda)
            {
                skorkomputer++;
                Console.WriteLine("Skor - Anda : "+skoranda+". Komputer : "+skorkomputer);
                Console.WriteLine("Lanjutkan Ke Ronde Selanjutnya...");
                Console.ReadKey();
                return false;
            }else
            {
                Console.WriteLine("Seri.");
                Console.ReadKey();
                return false;
            }
        }
    }
}

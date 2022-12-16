using System;

namespace marsal
{
    class Program
    {
            static int code1;
            static int code2;
            static int code3;

            static String tebakan1;
            static String tebakan2;
            static String tebakan3;

            static int hasil1;
            static int hasil2;
            static int hasil3;
            static int lvl = 1;
            static int hp = 3;

            static bool gameStart;
            
            static void Main(string[] args)
            {
                init();
                while (hp > 0 && lvl <= 5)
                {
                    Console.Clear();
                    gameStart = playgame(lvl);
                    if(gameStart && lvl < 5)
                    {
                        lvl++;
                        Console.WriteLine("Horeyy.. Naik Ke Level : "+lvl);
                    } else if(gameStart && lvl < 5)
                    {
                        Console.WriteLine("Yahh.. Nyawa Kamu Berkurang"+hp);
                        break;
                    } else 
                    {
                        hp--;
                        Console.WriteLine("Yahh.. Nyawa Kamu : "+hp);
                    }

                    if(lvl == 5 && hp > 0)
                    {
                        Console.WriteLine("\nKita.. Resmi.. Menamatkan.. VSCode !!! ");
                        break;
                    } else if(hp <= 0)
                    {
                        Console.WriteLine("\nYahh.. Dicoba Lagi ya");
                        Console.WriteLine("\nYahh.. NT Adik Adik");
                    } else if(hp <= 0 && lvl == 1)
                    {
                        Console.WriteLine("Kamu Kalah.. :(");
                        Console.WriteLine("\nNyawa Kamu Habis Bro");
                        
                    }
                }
            Console.ReadKey();
            }
            
        static void init()
        {
            gameStart = true;
        }

        static void introgameMarsal()
        {
            init();
            if (gameStart && hp == 3 && lvl == 1)
            {
                Console.WriteLine("\nwelcome");
            }
        }

        static bool playgame(int level)
        {
            Random rng = new Random();
            code1 = rng.Next(1,level+1);
            code2 = rng.Next(1,level+1);
            code3 = rng.Next(1,level+1);

            hasil1=code1+code2+code3;
            hasil2=code1*code2*code3;
            hasil3=code1-code2-code3;

            introgameMarsal();
            Console.WriteLine("\nKamu Ada Di Level : "+lvl);
            Console.WriteLine("Siap Menyelesaikan Tebakan ini?");
            Console.WriteLine("\nJika 3 Angka Ditambah, maka "+hasil1+"\nJika 3 Angka Dikali, maka "+hasil2+"\nJika 3 Angka Dikurang, maka "+hasil3);
            Console.Write("\nCode 1 :"); tebakan1 = Console.ReadLine();
            Console.Write("Code 2 :"); tebakan2 = Console.ReadLine();
            Console.Write("Code 3 :"); tebakan3 = Console.ReadLine();

            if((tebakan1 == code1.ToString() && tebakan2 == code2.ToString() && tebakan3 == code3.ToString()))
            {
                Console.WriteLine("\nTebakan kamu Benar!");
                return true;
            } else
            {
                Console.WriteLine("\nTebakan kamu Salah -_-");
                return false;
            }
        }
    }
}

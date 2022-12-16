using System;
using static System.Console;

namespace Adventure_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Selamat datang di Game Advanture ku!");
            WriteLine("Siapa nama anda?");
            Novice player = new Novice();
            player.Name = ReadLine();
            WriteLine("Hi "+player.Name+ ",Apakah kamu siap menjelajahi game ini?[y/n]");
            string bReady = ReadLine();
            if(bReady=="y")
            {
                WriteLine(player.Name+"!! Memasuki Dunia game");
                Enemy enemy1 = new Enemy("Sapi Ngamuk");
                WriteLine(player.Name+ " menemukan " +enemy1.Name);
                WriteLine(enemy1.Name+" menyerang mu ...");
                WriteLine("Apa yang kamu lakukan : ");
                WriteLine("1. Serangan Biasa");
                WriteLine("2. Serangan Penuh");
                WriteLine("3. Bertahan");
                WriteLine("4. Lari...");

                while (!player.IsDead && !enemy1.IsDead)
                {
                    string playerAction = ReadLine();
                    switch (playerAction)
                    {
                        case "1" :
                        WriteLine(player.Name+ "Melakukan serangan biasa");
                        enemy1.GetHit(player.AttackPower);
                        player.Experience += 0.6f;
                        enemy1.Attack(enemy1.AttackPower);
                        player.GetHit(enemy1.AttackPower);
                        Write("Nyawa Pemain : "+player.Hp+" | Nyawa Musuh : "+enemy1.Hp+"\n");
                        break;
                        case "2" :
                        WriteLine(player.Name+ "Melakukan serangan penuh");
                        player.Serious();
                        player.Experience += 1.2f;
                        enemy1.GetHit(player.AttackPower);
                        Write("Nyawa Pemain : "+player.Hp+" | Nyawa Musuh : "+enemy1.Hp+"\n");
                        break; 
                        case "3" :
                        player.Rest();
                        WriteLine("Mana telah dipulihkan... ");
                        break;
                        case "4" :
                        WriteLine(player.Name+" Kabur...");
                        break;
                    }
                    continue;
                }
                
                WriteLine(player.Name+" mendapatkan "+player.Experience+" poin exp.");
            }
            else
            {
                WriteLine("Dadah.."); 
                Read();
            }
        }
    }

    class Novice
    {
        public int Hp { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int Skill { get; set; }
        public bool IsDead { get; set; }
        public float Experience { get; set; }
        Random rnd = new Random();

        public Novice()
        {
            Hp = 120;
            Skill = 0;
            AttackPower = 1;
            IsDead = false;
            Experience = 0f;
            Name = "Newbie";
        }

        public void Serious()
        {
            if(Skill > 0)
            {
                WriteLine("Pukulan Serius");
                AttackPower = AttackPower + rnd.Next(3,11);
                Skill--;
            }else
            {
                WriteLine("Mana tidak cukup!");
            }
        }

        public void GetHit(int hitValue)
        {
            WriteLine(Name+" Kenak pukul "+hitValue);
            Hp = Hp - hitValue;

            if(Hp <= 0)
            {
                Hp = 0;
                Die();
            }
        }

        public void Rest()
        {
            Skill = 3;
            AttackPower = 1;
        }

        public void Die()
        {
            WriteLine("Kamu mati. Game Over!");
            IsDead = true;
        }      
    }

    class Enemy
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int AttackPower { get; set; }
        public int Skill { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random();

        public Enemy(string name)
        {
            Hp = 60;
            Name = name;
        }

        public void Attack(int damage)
        {
            AttackPower = rnd.Next(1,10);
        }
        
        public void GetHit(int hitValue)
        {
            WriteLine(Name+" Diserang oleh "+hitValue);
            Hp = Hp - hitValue;

            if(Hp <= 0)
            {
                Hp = 0;
                Die();
            }
        }

        public void Die()
        {
            WriteLine(Name +" mati");
            IsDead = true;
        }
    }
}
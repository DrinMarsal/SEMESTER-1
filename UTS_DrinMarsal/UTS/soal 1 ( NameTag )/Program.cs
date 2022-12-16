using System;

public class NameTag
{
    public static void Main(string[] args)
    {
        string nama, nim, konsentrasi;
		Console.Write("Nama : ");
		nama = Console.ReadLine();
		Console.Write("Nim : ");
		nim = Console.ReadLine();
		Console.Write("Konsentrasi : ");
		konsentrasi = Console.ReadLine();
		
		Console.WriteLine("| **************************** |");
        Console.WriteLine("| Nama :  {0,20} |",nama);
		Console.WriteLine("|         {0,20} |",nim);
		Console.WriteLine("| ---------------------------- |");
		Console.WriteLine("|         {0,20} |",konsentrasi);
		Console.WriteLine("| **************************** |");
    }
}
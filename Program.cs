using Project;
using System;
using System.Text;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Патерн стратегія: ");

            Player knight = new Knight();
            knight.Display();
            knight.SetWeapon(new Axe());
            knight.Fight();

            Console.WriteLine("Зброю змінено на ніж");
            knight.SetWeapon(new Knife());
            knight.Fight();

            Player queen = new Queen();
            queen.Display();
            queen.SetWeapon(new Sword());
            queen.Fight();
        }
    }
}
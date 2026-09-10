using Project;
using System;

namespace Project
{
    public class Sword : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Удар мечем!");
        }
    }

    public class Bow : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Постріл з лука!");
        }
    }

    public class Axe : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Удар сокирою!");
        }
    }

    public class Knife : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Удар ножем!");
        }
    }
}
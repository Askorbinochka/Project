using Project;
using System;

namespace Project1
{
    public abstract class Player
    {
        protected IWeapon weapon;

        public void SetWeapon(IWeapon w)
        {
            this.weapon = w;
        }

        public void Fight()
        {
            if (weapon != null)
            {
                weapon.UseWeapon();
            }
            else
            {
                Console.WriteLine("У гравця немає зброї");
            }
        }

        public abstract void Display();
    }
}
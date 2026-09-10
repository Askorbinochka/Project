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

        public abstract void Display();
    }
}
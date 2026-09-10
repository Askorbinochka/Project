using System;

namespace Project
{
    public class King : Player
    {
        public override void Display()
        {
            Console.WriteLine("Король");
        }
    }

    public class Queen : Player
    {
        public override void Display()
        {
            Console.WriteLine("Королева");
        }
    }

    public class Knight : Player
    {
        public override void Display()
        {
            Console.WriteLine("Лицар");
        }
    }


}
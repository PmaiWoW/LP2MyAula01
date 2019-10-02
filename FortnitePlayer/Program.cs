using System;

namespace FortnitePlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            FNPlayer p1 = new FNPlayer();
            FNPlayer p2 = new FNPlayer(100, "Game Designer (Zombie)");

            p1.Shoot(p2);
        }
    }
}

using System;

namespace FortnitePlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            FNPlayer p1 = new FNPlayer();
            FNPlayer p2 = new FNPlayer(100, "Game Designer (Zombie)");

            Console.WriteLine(p2.GetHP());

            p1.Shoot(p2);
            
            Console.WriteLine(p2.GetHP());
        }
    }
}

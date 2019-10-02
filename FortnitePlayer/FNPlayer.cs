using System;
using System.Collections.Generic;
using System.Text;

namespace FortnitePlayer
{
    public class FNPlayer
    {
        private string skin;
        private int hp;

        public FNPlayer()
        {
            hp = 100;
            skin = "default";
        }

        public FNPlayer(int hp, string skin)
        {
            this.hp = hp;
            this.skin = skin;
        }

        public int GetHP() => hp;

        private void TakeDamage(int dmg)
        {
            hp-= dmg;
            if (hp < 0) hp = 0;
            // hp = Math.Max(0, hp - dmg)
        }

        private void Heal(int healAmount)
        {
            hp = Math.Min(100, hp + healAmount);
        }

        public void Shoot(FNPlayer enemy)
        {
            enemy.TakeDamage(10);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FortnitePlayer
{
    public class FNPlayer
    {
        private string skin;
        private int hp;

        //Constructors
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

        //Methods
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

        //Getters
        public int GetHP() => hp;

        public string GetSkin() => skin;

        //Setters
        public void SetHP(int hp)
        {
            if (hp > 100) hp = 100;
            else if (hp < 0) hp = 0;
            this.hp = hp;
        }
    }
}

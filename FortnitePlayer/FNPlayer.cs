using System;
using System.Collections.Generic;
using System.Text;

namespace FortnitePlayer
{
    public class FNPlayer
    {
        //Instance Variables
        //private string skin;
        //private int hp;

        //Properties
        public string Skin { get; set; }

        public int HP { get; set; }

        //Constructors
        public FNPlayer()
        {
            HP = 100;
            Skin = "default";
        }

        public FNPlayer(int HP, string Skin)
        {
            this.HP = HP;
            this.Skin = Skin;
        }

        //Methods
        private void TakeDamage(int dmg)
        {
            HP -= dmg;
            if (HP < 0) HP = 0;
            // HP = Math.Max(0, HP - dmg)
        }

        private void Heal(int healAmount)
        {
            HP = Math.Min(100, HP + healAmount);
        }

        public void Shoot(FNPlayer enemy)
        {
            enemy.TakeDamage(10);
        }

        /*
        //Getters
        public int GetHP() => HP;

        public string GetSkin() => Skin;

        //Setters
        public void SetHP(int HP)
        {
            if (HP > 100) HP = 100;
            else if (HP < 0) HP = 0;
            this.HP = HP;
        }
        */
    }
}

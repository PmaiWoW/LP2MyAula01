using System;
using System.Collections.Generic;
using System.Text;

namespace FortnitePlayer
{
    public class FNPlayer
    {
        public static int MaxHP { get; } = 100;
        //Instance Variables
        //private string skin;
        private int hp;

        //Properties
        public string Skin { get; }

        public int HP
        {
            get => hp;
            set
            {
                hp = (value < 0) ? 0 : (value > MaxHP) ? MaxHP : value;
            }
        }

        //Constructors
        public FNPlayer()
        {
            HP = MaxHP;
            Skin = "default";
        }

        public FNPlayer(int hp, string skin)
        {
            HP = HP;
            Skin = Skin;
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
            HP = Math.Min(MaxHP, HP + healAmount);
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

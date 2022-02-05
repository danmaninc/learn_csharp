using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Spearman
    {
        private int attack = 1;
        private int defense;
        private int damage;
        private int health = 4;
        private int speed;
        private int price;
        public int Storming()
        { 
            return attack;
        }
        public void getHit(int damage)
        {
            health = health - damage;
        }
        public bool isDead()
        {
            bool isDead;
            if (health > 0)
            {
                isDead = false;
            } else
            {
                isDead = true;
            }
            return isDead;
        }
    }
}

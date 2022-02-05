using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Spearman
    {
        private int attack;
        private int defense;
        private int damage;
        private int health;
        private int speed;
        private int price;
        public int Storming()
        { 
            return attack;
        }
        public void Hit(int damage)
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
            return isDead
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Spearman
    {
        private int attack = 4;
        private int defense = 5;
        private int health = 10;
        private int speed = 4;
        private int price = 60;
        public int Storming()
        {
            Random rnd = new Random();
            return rnd.Next(1, 4);
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
            } 
            else
            {
                isDead = true;
            }
            return isDead;
        }
    }
}

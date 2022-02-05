using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Shooter
    {
        private int attack = 6;
        private int defense = 3;
        private int damage;
        private int health = 10;
        private int speed = 6;
        private int price = 150;

        public int Storming()
        {
            Random rnd = new Random();
            return rnd.Next(2, 4);
        }

        public void getHit(int damage)
        {
            health -= damage;
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

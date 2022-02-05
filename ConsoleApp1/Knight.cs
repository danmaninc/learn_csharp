using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Knight
    {
        private int attack = 10;
        private int defense = 12;
        private int damage;
        private int health = 35;
        private int speed = 5;
        private int price = 300;

        public int Storming()
        {
            Random rnd = new Random();
            return rnd.Next(6, 10);
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
            } 
            else {
                isDead = true;
            }
        }
    }
}

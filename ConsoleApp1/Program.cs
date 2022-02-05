using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spearman spearman1 = new Spearman();
            Spearman spearman2 = new Spearman();

            int attackSpearman1 = spearman1.Storming();
            int attackSpearman2 = spearman2.Storming();

            while (!spearman1.isDead() && !spearman2.isDead())
            {
                spearman1.getHit(attackSpearman2);
                if (spearman1.isDead())
                {
                    break;
                }
                spearman2.getHit(attackSpearman1);
            }
            Console.WriteLine("Первый копейщик мёртв " + spearman1.isDead());
            Console.WriteLine("Второй копейщик мёртв " + spearman2.isDead());
        }
    }
}

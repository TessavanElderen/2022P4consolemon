using System.Collections.Generic;
using System;
namespace ConsoleMon
{
    class ConsoleMon
    {
        internal string name, MonsterType;
        internal int damage;
        internal int health = 100;
        internal int energy = 5;
        internal Element weakness;

        internal List<Skill> spells = new List<Skill>();


        internal void TakeDamage(int damage)
        {
            health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            energy -= energy;
        }

        internal ConsoleMon()
        {

        }

        internal ConsoleMon(ConsoleMon copyFrom)
        {
            this.health = copyFrom.health;
            this.energy = copyFrom.energy;
            this.weakness = copyFrom.weakness;

            foreach (Skill spell in copyFrom.spells)
            {
                Skill flamethrowerClone = new Skill(spell);
                spells.Add(flamethrowerClone);
            }
        }
    }
    class ConsoleMonArena
    { 
        public void DoBattle(ConsoleMon a, ConsoleMon b)
        {
            Random random = new Random();
            Skill skilla = a.spells[random.Next(2)];
            Skill skillb = b.spells[random.Next(2)];
            while (a.health > 0 || b.health > 0)
            {               
                skilla.UseOn(b, a);
                skillb.UseOn(a, b);
                Console.WriteLine(a.health);
                Console.WriteLine(b.health);
            }  
        }
    }
}
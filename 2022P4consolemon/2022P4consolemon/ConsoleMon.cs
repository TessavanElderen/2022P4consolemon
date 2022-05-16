using System.Collections.Generic;

namespace _2022P4consolemon
{
    class ConsoleMon
    {
        internal int health = 100;
        internal int energy = 5;
        internal Element weakness;

        List<Skill> spells = new List<Skill>();


        internal void TakeDamage(int damage)
        {
            health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            energy -= energy;
        }

        internal ConsoleMon(Skill other)
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
}
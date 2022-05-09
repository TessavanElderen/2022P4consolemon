using System;
using System.Collections.Generic;

namespace _2022P4consolemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    // health , energy , name , age
    // damage , energycost , name , weapons
    class ConsoleMon
    {
        internal int health = 100;
        internal int energy = 5;
        internal void TakeDamage(int damage)
        {
            health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            energy -= energy;
        }
    }

    class Skill
    {
        internal int skillEnegry = 10;
        internal int skillDamage = 10;
        void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(skillEnegry);
            target.TakeDamage(skillDamage);
        }

        List<string> spells = new List<string>();

    }
}

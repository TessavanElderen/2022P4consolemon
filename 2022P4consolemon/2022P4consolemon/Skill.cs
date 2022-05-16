namespace _2022P4consolemon
{
    class Skill
    {
        internal Element skillWeakness;
        internal int skillEnegry = 10;
        internal int skillDamage = 10;

        void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(skillEnegry);
            target.TakeDamage(skillDamage);
        }

        internal Skill()
        {

        }

        internal Skill(Skill flamethrower)
        {
            this.skillDamage = flamethrower.skillDamage;
            this.skillEnegry = flamethrower.skillEnegry;
            this.skillWeakness = flamethrower.skillWeakness;
        }
    }
}

using ConsoleMonsters.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleMonsters.Loaders
{
    class ConsoleMonFactory
    {
        private Dictionary<string, ConsoleMon> templates = new Dictionary<string, ConsoleMon>();

        public void Load(string datafile)
        {
            //lees je regels in 
            string[] lines = ????;

            for (//loop over je regels)
            {

                ConsoleMon temp = new ConsoleMon();

                //zet de waardes uit de text (hp enz) op je consolemon


                //per skill roep LoadSkill aan

                //voeg de nieuwe skill aan je consolemon skills toe
                //LoadSkill()


                //even toevoegen
                templates.Add(temp.Monstertype, temp);

            }

        }


        private Skill LoadSkill(string skillstring)
        {
            string[] split = skillstring.Split(',');
            Skill skill = new Skill()
            {
                Name = split[0],
                Damage = int.Parse(split[2]),
                Energy = int.Parse(split[4]),
                Element = LoadElement(split[6])
            };
            return skill;

        }

        private static Element LoadElement(string split)
        {
            return (Element)Enum.Parse(typeof(Element), split);
        }

        internal ConsoleMon Make(string monstertype)
        {
            return new ConsoleMon(templates[monstertype]);
        }
    }
}

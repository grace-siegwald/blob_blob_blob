using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Creatures_Creatures_Creatures_.Utility;

namespace Creatures_Creatures_Creatures_
{
    class World 
    {
        private int maxCreatures = 3;
        public List<Creature> Creatures = new List<Creature>();

        public World()
        {
            List<string> names = new List<string> { "Bob", "Lob", "Glob", "Pob", "Shlob", "Yob", "Tlob", "Cob" };
            List<string> colors = new List<string> { "Red", "Blue", "Green", "Yellow", "Purple", "Orange", "Pink", "Black" };
            for (int i = 0; i < maxCreatures; i++)
            {
                string name = names[GetRandomNumber(names.Count)];
                names.Remove(name); // remove the name from the list to ensure uniqueness
                Creatures.Add(
                    new Creature() 
                    { 
                        Name = name,
                        Color = colors[GetRandomNumber(colors.Count)],
                        ElementType = GetRandomEnumValue<ElementalType>(), 
                        Size = GetRandomNumber(3, 15) 
                    });
            }
            Creatures.Add(new MegaBlob() {Name = "Blarb", Color = "Rainbow", ElementType = ElementalType.Water, Size = 1000});
        }

        public string GetWorldCreatureInformation()
        {
            string output = "";
            foreach (Creature creature in Creatures)
            {
                output += $"{creature.Information()}\n";
                output += $"{creature.Eat()}\n";
                output += $"{creature.Speak()}\n\n";
            }
            return output;
        }

        public string ShowAbilities()
        {
            string output = "";
            foreach (Creature creature in Creatures)
            {
                output += $"{creature.Ability()}\n";
            } 
            return output;
        }
    }
}

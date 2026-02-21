using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatures_Creatures_Creatures_
{
    public enum ElementalType
    {
        Fire,
        Water,
        Earth,
        Air
    }
    public class Creature
    {
        private string name;
        private int size;
        private string color;
        private ElementalType elementType;
        private int hungerLevel;

        //public: can be changed anywhere. This is encapsulation, we can control how the properties are accessed and modified.
        public string Name { get => name; set => name = value; }
        public int Size { get => size; set => size = value; }
        public string Color { get => color; set => color = value; }
        public ElementalType ElementType { get => elementType; set => elementType = value; }

        
        public Creature(string name, int size, string color, ElementalType elementType)
        {
            Name = name;
            Size = size;
            Color = color;
            ElementType = this.elementType;
            hungerLevel = 0; // default hunger level
        }
        public Creature()
        {
            Name = "Unknown";
            Size = 0;
            Color = "Unknown";
            ElementType = ElementalType.Fire; // default elemental type
            hungerLevel = 0; // default hunger level
        }

        
        
        // seperation of concern, the method is only concerted with the logic, another place will deal with the presentation.
        public virtual string Eat()
        {
            if (hungerLevel >= 10)
            {
                return $"{Name} is full and cannot eat anymore!";
            }
            return $"{Name} is eating!";
        }   

        public virtual string Speak()
        {
            return $"{Name} is making a sound!";
        }

        public void Move()
        {

        }

        public void Sleep()
        {

        }

        public string Information()
        {
            return $"Name: {Name}, Size: {Size}, Color: {Color}, Elemental Type: {ElementType}";
        }

        public virtual string Ability()
        {
            return $"{Name} is using their boring old ability!";
        }
    }
}

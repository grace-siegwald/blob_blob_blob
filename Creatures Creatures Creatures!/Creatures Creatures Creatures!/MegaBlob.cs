using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatures_Creatures_Creatures_
{
    // Unicorn is a type of creature, it inherits all the properties and methods of Creature,
    // and can also have its own unique properties and methods.
    // the BASE class is Creature - parent class - super class (all valid terms)
    // the DERIVED class is Unicorn - child class - sub class (all valid terms)
    public class MegaBlob : Creature
    {
        public override string Eat()
        {
            return $"{Name} is eating a whole apple pie!!";
        }

        public override string Speak()
        {
            return base.Speak() + "It's a 'BLORP', how disgusting!";
        }

        public override string Ability()
        {
            return $"{Name} is flopping around like a big ol' blob!!";
        }
    }
}

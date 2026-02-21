using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatures_Creatures_Creatures_
{
    class Utility
    {
        public static Random randomNumberGenerator = new Random();
        public static int GetRandomNumber(int min, int max)
        {
            return randomNumberGenerator.Next(min, max);
        }

        // EXAPLE of expression bodied method!
        public static int GetRandomNumber(int max) => randomNumberGenerator.Next(max);

        //usage: Utility.GetRandomEnumValue<ElementalType>()
        public static T GetRandomEnumValue<T>() where T : Enum
        {
            Array values = Enum.GetValues(typeof(T));
            return (T)values.GetValue(randomNumberGenerator.Next(values.Length));
        }
    }
}

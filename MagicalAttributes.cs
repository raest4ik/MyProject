using System;

namespace MagicalGuardians
{
    public class MagicalAttributes
    {
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }

        public MagicalAttributes(int strength, int agility, int intelligence)
        {
            Strength = strength;
            Agility = agility;
            Intelligence = intelligence;
        }

        // Конструктор копирования
        public MagicalAttributes(MagicalAttributes source) : this(source.Strength, source.Agility, source.Intelligence)
        {
        }

        // Перегрузка метода ToString()
        public override string ToString() => $"Attributes [Strength: {Strength}, Agility: {Agility}, Intelligence: {Intelligence}]";
    }
}

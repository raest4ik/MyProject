namespace MagicalGuardians
{
    public class Monster
    {
        public string Name { get; set; }
        public double Health { get; set; }

        public Monster(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public override string ToString() => $"{Name} [Health: {Health}]";
    }
}

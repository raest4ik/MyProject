namespace MagicalGuardians
{
    public class Monster
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Monster(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public override string ToString() => $"{Name} [Health: {Health}]";
    }
}

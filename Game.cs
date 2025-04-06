using System;

namespace MagicalGuardians
{
    public class Game
    {
        public void StartGame()
        {
            Console.WriteLine("Добро пожаловать в игру 'Магические Стражи'!");

            // Создание магического существа
            Console.Write("Введите силу: ");
            int strength = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ловкость: ");
            int agility = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите интеллект: ");
            int intelligence = Convert.ToInt32(Console.ReadLine());

            MagicalAttributes attributes = new MagicalAttributes(strength, agility, intelligence);

            Console.WriteLine($"Атрибуты: {attributes}");

            // Создание монстра
            Monster monster = new Monster("Дракон", 100);
            Console.WriteLine($"Вы встретили {monster}!");

            // Битва с монстром
            while (monster.Health > 0)
            {
                Console.WriteLine("Выберите действие: 1 - Атака, 2 - Отступить");
                int action = Convert.ToInt32(Console.ReadLine());

                if (action == 1)
                {
                    monster.Health -= attributes.Strength;
                    Console.WriteLine($"Вы нанесли {attributes.Strength} урона.");
                    Console.WriteLine($"Здоровье монстра: {monster.Health}");
                }
                else if (action == 2)
                {
                    Console.WriteLine("Вы отступили.");
                    break;
                }
            }

            if (monster.Health <= 0)
            {
                Console.WriteLine("Вы победили монстра!");
            }
        }
    }
}

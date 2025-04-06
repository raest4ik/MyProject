using System;

namespace MagicalGuardians
{
    public class Game
    {
        public void StartGame()
        {
            while (true)
            {
                Console.Write("Введите 'play' для начала игры или 'stop' для выхода: ");
                string input = Console.ReadLine().ToLower();

                if (input == "stop")
                {
                    Console.WriteLine("Выход из игры.");
                    break;
                }
                else if (input == "play")
                {
                    // Создание магического существа
                    int strength = GetIntInput("Введите силу: ");
                    int agility = GetIntInput("Введите ловкость: ");
                    int intelligence = GetIntInput("Введите интеллект: ");

                    MagicalAttributes attributes = new MagicalAttributes(strength, agility, intelligence);

                    Console.WriteLine($"Атрибуты: {attributes}");

                    // Создание монстра
                    Monster monster = new Monster("Дракон", 100);
                    Console.WriteLine($"Вы встретили {monster}!");

                    // Битва с монстром
                    while (monster.Health > 0)
                    {
                        Console.WriteLine("Выберите действие: 1 - Атака, 2 - Отступить");
                        int action = GetIntInput("Введите действие: ");

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
                else
                {
                    Console.WriteLine("Недопустимый ввод. Попробуйте еще раз.");
                }
            }
        }

        private int GetIntInput(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Недопустимый ввод. Введите целое число.");
                }
            }
        }
    }
}

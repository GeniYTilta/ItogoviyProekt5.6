using System;

namespace ItogProekt_5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            UserWorksheet();
        }

        static (string name, string lastName, int age, string animal, int animalCount, int countColor) UserWorksheet()
        {
            (string name, string lastName, int age, string animal, int animalCount, int countColor) user;

            Console.WriteLine("Введите имя");
            user.name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            user.lastName = Console.ReadLine();

            Console.WriteLine("Введите возраст цифрами");
            user.age = int.Parse(Console.ReadLine());
            user.age = TryParse(user.age);

            Console.WriteLine("Есть ли у Вас питомцы? да или нет");
            user.animal = Console.ReadLine();
            if (user.animal == "да")
            {
                Console.WriteLine("Сколько питомцев?");
                user.animalCount = int.Parse(Console.ReadLine());
                user.animalCount = TryParse(user.animalCount);
                Count(user.animalCount);
            }
            else user.animalCount = 0;

            Console.WriteLine("Введите количество любимых цветов");
            user.countColor = int.Parse(Console.ReadLine());
            user.countColor = TryParse(user.countColor);
            Console.WriteLine("Введите любимые цвета");
            Count(user.countColor);

            PrintSheet(user.name, user.lastName, user.age, user.animal, user.animalCount, user.countColor);

            return user;
        }

        static string[] Count(int count)
        {
            string[] iCount = new string[count];
            for (int i = 0; i < iCount.Length; i++)
            {
                iCount[i] = Console.ReadLine();
            }
            Console.WriteLine("Вывод указанных значений:");
            for (int i = 0; i < iCount.Length; i++)
            {
                Console.WriteLine(iCount[i] + " ");
            }

            return iCount;
        }

        static int TryParse(int i)
        {
            if (i == 0)
            {
                Console.WriteLine("Вводимое число должно быть больше 0, введите число повторно:");
                i = int.Parse(Console.ReadLine());
                TryParse(i);
            }
            else if (i < 0)
            {
                Console.WriteLine("Вводимое число должно быть больше 0, введите число повторно:");
                i = int.Parse(Console.ReadLine());
                TryParse(i);
            }
            return i;
        }


        static void PrintSheet(string name, string lastName, int age, string animal, int animalCount, int countColor)
        {
            Console.WriteLine($"имя: {name}");
            Console.WriteLine($"фамилия: {lastName}");
            Console.WriteLine($"возраст: {age}");
            Console.WriteLine($"наличие животных: {animal}");
            Console.WriteLine($"Количество животных: {animalCount}");
            Console.WriteLine($"Количество любимых цветов: {countColor}");
        }

    }

}

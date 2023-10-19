using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportsmen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спортсмены";
            Random rand = new Random();
            string[,] table = new string[20, 6];
            for (int i = 0; i < 20; i++)
            {
                table[i, 0] = $"{i + 1}";
            }
            string[] name = new string[5] { "Иван Иванов", "Пётр Петров", "Семён Семёнов", "Алексей Смирнов", "Антон Антонов" };
            for (int i = 0; i < 20; i++)
            {
                table[i, 1] = name[rand.Next(0, name.Length)];
            }
            for (int i = 0; i < 20; i++)
            {
                table[i, 2] = $"{rand.Next(18, 48)}";
            }
            string[] nationality = new string[5] { "Русский", "Украинец", "Беларус", "Казах", "Болгария" };
            for (int i = 0; i < 20; i++)
            {
                table[i, 3] = nationality[rand.Next(0, nationality.Length)];
            }
            string[] sport = new string[5] { "Единоборства", "Фигурное катание", "Фехтование", "Прыжки в длину", "Прыжки в воду" };
            for (int i = 0; i < 20; i++)
            {
                table[i, 4] = sport[rand.Next(0, sport.Length)];
            }
            for (int i = 0; i < 20; i++)
            {
                table[i, 5] = $"{rand.Next(0, 11)}";
                if (table[i, 5] != "10")
                    table[i, 5] += $",{rand.Next(0, 10)}";
            }
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"{table[i, j]}  ");
                }
                Console.WriteLine("\n");
            }
            Choise(table);
        }
        static void Choise(string[,] table)
        {
            Console.WriteLine("Выберите имя:\n1. Иван Иванов   2.Пётр Петров   3. Семён Семёнов   " +
                                      "4. Алексей Смирнов   5. Антон Антонов");
            string inputName = Console.ReadLine();
            switch (inputName)
            {
                case "1":
                    inputName = "Иван Иванов";
                    break;
                case "2":
                    inputName = "Пётр Петров";
                    break;
                case "3":
                    inputName = "Семён Семёнов";
                    break;
                case "4":
                    inputName = "Алексей Смирнов";
                    break;
                case "5":
                    inputName = "Антон Антонов";
                    break;
                default:
                    Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                    Choise(table);
                    break;
            }
            Filter(table, inputName);
        }
        static void Filter(string[,] table, string inputName)
        {
            for (int i = 0; i < 20; i++)
            {
                if (table[i, 1] != inputName)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        table[i, j] = "";
                    }
                }
            }
            Console.Clear();
            for (int i = 0; i < 20; i++)
            {
                if (table[i, 1] != "")
                {
                    for (int j = 0; j < 6; j++)
                    {

                        Console.Write($"{table[i, j]}  ");
                    }
                    Console.WriteLine("\n");
                }
            }
            Sort(table);
        }
        static void Sort(string[,] table)
        {
            Console.WriteLine("\nПо какому параметру хотите отсортировать?\n1. Возраст    2. Национальность    3. Вид спорта");
            string inputSort = Console.ReadLine();
            switch (inputSort)
            {
                case "1":
                    Console.WriteLine("\n1. От большего к меньшему    2. От меньшего к большему");
                    inputSort = Console.ReadLine();
                    switch (inputSort)
                    {
                        case "1":
                            Console.Clear();
                            for (int year = 48; year >= 18; year--)
                            {
                                for (int i = 0; i < 20; i++)
                                {
                                    if (table[i, 1] != "")
                                    {
                                        if (year == Convert.ToInt32(table[i, 2]))
                                        {
                                            for (int j = 0; j < 6; j++)
                                            {
                                                Console.Write($"{table[i, j]}  ");
                                            }
                                            Console.WriteLine("\n");
                                        }
                                    }
                                }
                            }
                            break;
                        case "2":
                            Console.Clear();
                            for (int year = 18; year <= 48; year++)
                            {
                                for (int i = 0; i < 20; i++)
                                {
                                    if (table[i, 1] != "")
                                    {
                                        if (year == Convert.ToInt32(table[i, 2]))
                                        {
                                            for (int j = 0; j < 6; j++)
                                            {
                                                Console.Write($"{table[i, j]}  ");
                                            }
                                            Console.WriteLine("\n");
                                        }
                                    }
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                            Sort(table);
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine("\n1. От А до Я    2. От Я до А");
                    inputSort = Console.ReadLine();
                    switch (inputSort)
                    {
                        case "1":
                            Console.Clear();
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 3] == "Беларус")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 3] == "Болгария")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 3] == "Казах")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 3] == "Русский")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 3] == "Украинец")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            break;
                        case "2":
                            Console.Clear();
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 3] == "Украинец")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 3] == "Русский")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 3] == "Казах")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 3] == "Болгария")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 3] == "Беларус")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                            Sort(table);
                            break;
                    }
                    break;
                case "3":
                    Console.WriteLine("\n1. От А до Я    2. От Я до А");
                    inputSort = Console.ReadLine();
                    switch (inputSort)
                    {
                        case "1":
                            Console.Clear();
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 4] == "Единоборства")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 4] == "Прыжки в воду")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 4] == "Прыжки в длину")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 4] == "Фехтование")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 4] == "Фигурное катание")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            break;
                        case "2":
                            Console.Clear();
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 4] == "Фигурное катание")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 4] == "Фехтование")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 3] == "Прыжки в длину")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 4] == "Прыжки в воду")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 3] == "Единоборства")
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        Console.Write($"{table[i, j]}  ");
                                    }
                                    Console.WriteLine("\n");
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                            Sort(table);
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                    Sort(table);
                    break;
            }
        }
    }
}
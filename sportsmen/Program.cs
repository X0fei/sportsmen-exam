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
            Console.WriteLine("Выберите действие (напишите цифру и нажмите <Enter>)" +
                "\n1. Выборка   2. Выход");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Filter(table);
                    break;
                case "2":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                    Choise(table);
                    break;
            }
        }
        static void Filter(string[,] table)
        {
            string input;
            string nationality = "";
            Console.WriteLine("\nПо какому параметру хотите отфильтровать?" +
                              "\n1. Имя    2. Возраст    3. Национальность    4. Вид спорта    5. Балл");
            string inputSort = Console.ReadLine();
            switch (inputSort)
            {
                case "1":
                    Console.WriteLine("Выберите имя:\n1. Иван Иванов   2.Пётр Петров   3. Семён Семёнов   " +
                                      "4. Алексей Смирнов   5. Антон Антонов");
                    input = Console.ReadLine();
                    if (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
                    {
                        Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                        Choise(table);
                    }
                    else
                        Sort(table, input, inputSort, nationality);
                    break;
                case "2":

                    break;
                case "3":
                    Console.WriteLine("Выберите национальность:\n1. Русский   2.Украинец   3. Беларус   " +
                                      "4. Казах   5. Болгария");
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            nationality = "Русский";
                            Sort(table, input, inputSort, nationality);
                            break;
                        case "2":
                            nationality = "Украинец";
                            Sort(table, input, inputSort, nationality);
                            break;
                        case "3":
                            nationality = "Беларус";
                            Sort(table, input, inputSort, nationality);
                            break;
                        case "4":
                            nationality = "Казах";
                            Sort(table, input, inputSort, nationality);
                            break;
                        case "5":
                            nationality = "Болгария";
                            Sort(table, input, inputSort, nationality);
                            break;
                        default:
                            Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                            Choise(table);
                            break;
                    }
                    break;
                case "4":

                    break;
                case "5":

                    break;
                default:
                    Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                    Filter(table);
                    break;
            }
        }
        static void Sort(string[,] table, string input, string inputSort, string nationality)
        {
            Console.WriteLine("Хотите отсортировать список?\n1. Да    2. Нет");
            string input2 = Console.ReadLine();
            switch (input2)
            {
                case "1":
                    switch (inputSort)
                    {
                        case "1":
                            //Console.WriteLine("\nПо какому параметру хотите отсортировать?" +
                            //                  "\n1. Возраст    2. Национальность    3. Вид спорта    4. Балл");
                            //input2 = Console.ReadLine();
                            //switch (input2)
                            //{
                            //    case "1":
                            //        Console.WriteLine("1. От большего к меньшему    2. От меньшего к большему");
                            //        input2 = Console.ReadLine();
                            //        switch (input2)
                            //        {
                            //            case "1":
                            //                Console.Clear();
                            //                for (int year = 48; year >= 18; year--)
                            //                {
                            //                    for (int i = 0; i < 20; i++)
                            //                    {
                            //                        if (year == Convert.ToInt32(table[i, 2]))
                            //                        {
                            //                            switch (input)
                            //                            {
                            //                                case "1":
                            //                                    if (table[i, 1] == "Иван Иванов")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                                case "2":
                            //                                    if (table[i, 1] == "Пётр Петров")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                                case "3":
                            //                                    if (table[i, 1] == "Семён Семёнов")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                                case "4":
                            //                                    if (table[i, 1] == "Алексей Смирнов")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                                case "5":
                            //                                    if (table[i, 1] == "Антон Антонов")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                            }
                            //                        }
                            //                    }
                            //                }
                            //                break;
                            //            case "2":
                            //                Console.Clear();
                            //                for (int year = 18; year <= 48; year++)
                            //                {
                            //                    for (int i = 0; i < 20; i++)
                            //                    {
                            //                        if (year == Convert.ToInt32(table[i, 2]))
                            //                        {
                            //                            switch (input)
                            //                            {
                            //                                case "1":
                            //                                    if (table[i, 1] == "Иван Иванов")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                                case "2":
                            //                                    if (table[i, 1] == "Пётр Петров")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                                case "3":
                            //                                    if (table[i, 1] == "Семён Семёнов")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                                case "4":
                            //                                    if (table[i, 1] == "Алексей Смирнов")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                                case "5":
                            //                                    if (table[i, 1] == "Антон Антонов")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                            }
                            //                        }
                            //                    }
                            //                }
                            //                break;
                            //            default:
                            //                Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                            //                Sort(table, input, inputSort);
                            //                break;
                            //        }
                            //        break;
                            //    case "2":
                            //        Console.WriteLine("1. От А до Я    2. От Я до А");
                            //        input2 = Console.ReadLine();
                            //        switch (input2)
                            //        {
                            //            case "1":
                            //                Console.Clear();
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 3] == "Беларус")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 3] == "Болгария")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 3] == "Казах")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 3] == "Русский")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 3] == "Украинец")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                break;
                            //            case "2":
                            //                Console.Clear();
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 3] == "Украинец")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 3] == "Русский")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 3] == "Казах")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 3] == "Болгария")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 3] == "Беларус")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                break;
                            //            default:
                            //                Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                            //                Sort(table, input, inputSort);
                            //                break;
                            //        }
                            //        break;
                            //    case "3":
                            //        Console.WriteLine("1. От А до Я    2. От Я до А");
                            //        input2 = Console.ReadLine();
                            //        switch (input2)
                            //        {
                            //            case "1":
                            //                Console.Clear();
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 4] == "Единоборства")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 4] == "Прыжки в воду")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 4] == "Прыжки в длину")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 4] == "Фехтование")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 4] == "Фигурное катание")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                break;
                            //            case "2":
                            //                Console.Clear();
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 4] == "Фигурное катание")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 4] == "Фехтование")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 3] == "Прыжки в длину")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 4] == "Прыжки в воду")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                for (int i = 0; i < 20; i++)
                            //                {
                            //                    if (table[i, 3] == "Единоборства")
                            //                    {
                            //                        switch (input)
                            //                        {
                            //                            case "1":
                            //                                if (table[i, 1] == "Иван Иванов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "2":
                            //                                if (table[i, 1] == "Пётр Петров")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "3":
                            //                                if (table[i, 1] == "Семён Семёнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "4":
                            //                                if (table[i, 1] == "Алексей Смирнов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                            case "5":
                            //                                if (table[i, 1] == "Антон Антонов")
                            //                                {
                            //                                    for (int j = 0; j < 6; j++)
                            //                                    {
                            //                                        Console.Write($"{table[i, j]}  ");
                            //                                    }
                            //                                    Console.WriteLine("\n");
                            //                                }
                            //                                break;
                            //                        }
                            //                    }
                            //                }
                            //                break;
                            //            default:
                            //                Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                            //                Sort(table, input, inputSort);
                            //                break;
                            //        }
                            //        break;
                            //    case "4":
                            //        Console.WriteLine("1. От большего к меньшему    2. От меньшего к большему");
                            //        input2 = Console.ReadLine();
                            //        switch (input2)
                            //        {
                            //            case "1":
                            //                Console.Clear();
                            //                for (double mark = 10; mark >= 0; mark -= 0.1)
                            //                {
                            //                    for (int i = 0; i < 20; i++)
                            //                    {
                            //                        if (mark == Double.Parse(table[i, 5]))
                            //                        {
                            //                            switch (input)
                            //                            {
                            //                                case "1":
                            //                                    if (table[i, 1] == "Иван Иванов")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                                case "2":
                            //                                    if (table[i, 1] == "Пётр Петров")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                                case "3":
                            //                                    if (table[i, 1] == "Семён Семёнов")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                                case "4":
                            //                                    if (table[i, 1] == "Алексей Смирнов")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                                case "5":
                            //                                    if (table[i, 1] == "Антон Антонов")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                            }
                            //                        }
                            //                    }
                            //                }
                            //                break;
                            //            case "2":
                            //                Console.Clear();
                            //                for (double mark = 0; mark <= 10; mark += 0.1)
                            //                {
                            //                    for (int i = 0; i < 20; i++)
                            //                    {
                            //                        if (mark == Double.Parse(table[i, 5]))
                            //                        {
                            //                            switch (input)
                            //                            {
                            //                                case "1":
                            //                                    if (table[i, 1] == "Иван Иванов")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                                case "2":
                            //                                    if (table[i, 1] == "Пётр Петров")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                                case "3":
                            //                                    if (table[i, 1] == "Семён Семёнов")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                                case "4":
                            //                                    if (table[i, 1] == "Алексей Смирнов")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                                case "5":
                            //                                    if (table[i, 1] == "Антон Антонов")
                            //                                    {
                            //                                        for (int j = 0; j < 6; j++)
                            //                                        {
                            //                                            Console.Write($"{table[i, j]}  ");
                            //                                        }
                            //                                        Console.WriteLine("\n");
                            //                                    }
                            //                                    break;
                            //                            }
                            //                        }
                            //                    }
                            //                }
                            //                break;
                            //            default:
                            //                Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                            //                Sort(table, input, inputSort);
                            //                break;
                            //        }
                            //        break;
                            //    default:
                            //        Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                            //        Sort(table, input, inputSort);
                            //        break;
                            //}
                            break;
                        case "2":

                            break;
                        case "3":
                            for (int i = 0; i < 20; i++)
                            {
                                if (table[i, 3] != nationality)
                                {
                                    for (int j = 0; j < 6; j++)
                                    {
                                        table[i, j] = "";
                                    }
                                }
                            }
                            for (int i = 0; i < 20; i++)
                            {
                                for (int j = 0; j < 6; j++)
                                {
                                    if (table[i, j] != "")
                                        Console.Write($"{table[i, j]}  ");
                                }
                                Console.WriteLine("\n");
                            }
                            break;
                        case "4":

                            break;
                        case "5":

                            break;
                        default:
                            Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                            Filter(table);
                            break;
                    }

                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                    Sort(table, input, inputSort, nationality);
                    break;
            }
        }
    }
}
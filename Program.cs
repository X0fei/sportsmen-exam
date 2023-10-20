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
            string[] name = new string[5] { "Иван Иванов", "Пётр Петров", "Семён Семёнов", "Алексей Смирнов", "Антон Антонов" };
            string[] nationality = new string[5] { "Беларус", "Болгария", "Казах", "Русский", "Украинец" };
            string[] sport = new string[5] { "Единоборства", "Прыжки в воду", "Прыжки в длину", "Фехтование", "Фигурное катание" };
            for (int i = 0; i < 20; i++)
            {
                table[i, 0] = $"{i + 1}";
                table[i, 1] = name[rand.Next(0, name.Length)];
                table[i, 2] = $"{rand.Next(18, 48)}";
                table[i, 3] = nationality[rand.Next(0, nationality.Length)];
                table[i, 4] = sport[rand.Next(0, sport.Length)];
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
            Choise(table, name, nationality, sport);
        }
        static void Choise(string[,] table, string[] name, string[] nationality, string[] sport)
        {
            Console.WriteLine($"Выберите имя:\n1. {name[0]}   2. {name[1]}   3. {name[2]}   4. {name[3]}   5. {name[4]}");
            string inputName = Console.ReadLine();
            if (inputName != "1" && inputName != "2" && inputName != "3" && inputName != "4" && inputName != "5")
            {
                Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                Choise(table, name, nationality, sport);
            }
            else
                Filter(table, inputName, name, nationality, sport);
        }
        static void Filter(string[,] table, string inputName, string[] name, string[] nationality, string[] sport)
        {
            for (int i = 0; i < 20; i++)
            {
                if (table[i, 1] != name[Convert.ToInt32(inputName) - 1])
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
            Sort(table, nationality, sport);
        }
        static void SortYear(string[,] table, int year)
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
        static void SortNationality(string[,] table, string[] nationality, string inputSort)
        {
            if (inputSort == "1")
            {
                for (int id = 0; id < 5; id++)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        if (table[i, 3] == nationality[id])
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
            else
            {
                for (int id = 4; id >= 0; id--)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        if (table[i, 3] == nationality[id])
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
        }
        static void SortSport(string[,] table, string[] sport, string inputSort)
        {
            if (inputSort == "1")
            {
                for (int id = 0; id < 5; id++)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        if (table[i, 4] == sport[id])
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
            else
            {
                for (int id = 4; id >= 0; id--)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        if (table[i, 4] == sport[id])
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
        }
        static void Sort(string[,] table, string[] nationality, string[] sport)
        {
            Console.WriteLine("\nПо какому параметру хотите отсортировать?\n1. Возраст    2. Национальность    3. Вид спорта");
            string inputSort = Console.ReadLine();
            switch (inputSort)
            {
                case "1":
                    Console.WriteLine("1. От большего к меньшему    2. От меньшего к большему");
                    inputSort = Console.ReadLine();
                    if (inputSort == "1")
                    {
                        Console.Clear();
                        for (int year = 48; year >= 18; year--)
                        {
                            SortYear(table, year);
                        }
                    }
                    else if (inputSort == "2")
                    {
                        Console.Clear();
                        for (int year = 18; year <= 48; year++)
                        {
                            SortYear(table, year);
                        }
                    }
                    else
                    {
                        Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                        Sort(table, nationality, sport);
                    }
                    break;
                case "2":
                    Console.WriteLine("1. От А до Я    2. От Я до А");
                    inputSort = Console.ReadLine();
                    if (inputSort == "1")
                    {
                        Console.Clear();
                        SortNationality(table, nationality, inputSort);
                    }
                    else if (inputSort == "2")
                    {
                        Console.Clear();
                        SortNationality(table, nationality, inputSort);
                    }
                    else
                    {
                        Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                        Sort(table, nationality, sport);
                    }
                    break;
                case "3":
                    Console.WriteLine("1. От А до Я    2. От Я до А");
                    inputSort = Console.ReadLine();
                    if (inputSort == "1")
                    {
                        Console.Clear();
                        SortSport(table, sport, inputSort);
                    }
                    else if (inputSort == "2")
                    {
                        Console.Clear();
                        SortSport(table, sport, inputSort);
                    }
                    else
                    {
                        Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                        Sort(table, nationality, sport);
                    }
                    break;
                default:
                    Console.WriteLine("ОШИБКА!!! Попробуйте ещё раз\n");
                    Sort(table, nationality, sport);
                    break;
            }
        }
    }
}
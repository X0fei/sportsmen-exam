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
                switch (table[i, 1])
                {
                    case "Иван Иванов":
                        table[i, 3] = "Русский";
                        break;
                    case "Пётр Петров":
                        table[i, 3] = "Украинец";
                        break;
                    case "Семён Семёнов":
                        table[i, 3] = "Беларус";
                        break;
                    case "Алексей Смирнов":
                        table[i, 3] = "Казах";
                        break;
                    case "Антон Антонов":
                        table[i, 3] = "Болгария";
                        break;
                    default:
                        table[i, 3] = "---";
                        break;
                }
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
            Choise();
        }
        static void Choise()
        {
            Console.WriteLine("Выберите действие (напишите цифру и нажмите <Enter>)" +
                "\n1.Выборка   2.Сортировка   3.Выход\n");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "3":

                    break;
                default:
                    Console.WriteLine("\n!!!ОШИБКА!!!\nПопробуйте ещё раз\n");
                    Choise();
                    break;
            }
        }
    }
}
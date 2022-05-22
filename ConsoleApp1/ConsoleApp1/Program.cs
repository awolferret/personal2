using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> workers = new Dictionary<string, string>();
            workers.Add("Ivan", "Ceo");
            workers.Add("Petr", "HR");
            workers.Add("Vasiliy", "Cteo");
            bool isWorking = true;

            while (isWorking)
            {
                Console.Clear();
                Console.WriteLine("Список команд:");
                Console.WriteLine("1.Добавить досье");
                Console.WriteLine("2.Показать все досье");
                Console.WriteLine("3.Удалить досье");
                Console.WriteLine("4.Выход");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddDossier(workers);
                        break;
                    case "2":
                        ShowList(workers);
                        break;
                    case "3":
                        DeleteDossier(workers);
                        break;
                    case "4":
                        Exit(ref isWorking);
                        break;
                    default :
                        Console.WriteLine("Команда не распознана");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void AddDossier(Dictionary<string, string> workers)
        {
            Console.WriteLine("Ведите ФИО");
            string name = Console.ReadLine();
            Console.WriteLine("Ведите ФИО");
            string position = Console.ReadLine();
            workers.Add(name, position);
        }

        static void ShowList(Dictionary<string, string> workers)
        {
            foreach (var worker in workers)
            {
                Console.WriteLine($"{worker.Key} - {worker.Value}");
            }

            Console.WriteLine("\nОжидается ввод для продолжения");
            Console.ReadKey();
        }

        static void DeleteDossier(Dictionary<string, string> workers)
        {
            Console.WriteLine("Какое досье вы хотите удалить?");
            string input = Console.ReadLine();

            if (workers.ContainsKey(input))
            {
                workers.Remove(input);
            }
            else
            {
                Console.WriteLine("Не обнаруженно");
                Console.ReadKey();
            }

        }

        static void Exit(ref bool isWorking)
        {
            isWorking = false;
        }
    }
}
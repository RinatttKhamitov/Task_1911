using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task_1911
{
    class Program
    {
        static List<string> nameOfAllCountry = new List<string>() { "Россия", "Франция", "Китай", "Украина" };
        static void Main(string[] args)
        {
            List<Game> defaultGames = new List<Game>() { new Game("Пляж"), new Game("Мышеловка"), new Game("Море"), new Game("Рыбалка"), new Game("Почтальоны"), new Game("Горка") };

            Organizer organizer = new Organizer("Оливье Ганьян", defaultGames);
            // List<Team> teams = new List<Team>() { CreateTeam(), CreateTeam(), CreateTeam(), CreateTeam() };
            List<Team> teams = new List<Team>() { Test(), Test(), Test(), Test() };
            BigRaces bigRaces = new BigRaces(organizer, teams);
            string command = "0";
            while (!command.Equals("6"))
            {
                Console.Clear();
                Console.WriteLine("Команды: 1) Получить участников страны 2) Начать играть \n3) Получить статистику побед/поражений страны 4) Создать новую игру \n5) Получить список игр 6) Выйти");
                Console.WriteLine();
                
                switch (command)
                {
                    case "1":
                        bigRaces.PrintMembers();
                        break;
                    case "2":
                        bigRaces.PlayGame();
                        break;
                    case "3":
                        bigRaces.PrintStatistic();
                        break;
                    case "4":
                        Console.WriteLine("Введи название игры");
                        organizer.CreateNewGame(Console.ReadLine());
                        break;
                    case "5":
                        organizer.PrintAllGames();
                        break;


                }
                command = Console.ReadLine();

            }


        }

        static public Team Test()
        {
            string number = Console.ReadLine();
            string nameC = nameOfAllCountry[0];
            return new Team(Testt(number), nameC);
        }
        static public List<Human> Testt(string numberOFCountry)
        {
            List<string> names = new StreamReader($"{nameOfAllCountry[int.Parse(numberOFCountry) - 1]}.txt").ReadLine().Split(new char[] { ':' }).ToList();
            int command = 0;
            List<Human> allMembers = new List<Human>();
            while (allMembers.Count != 15)
            {
                allMembers.Add(new Human(names[command]));
                names.Remove(names[command]);
                Console.Clear();
            }
            Console.WriteLine($"команда <<{nameOfAllCountry[int.Parse(numberOFCountry) - 1]}>>");
            foreach (Human name in allMembers)
            {
                Console.WriteLine(name.name);
            }
            nameOfAllCountry.Remove(nameOfAllCountry[int.Parse(numberOFCountry) - 1]);
            return allMembers;
        }
        static public Team CreateTeam()
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Выбери номер страны");
            for (int i = 0; i < nameOfAllCountry.Count; i++)
            {
                Console.Write($"{i + 1} <<{nameOfAllCountry[i]}>> ");
            }
            string number = Console.ReadLine();
            string nameC = nameOfAllCountry[int.Parse(number) - 1];
            return new Team(CreateAllMembersTeam(number), nameC);



        }
        static public List<Human> CreateAllMembersTeam(string numberOFCountry)
        {
            List<string> names = new StreamReader($"{nameOfAllCountry[int.Parse(numberOFCountry) - 1]}.txt").ReadLine().Split(new char[] { ':' }).ToList();
            ;
            List<Human> allMembers = new List<Human>();
            while (allMembers.Count != 15)
            {
                Console.WriteLine("Выбери номер спортсмена");
                for (int i = 0; i < names.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {names[i]}");
                }
                string command = Console.ReadLine();
                allMembers.Add(new Human(names[int.Parse(command) - 1]));
                names.Remove(names[int.Parse(command) - 1]);
                Console.Clear();
            }
            Console.WriteLine($"команда <<{nameOfAllCountry[int.Parse(numberOFCountry) - 1]}>>");
            foreach (Human name in allMembers)
            {
                Console.WriteLine(name.name);
            }
            nameOfAllCountry.Remove(nameOfAllCountry[int.Parse(numberOFCountry) - 1]);
            return allMembers;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1911
{
    class BigRaces
    {

        List<Team> allTeams;
        Organizer organizer;
        Game lastGame;
        public BigRaces(Organizer organizer, List<Team> allTeams)
        {
            this.organizer = organizer;
            this.allTeams = allTeams;
        }

        public void PlayGame()
        {
            SelectGame();

            Console.WriteLine("(<< Россия >>, << Франция >>, << Китай >>, << Украина >>)");
            Console.Write("Выбери первую команду, которая будет играть: ");
            string nameTeam1 = Console.ReadLine();
            Team team1 = SelectTeam(nameTeam1);

            Console.Write("Выбери вторую команду, которая будет играть: ");
            string nameTeam2 = Console.ReadLine();
            Team team2 = SelectTeam(nameTeam1);

            Random random = new Random();
            int winTeam = random.Next(1,3);
            
            switch (winTeam)
            {
                case 1:
                    team1.countWins += 1;
                    team2.countLose += 1;
                    Console.WriteLine($"Команда {team1.nameOfTheCountry} выиграла");

                    break;
                case 2:
                    team2.countWins += 1;
                    team1.countLose += 1;
                    Console.WriteLine($"Команда {team2.nameOfTheCountry} выиграла");

                    break;
            }
            
        }
        public Team SelectTeam(string name)
        {

            Team needTeam = null;
            foreach (Team team in allTeams)
            {
                if (team.nameOfTheCountry.Equals(name))
                {
                    needTeam = team;
                    break;
                }
            }
            return needTeam;
        }
        public void PrintMembers()
        {
            Console.WriteLine("Выбери команду (<<Россия>>, <<Франция>>, <<Китай>>, <<Украина>>)");
            Team team = SelectTeam(Console.ReadLine());
            if (team == null)
            {
                Console.WriteLine("Ошибка!!!");
                return;
            }
            foreach (Human human in team.allMembers)
            {
                Console.WriteLine(human.name);
            }
        }
        public void SelectGame()
        {
            Console.WriteLine("Выбери номер игры: \n");
            int k = 0;
            foreach (Game game in organizer.allGames)
            {
                k++;
                Console.WriteLine($"{k}) {game.nameOfTheGame}");
            }
            string com = Console.ReadLine();
            lastGame = organizer.allGames[int.Parse(com) - 1];
            organizer.allGames.Remove(organizer.allGames[int.Parse(com) - 1]);
        }
        public void PrintStatistic()
        {
            Console.WriteLine("Выбери команду (<<Россия>>, <<Франция>>, <<Китай>>, <<Украина>>)");
            Team team = SelectTeam(Console.ReadLine());
            Console.WriteLine($"Команда <<{team.nameOfTheCountry}>>");
            Console.WriteLine($"Побед - {team.countWins}");
            Console.WriteLine($"поражений - {team.countLose}");
        }
    }
}

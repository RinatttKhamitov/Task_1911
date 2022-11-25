using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1911
{
    class Organizer
    {
        public List<Game> allGames = new List<Game>();
        public string name;
        public void CreateNewGame(string name)
        {
            allGames.Add(new Game(name));
        }
        public Organizer(string name,List<Game> allGames)
        {
            this.name = name;
            this.allGames = allGames;
        }
        public void PrintAllGames()
        {
            int k = 0;
            foreach (Game game in  allGames)
            {
                k++;
                Console.WriteLine($"{k}) {game.nameOfTheGame}");
            }
        }

    }
}

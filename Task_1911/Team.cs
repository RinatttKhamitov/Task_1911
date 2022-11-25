using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1911
{
    class Team
    {
        public List<Human> allMembers;
        public string nameOfTheCountry;
        public int countWins;
        public int countLose;

        public Team(List<Human> allMembers, string nameOfTheCountry) 
        {
            this.allMembers = allMembers;
            this.nameOfTheCountry = nameOfTheCountry;
            countLose = 0;
            countWins = 0;
        }


    }
}

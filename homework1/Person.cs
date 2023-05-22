using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
   public class Person
    {


        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }


    public class FootballPlayer : Person
    {
        private int number;
        private double height;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
    }


    public class Goalkeeper : FootballPlayer
    {
    }


    public class Defender : FootballPlayer
    {
    }


    public class Midfield : FootballPlayer
    {
    }


    public class Striker : FootballPlayer
    {
    }


    public class Coach : Person
    {
    }


    public class Referee : Person
    {
    }


    public class Team
    {
        public Coach coach;
        public List<FootballPlayer> players;

        public Coach Coach
        {
            get { return coach; }
            set { coach = value; }
        }

        public List<FootballPlayer> Players
        {
            get { return players; }
            set { players = value; }
        }

        public double GetAveragePlayerAge()
        {
            if (players.Count == 0)
                return 0;

            int totalAge = 0;
            foreach (var player in players)
            {
                totalAge += player.Age;
            }
            return (double)totalAge / players.Count;
        }
    }


    public class Game
    {
        public Team team1;
        public Team team2;
        public Referee referee;
        public List<AssistantReferee> assistantReferees;
        public List<Goal> goals;
        public string result;
        public Team winner;

        public Team Team1
        {
            get { return team1; }
            set { team1 = value; }
        }

        public Team Team2
        {
            get { return team2; }
            set { team2 = value; }
        }

        public Referee Referee
        {
            get { return referee; }
            set { referee = value; }
        }

        public List<AssistantReferee> AssistantReferees
        {
            get { return assistantReferees; }
            set { assistantReferees = value; }
        }

        public List<Goal> Goals
        {
            get { return goals; }
            set { goals = value; }
        }

        public string Result
        {
            get { return result; }
            set { result = value; }
        }

        public Team Winner
        {
            get { return winner; }
            set { winner = value; }
        }
    }


    public class AssistantReferee : Person
    {
    }


    public class Goal
    {
        private int minute;
        private FootballPlayer player;

        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }

       
    }

}



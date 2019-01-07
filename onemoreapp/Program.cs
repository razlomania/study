using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace onemoreapp
{
    class Book
    {
        public Book(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }

    class Library
    {
        private Book[] books;

        public Library()
        {
            books = new Book[] { new Book("Milligan"), new Book("Tesla"), new Book("Mask") };
        }

        public int Length => books.Length;

        public Book this[int index]
        {
            get => books[index];
            set
            {
                books[index] = value;
            }
        }

        public IEnumerable GetBooks(int max)
        {
            for (int i = 0; i < max; i++)
            {
                if (i == books.Length)
                {
                    yield break;
                }
                yield return books[i];
            }
        }
    }
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }
        public User()
        {
            Languages = new List<string>();
        }
    }

    class Phone
    {
        public string Name { get; set; }
        public string Company { get; set; }
    }

    class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
    }
    class Team
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User {Name="Tom", Age=23, Languages = new List<string> {"english", "deutch" }},
                new User {Name="Bob", Age=27, Languages = new List<string> {"english", "french" }},
                new User {Name="John", Age=29, Languages = new List<string> { "english", "spanish" }},
                new User {Name="Elis", Age=24, Languages = new List<string> { "spanish", "deutch" }}
            };

            List<Phone> phones = new List<Phone>
            {
                new Phone {Name="Lumia 430", Company="Microsoft" },
                new Phone {Name="Mi 5", Company="Xiaomi" },
                new Phone {Name="LG G 3", Company="LG" },
                new Phone {Name="iPhone 5", Company="Apple" },
                new Phone {Name="Lumia 930", Company="Microsoft" },
                new Phone {Name="iPhone 6", Company="Apple" },
                new Phone {Name="Lumia 630", Company="Microsoft" },
                new Phone {Name="LG G 4", Company="LG" }
            };

            List<Team> teams = new List<Team>()
            {
                new Team { Name = "Bavariya", Country ="Germany" },
                new Team { Name = "Barcelona", Country ="Spain" }
            };

            List<Player> players = new List<Player>()
            {
                new Player {Name="Messi", Team="Barcelona"},
                new Player {Name="Suarez", Team="Barcelona"},
                new Player {Name="Robben", Team="Bavariya"}
            };

            var result = players.Join(teams,
                p => p.Team,
                t => t.Name,
                (p, t) => new {Name = p.Name, Team = t.Name, Country = t.Country});

            var resultTeams = teams.GroupJoin(
                players,
                t => t.Name,
                p => p.Team,
                (team, pls) => new
                {
                    Name = team.Name,
                    Country = team.Country,
                    Players = pls.Select(p => p.Name)
                });


            var selectedUsers = users.Where(u => u.Age > 25);

            var temp = users.SelectMany(
                    u => u.Languages,
                    (u, l) => new { User = u, Lang = l }
                 ).ToList();
            var selectedUsers2 = temp.Where(u => u.Lang == "english" && u.User.Age < 28)
                .Select(u => u.User);

            var selectedPhones = phones.GroupBy(p => p.Company)
                .Select(g => new
                {
                    Name = g.Key,
                    Count = g.Count(),
                    Phones = g.Select(p => p)
                });

            foreach (var team in resultTeams)
            {
                WriteLine(team.Name);
                foreach (string player in team.Players)
                {
                    WriteLine(player);
                }
                WriteLine();
            }

            ReadKey();
        }
    }
}

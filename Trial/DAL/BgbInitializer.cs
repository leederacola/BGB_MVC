using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Trial.Models;

namespace Trial.DAL
{
    public class BgbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BgbContext>
    {
        protected override void Seed(BgbContext context)
        {
            var users = new List<User>
            {
                new User {Name = "Ryan" },
                new User {Name = "Andrea" },
                new User {Name = "Aaron" },
                new User {Name = "James" }
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            var games = new List<Game>
            {
                new Game { Title = "Blood Rage", Rating = 7, ReleaseDate = 2016, MaxPlayer = 5, MinPLayer = 2, AvgPlayTime = 2 },
                new Game { Title = "Lost Cities", Rating = 9},
                new Game { Title = "Arkham Horror LCG", Rating = 7},
                new Game { Title = "Patchwork", Rating = 8},
                new Game { Title = "Cosmic Encounters", Rating = 10},
                new Game { Title = "Lagendary Encounters: Alien", Rating = 8},
                new Game { Title = "Codenames", Rating = 8},
                new Game { Title = "Pandemic", Rating = 7},
                new Game { Title = "Ticket to Ride", Rating = 7},
                new Game { Title = "Small World", Rating = 6},
                new Game { Title = "Love Letter Batman", Rating = 9},

            };
            games.ForEach(g => context.Games.Add(g));
            context.SaveChanges();


            var collections = new List<Collection>
            {
                // new up some collections here!              
                // this is how Games are tied to users.
                new Collection {UserID = 1, GameID= 1},
                new Collection {UserID = 1, GameID= 2},
                new Collection {UserID = 1, GameID= 3},
                new Collection {UserID = 1, GameID= 4},
                new Collection {UserID = 1, GameID= 5},
                new Collection {UserID = 1, GameID= 6},
                new Collection {UserID = 2, GameID= 5},
                new Collection {UserID = 2, GameID= 9},
                new Collection {UserID = 2, GameID= 1},
                new Collection {UserID = 3, GameID= 4},
                new Collection {UserID = 3, GameID= 2}
            };
            collections.ForEach(c => context.Collections.Add(c));
            context.SaveChanges();
        }
    }
}
#region Using

using System;
using System.Collections.Generic;
using System.Linq;
using SAP.API.Common.Entities.People;

#endregion

namespace SAP.API.DataAccess.Repositories
{
    internal sealed class PlayersRepository : IRepository<Player>
    {
        #region Private Fileds

        private readonly IEnumerable<Player> _players;

        #endregion

        #region Constructor

        public PlayersRepository()
        {
            _players = new List<Player>
            {
                new Player
                {
                    Id = 1,
                    Age = 20,
                    FirstName = "Bob",
                    LastName = "Bobrov",
                    TeamId = 1
                },
                new Player
                {
                    Id = 2,
                    Age = 22,
                    FirstName = "Sasha",
                    LastName = "Voronov",
                    TeamId = 2
                },
                new Player
                {
                    Id = 3,
                    Age = 26,
                    FirstName = "Vova",
                    LastName = "Kozinov",
                    TeamId = 1
                },
                new Player
                {
                    Id = 4,
                    Age = 10,
                    FirstName = "Leha",
                    LastName = "Popov",
                    TeamId = 3
                },
            };
        }

        #endregion

        #region IRepository Implementation

        public IEnumerable<Player> FindBy(Predicate<Player> predicate)
        {
            return _players.Where(x => predicate(x));
        }

        public Player Get(int id)
        {
            return _players.FirstOrDefault(x => x.Id == id);
        }

        public void Remove(int id)
        {
        }

        public void Save(Player item)
        {
        }

        #endregion
    }
}

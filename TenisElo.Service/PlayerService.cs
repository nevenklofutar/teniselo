using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenisElo.Entities.Model;
using TenisElo.Repository;

namespace TenisElo.Service
{
    public class PlayerService : IPlayerService
    {
        private IRepository<Player> playerRepository;

        public PlayerService(IRepository<Player> playerRepository)
        {
            this.playerRepository = playerRepository;
        }

        public void AddPlayer(Player player)
        {
            playerRepository.Add(player);
        }

        public void DeletePlayer(Player player)
        {
            playerRepository.Remove(player);
        }

        public List<Player> FindPlayerByName(string name)
        {
            List<Player> players = playerRepository.Find(p => p.FirstName.Contains(name) || p.LastName.Contains(name)).ToList();

            return players;
        }

        public List<Player> GetAllPlayers()
        {
            return playerRepository.GetAll().ToList();
        }

        public Player GetPlayer(int id)
        {
            return playerRepository.Get(id);
        }


    }
}

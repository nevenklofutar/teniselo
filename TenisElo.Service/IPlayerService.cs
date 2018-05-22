using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TenisElo.Entities.Model;

namespace TenisElo.Service
{
    public interface IPlayerService
    {
        void AddPlayer(Player player);
        List<Player> GetAllPlayers();
        Player GetPlayer(int id);
        //void UpdatePlayer(Player player);
        void DeletePlayer(Player player);

        List<Player> FindPlayerByName(string name);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TenisElo.Entities.Model;
using TenisElo.Service;

namespace TenisElo.Web.Controllers
{
    public class PlayersController : Controller
    {
        private readonly IPlayerService _playerService;

        public PlayersController(IPlayerService playerService)
        {
            this._playerService = playerService;
        }

        // GET: /players/index
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // GET: /players/details/1
        [HttpGet]
        public ActionResult Details(int id)
        {
            Player player = _playerService.GetPlayer(id);

            return View(player);
        }

        // GET: /players/search/search_name
        [HttpGet]
        public ActionResult Search(string search_players)
        {
            return View(_playerService.FindPlayerByName(search_players));
        }

        // POST /players/search
        [HttpPost]
        public ActionResult Search(string search_players, string search_players_id)
        {
            // if no player id is sent, redirect to view with search results in table
            if (string.IsNullOrEmpty(search_players_id))
            {
                return RedirectToAction("Search", new { search_players });
            }
            // else redirect to player details
            else
            {
                return RedirectToAction("Details", new { id = search_players_id });
            }
        }
    }
}
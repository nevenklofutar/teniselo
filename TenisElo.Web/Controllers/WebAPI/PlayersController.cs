using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TenisElo.Entities.Model;
using TenisElo.Service;

namespace TenisElo.Web.Controllers.WebAPI
{
    public class PlayersController : ApiController
    {

        private readonly IPlayerService _playerService;

        public PlayersController(IPlayerService playerService)
        {
            this._playerService = playerService;
        }


        // Get all players
        public IEnumerable<Player> GetAllPlayers()
        {
            return _playerService.GetAllPlayers();
        }

        // Get searched players
        public IEnumerable<Player> GetPlayerByName(string name)
        {
            return _playerService.FindPlayerByName(name);
        }

        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}
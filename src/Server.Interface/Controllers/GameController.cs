using Server.Interface.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Server.Interface.Controllers
{
    [Route("api/[controller]")]
    public class GameController
    {
        /**
        * POST api/game
        * 
        * Starts a new game
        */
        [HttpPost]
        public Game Post([FromBody]string value)
        {
            Array[] PlayerArray = new Array[12];
            Game newGame = new Game()
            {
                Id = Guid.NewGuid(), Active = false, TimeAndDate = DateTime.Now, Map = "default", Players = PlayerArray
            };
            Database.StartNewGame(newGame.Id, Convert.ToInt32(newGame.Active), newGame.TimeAndDate, newGame.Map);
            return newGame;
        }

        /**
        * GET api/game
        * 
        * Retrieves all games
        */
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "game1", "game2" };
        }

        /**
        * GET api/game/:id
        * 
        * Retrieves game by id
        */
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "game";
        }
    }
}

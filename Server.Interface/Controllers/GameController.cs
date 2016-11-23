using Server.Interface.Models;
using System;
using System.Web.Http;

namespace Server.Interface.Controllers
{
    [RoutePrefix("api/game")]
    public class GameController : ApiController
    {
        /**
        * POST api/game
        * 
        * Starts a new game
        */
        [HttpPost]
        [Authorize]
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
        * GET api/game/:id
        * 
        * Retrieves game by id
        */
        [Route("{id}")]
        [HttpGet]
        [AllowAnonymous]
        public string Get(int id)
        {
            return "game" + id;
        }
    }
}

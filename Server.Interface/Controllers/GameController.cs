using Server.Interface.Models;
using System;
using System.Web.Http;

namespace Server.Interface.Controllers
{
    [RoutePrefix("api/game")]
    public class GameController : ApiController
    {
        /**
        * GET api/game
        * 
        * Starts a new game
        */
        [HttpGet]
        [Authorize]
        public Game Get()
        {
            var newGame = new Game()
            {
                Id = Guid.NewGuid(), Active = false, TimeAndDate = DateTime.Now, Map = "default"
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

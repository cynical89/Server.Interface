using System.Web.Http;

namespace Server.Interface.Controllers
{
    [RoutePrefix("api/update")]
    public class UpdateController : ApiController
    {
        /**
        * GET api/update/:id
        * 
        * Retrieves update status by id
        */
        [Route("{id}")]
        [HttpGet]
        [AllowAnonymous]
        public string Get(int id)
        {
            if (id < 2)
            {
                return "Client needs to be updated";
            }
            else if (id > 2)
            {
                return "Client shows an incorrect version number";
            }

            return "Client is fully updated";
        }
    }
}

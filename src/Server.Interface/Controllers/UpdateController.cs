using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Server.Interface.Controllers
{
    [Route("api/[controller]")]
    public class UpdateController
    {
        /**
        * GET api/update/:id
        * 
        * Retrieves update status by id
        */
        [HttpGet("{id}")]
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

        [HttpGet]
        public string Get()
        {
            return "No Version supplied, Updating!";
        }
    }
}

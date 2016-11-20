using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Interface.Models
{
    public class Game
    {
        public Guid Id { get; set; }
        public bool Active { get; set; }
        public DateTime TimeAndDate { get; set; }
        public string Map { get; set; }
        public Array[] Players { get; set; }
    }
}

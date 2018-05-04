using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petproject.Models
{
    public class Card
    {
        public int Id { get; set; }
        public int AdrenalynId { get; set; }
        public bool isBis { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public Team Team { get; set; }
        public int TeamId { get; set; }
    }
}

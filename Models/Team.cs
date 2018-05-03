using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petproject.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Card> Cards { get; set; }
    }
}

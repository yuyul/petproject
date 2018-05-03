using Microsoft.EntityFrameworkCore;
using petproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petproject.Context
{
    public class CardsContext: DbContext
    {
        public CardsContext(DbContextOptions<CardsContext> options) : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Card> Cards { get; set; }
    }
}

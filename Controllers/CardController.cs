using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using petproject.Context;
using petproject.Models;

namespace petproject.Controllers
{
    [Produces("application/json")]
    [Route("api/Card/[action]")]
    public class CardController : Controller
    {
        private readonly CardsContext _context;

        public CardController(CardsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Card> Get()
        {
            var result = _context
                .Cards
                .Include(c => c.Team).ToList();

            return result;
        }

        [HttpGet("{id}")]
        public IEnumerable<Card> GetByTeam(int id)
        {
            var result = _context
                .Cards
                .Include(c => c.Team)
                .Where(c => c.TeamId == id)
                .ToList();
            return result;
        }
    }
}
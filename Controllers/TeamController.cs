using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using petproject.Context;
using petproject.Models;

namespace petproject.Controllers
{
    [Route("api/[controller]")]
    public class TeamController: Controller
    {
        private readonly CardsContext _context;

        public TeamController(CardsContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public IEnumerable<Team> Get(){
            return _context
                .Teams
                .ToList();
        }
    }

    
}
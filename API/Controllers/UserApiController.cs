using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserApiController : ControllerBase
    {
        private readonly DataContext _config;

        public UserApiController(DataContext config)
        {
            this._config = config;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetAll() {
            return await _config.AppUsers.ToListAsync() ;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetById(int id) {
            return await _config.AppUsers.FindAsync(id);
        }
    }
}
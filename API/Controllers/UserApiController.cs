using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult<IEnumerable<AppUser>> GetAll() {
            return _config.AppUsers.ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<AppUser> GetById(int id) {
            return _config.AppUsers.Find(id);
        }
    }
}
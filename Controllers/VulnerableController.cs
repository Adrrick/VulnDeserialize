using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VulnDeserialize.Models;

namespace VulnDeserialize.Controllers
{
    [Route("api/[controller]")]
    public class VulnerableController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] Info value)
        {
            if (value == null)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        [Route("hello")]
        public IActionResult GetHello()
        {
            return Ok("Hello");
        }

        [HttpGet]
        [Route("auth")]
        [Authorize]
        public IActionResult GetAuth()
        {
            return Ok("Authenticated");
        }
    }
}

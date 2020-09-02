using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KobeBryant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetOneRandomRecord()
        {
            return Ok("Hello World!");
        }

        [HttpGet]
        public IActionResult GetOneRecordById()
        {
            return Ok("Hello World!");
        }

        [HttpGet]
        public IActionResult GetAllRecords()
        {
            return Ok("Hello World!");
        }
    }
}
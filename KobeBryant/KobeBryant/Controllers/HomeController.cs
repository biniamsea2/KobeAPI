using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KobeBryant.Models.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KobeBryant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IKobe _context;
        private Random randomNum = new Random();

        public HomeController(IKobe kobe)
        {
            _context = kobe;
        }

        [HttpGet]
        public async Task <IActionResult> GetOneRandomRecord()
        {
            int id = randomNum.Next(1, 23);
            return Ok(await _context.GetSinlgeRandomRecord(id));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetOneRecordById(int id)
        {
            return Ok(await _context.GetSinlgeRecordById(id));
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllRecords()
        {
            return Ok(await _context.GetAllRecords());
        }
    }
}
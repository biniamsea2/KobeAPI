using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KobeBryant.Models.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KobeBryant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KobeController : ControllerBase
    {
        //DP:
        private readonly IKobe _context;
        private Random randomNum = new Random();

        public KobeController(IKobe kobe)
        {
            _context = kobe;
        }

        //get method that will get one random kobe record from our db and return it:
        [HttpGet]
        public async Task <IActionResult> GetOneRandomRecord()
        {
            //Next will get the next number after our random number. Ex: random = 7. random.next = 8:
            int id = randomNum.Next(1, 23);
            return Ok(await _context.GetSinlgeRandomRecord(id));
        }

        //will get a specific record from our database by using the ID given to us by the user:
        [HttpGet("{id}")]
        public async Task<ActionResult> GetOneRecordById(int id)
        {
            return Ok(await _context.GetSinlgeRecordById(id));
        }

        //all will return all the records from our database:
        [HttpGet("all")]
        public async Task<IActionResult> GetAllRecords()
        {
            return Ok(await _context.GetAllRecords());
        }
    }
}
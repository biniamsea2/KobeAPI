using KobeBryant.Data;
using KobeBryant.Models.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KobeBryant.Models.Service
{
    public class KobeManager : IKobe
    {
        //DP:
        private KobeBryantDbContext _context;
        public KobeManager(KobeBryantDbContext context)
        {
            _context = context;
        }

        //go to our records table in our database and get all the records and display them in a list:
        public async Task<List<Kobe>> GetAllRecords()
        {
            List<Kobe> kbRecords = await _context.Records.ToListAsync();
            return kbRecords;
        }

        //get a single record from our database, but use the id given to us. Which will be a random number
        //between 0 and our number of records(23):
        public async Task<Kobe> GetSinlgeRandomRecord(int id) => await _context.Records.FirstOrDefaultAsync(kb => kb.ID == id);

        //get a single record from our database based on the ID given to us by the user:
        public async Task<Kobe> GetSinlgeRecordById(int id) => await _context.Records.FirstOrDefaultAsync(kb => kb.ID == id);


    }
}

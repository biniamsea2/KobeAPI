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
        private KobeBryantDbContext _context;

        public KobeManager(KobeBryantDbContext context)
        {
            _context = context;
        }


        public async Task<List<Kobe>> GetAllRecords()
        {
            List<Kobe> kbRecords = await _context.Records.ToListAsync();
            return kbRecords;
        }


        public async Task<Kobe> GetSinlgeRandomRecord(int id) => await _context.Records.FirstOrDefaultAsync(kb => kb.ID == id);


        public async Task<Kobe> GetSinlgeRecordById(int id) => await _context.Records.FirstOrDefaultAsync(kb => kb.ID == id);


    }
}

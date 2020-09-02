using KobeBryant.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KobeBryant.Models.Service
{
    public class KobeManager : IKobe
    {
        public Task<List<Kobe>> GetAllRecords()
        {
            throw new NotImplementedException();
        }

        public Task<Kobe> GetSinlgeRandomRecord(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Kobe> GetSinlgeRecordById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

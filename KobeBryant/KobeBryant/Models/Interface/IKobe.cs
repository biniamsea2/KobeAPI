using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KobeBryant.Models.Interface
{
    interface IKobe
    {
        //will get a random record from the database, needs an id because we will use that to grab a random record
        Task<Kobe> GetSinlgeRandomRecord(int id);

        //will get a single record based on the ID given
        Task<Kobe> GetSinlgeRecordById(int id);

        //will get all the records from the database
        Task<List<Kobe>> GetAllRecords();
    }
}

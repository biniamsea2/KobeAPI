using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KobeBryant.Models
{
    public class Kobe
    {
        //properties created for each row in our "record" table
        public int ID { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public string Record { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Adress:BaseEntity
    {
        public Street Street { get; set; }
        public int HomeNumber { get; set; }
        public int FlatNumber { get; set; }
    }
}

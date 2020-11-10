using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class City:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Street> Streets { get; set; }
    }
}

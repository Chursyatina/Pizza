using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class OrderItem:BaseEntity
    {
        public Pizza Pizza { get; set; }
        public DoughType Dough { get; set; }
        public SizeType Size { get; set; }
        public double Price { get; set; }
    }
}

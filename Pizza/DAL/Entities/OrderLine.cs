using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class OrderLine:BaseEntity
    {
        public OrderItem Item { get; set; }
        public int ItemQuantity { get; set; }
        public double Price { get; set; }
    }
}

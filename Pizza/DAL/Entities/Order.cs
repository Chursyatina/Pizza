using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Order:BaseEntity
    {
        public DateTime DateOfCreation { get; set; }
        public double Price { get; set; }
        public Condition Condition { get; set; }
        public ICollection<OrderLine> Lines { get; set; }

        public Cooker Cooker { get; set; }
        public DeliveryMan DeliveryMan { get; set; }
        public Buyer Buyer { get; set; }
    }
}

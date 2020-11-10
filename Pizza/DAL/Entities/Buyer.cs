using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Buyer:User
    {
        public Adress Adress { get; set; }
        public ICollection<Order> HistoryOfOrders { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Pizza:OrderItem
    {
        public string Name { get; set; }
        public bool SelfMaded { get; set; }
        public bool Aviable { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}

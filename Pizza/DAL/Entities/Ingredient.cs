using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Ingredient:BaseEntity
    {
        public TypeOfIngredient SignatureIngredient { get; set; }
        public int QuantityOfIngredient { get; set; }
        public double Price { get; set; }
    }
}

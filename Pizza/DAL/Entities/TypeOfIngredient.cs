﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class TypeOfIngredient:BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}

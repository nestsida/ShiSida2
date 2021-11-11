using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShiSida_Engineering.Models
{
    public class Product
    {
        public Product() 
        { 
        }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model
{
    public class Property
    {
        public string DefaultImage { get; set; }
        public string Address { get; set; }
        public decimal Price { get; set; }
        public List<String> Images { get; set; }
    }
}

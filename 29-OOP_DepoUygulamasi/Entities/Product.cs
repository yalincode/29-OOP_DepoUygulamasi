using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_OOP_DepoUygulamasi.Entities
{
    //Common Intermedidate Language => CIL

    public class Product
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{ProductCode} - {ProductName}";
        }
    }
}

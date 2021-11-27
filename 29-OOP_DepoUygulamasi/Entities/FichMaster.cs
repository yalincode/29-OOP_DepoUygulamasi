using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_OOP_DepoUygulamasi.Entities
{
    public class FichMaster
    {
      
        public int Id { get; set; }
        public string FichNumber { get; set; }
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
        public int WarehouseIn { get; set; }
        public int WarehouseOut { get; set; }
        public DateTime Date { get; set; }

    }
}

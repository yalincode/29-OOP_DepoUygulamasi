using _29_OOP_DepoUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_OOP_DepoUygulamasi.FakeDb
{
    public class DepoDatabaseFakeDb
    {
        //Product tablosu için Id değerini burada tutuyorum.
        public static int ProductTabledId = 0;

        //Product tablosu
        public static List<Product> products = new List<Product>();


        public static int warehouseId = 0;
        public static List<Warehouse> warehouses = new List<Warehouse>();

        public static int fichMasterId = 0;
        public static int fichDetailId = 0;
        public static List<FichMaster> fichMasters = new List<FichMaster>();

        public static List<FichDetail> fichDetail = new List<FichDetail>();
        
    }
}

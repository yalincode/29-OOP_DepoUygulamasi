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
    }
}

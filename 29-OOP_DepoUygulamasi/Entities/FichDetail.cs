using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_OOP_DepoUygulamasi.Entities
{
    public class FichDetail
    {
        public int Id { get; set; }
        public int FichId { get; set; }//Bu detay hangi fişe ait
        public int ProductId { get; set; }
        public int Count { get; set; }
    }
}

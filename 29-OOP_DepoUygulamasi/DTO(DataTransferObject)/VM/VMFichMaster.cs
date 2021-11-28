using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_OOP_DepoUygulamasi.DTO_DataTransferObject_.VM
{
    public class VMFichMaster
    {
        //Auto Mapper=> Hızlı dönüşüm yapan kütüphanelerden birine örnek.
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
        public string FichNumber { get; set; }

        /// <summary>
        /// Giriş depo Id
        /// </summary>
        public int WarehouseInId { get; set; }
        public string WarehouseInName { get; set; }

        /// <summary>
        /// Çıkış depo Id
        /// </summary>
        public int WarehouseOutId { get; set; }
        public string WarehouseOutName { get; set; }
    }
}

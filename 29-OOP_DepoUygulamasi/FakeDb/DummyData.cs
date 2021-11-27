using _29_OOP_DepoUygulamasi.DAL;
using _29_OOP_DepoUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_OOP_DepoUygulamasi.FakeDb
{
    public static class DummyData
    {
        

        public static void Seed()
        {
            WarehouseRepository warehouseRepository = new WarehouseRepository();

            Warehouse warehouse1 = new Warehouse() { WarehouseName = "Kadıköy Depo", Description = "Kadıköy Depo" };
            Warehouse warehouse2 = new Warehouse() { WarehouseName = "Beşiktaş Depo", Description = "Beşiktaş Depo" };
            Warehouse warehouse3 = new Warehouse() { WarehouseName = "Esenler Depo", Description = "Esenler Depo" };
            Warehouse warehouse4 = new Warehouse() { WarehouseName = "Başakşehir Depo", Description = "Başakşehir Depo" };
            warehouseRepository.Add(warehouse1);
            warehouseRepository.Add(warehouse2);
            warehouseRepository.Add(warehouse3);
            warehouseRepository.Add(warehouse4);


            ProductRepository productRepository = new ProductRepository();

            Product product1 = new Product() { ProductCode = "P001", ProductName = "Çikolata", Description = "Gıda Ürünü", Price = 2.5m };
            Product product2 = new Product() { ProductCode = "P002", ProductName = "Bisküvi", Description = "Gıda Ürünü", Price = 3.5m };
            Product product3 = new Product() { ProductCode = "P003", ProductName = "Beyaz Peynir", Description = "Gıda Ürünü", Price = 40m };
            Product product4 = new Product() { ProductCode = "P004", ProductName = "Kaşar Peynir", Description = "Gıda Ürünü", Price = 55m };
            Product product5 = new Product() { ProductCode = "P005", ProductName = "Çamaşır Deterjanı", Description = "Temizlik Ürünü", Price = 85m };
            Product product6 = new Product() { ProductCode = "P006", ProductName = "Çöp Poşeti", Description = "Temizlik Ürünü", Price = 15.85m };
            productRepository.Add(product1);
            productRepository.Add(product2);
            productRepository.Add(product3);
            productRepository.Add(product4);
            productRepository.Add(product5);
            productRepository.Add(product6);
            
            
        }
    }
}

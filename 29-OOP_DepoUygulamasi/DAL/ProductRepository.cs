using _29_OOP_DepoUygulamasi.Entities;
using _29_OOP_DepoUygulamasi.FakeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_OOP_DepoUygulamasi.DAL
{
    //Ürünü ekleme çıkarma veya bulma(find) etmek databese ile çalışacak.
    public class ProductRepository
    {
        public void Add(Product item) //Yeni ürünü ekleme kısmı. ***
        {
            //Ürün ıd sini ver.
            item.Id = (++DepoDatabaseFakeDb.ProductTabledId);
            
            //Ürünü database e kaydet
            DepoDatabaseFakeDb.products.Add(item);
        }

        public Product FindById(int id)//ID den ürünü bulma kısmı. ***
        {
            Product product = DepoDatabaseFakeDb.products.FirstOrDefault(t0 => t0.Id == id);
            return product;
        }

        public List<Product> Get()//Bütün product listesini döner. ***
        {
            return DepoDatabaseFakeDb.products;
        }

        public void Update(Product item)//Update kısmı. ***
        {
            var dbItem = FindById(item.Id);//İlk bulduğunu verir.Kolleksiyonun her bir elemanına t0 verir.t0 öyleki eğer id si benim verdiğim id ye eşitse bu product ı bize verir.

            //foreach (var t0 in DepoDatabaseFakeDb.products) Üsttekinin açıklaması gibi.
            //{
            //    if (t0.Id==item.Id)
            //    {
            //        return item;
            //    }
            //    else
            //    {
            //        return null
            //    }
            //}

            if (dbItem!=null) // Database i update etmek için.
            {
                dbItem.ProductCode = item.ProductCode;
                dbItem.ProductName = item.ProductName;
                dbItem.Price = item.Price;
                dbItem.Description = item.Description;
            }
        }

        public void Delete(int id)
        {
            var dbItem = FindById(id);

            if (dbItem!=null)
            {
                DepoDatabaseFakeDb.products.Remove(dbItem);
            }
        }
        
    }
}

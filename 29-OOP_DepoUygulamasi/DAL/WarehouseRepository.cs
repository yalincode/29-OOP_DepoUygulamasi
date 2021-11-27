using _29_OOP_DepoUygulamasi.Entities;
using _29_OOP_DepoUygulamasi.FakeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_OOP_DepoUygulamasi.DAL
{
    public class WarehouseRepository
    {
        public void Add(Warehouse item)
        {
            item.id = (++DepoDatabaseFakeDb.warehouseId);
            DepoDatabaseFakeDb.warehouses.Add(item);
        }
        public Warehouse FindById(int id)
        {
            var result = DepoDatabaseFakeDb.warehouses.FirstOrDefault(t0 => t0.id == id);
            return result;
        }

        public void Update(Warehouse item)
        {
            var dbItem = FindById(item.id);
            if (dbItem!=null)
            {
                dbItem.WarehouseName = item.WarehouseName;
                dbItem.Description = item.Description;
            }
        }
        public List<Warehouse> Get()
        {
            return DepoDatabaseFakeDb.warehouses;
        }

        public void Delete(int id)
        {
            var dpItem = FindById(id);
            if (dpItem!=null)
            {
                DepoDatabaseFakeDb.warehouses.Remove(dpItem);
            }
        }
    }
}

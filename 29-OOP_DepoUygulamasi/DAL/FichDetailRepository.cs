using _29_OOP_DepoUygulamasi.FakeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_OOP_DepoUygulamasi.Entities
{
    public class FichDetailRepository
    {
        public void Add(FichDetail item)
        {
            item.Id = (++DepoDatabaseFakeDb.fichDetailId);
            DepoDatabaseFakeDb.fichDetail.Add(item);

        }

        public FichDetail FindById(int Id)
        {
            var dbItem = DepoDatabaseFakeDb.fichDetail.FirstOrDefault(t0 => t0.Id == Id);
            return dbItem;

        }

        public List<FichDetail> Get()
        {
            return DepoDatabaseFakeDb.fichDetail;
        }

        public void Update(FichDetail item)
        {
            var dbItem = FindById(item.Id);
            if (dbItem!=null)
            {
                dbItem.Count = item.Count;
                dbItem.ProductId = item.ProductId;
                dbItem.FichId = item.FichId;
            }
        }

        public void Delete(int id)
        {
            var dbItem = FindById(id);
            if (dbItem!=null)
            {
                DepoDatabaseFakeDb.fichDetail.Remove(dbItem);
            }
        }

    }
}


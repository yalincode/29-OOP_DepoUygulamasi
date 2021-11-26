using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _29_OOP_DepoUygulamasi.Entities;
using _29_OOP_DepoUygulamasi.FakeDb;

namespace _29_OOP_DepoUygulamasi.DAL
{
    public class FichMasterRepository
    {
        
        public void Add(FichMaster fichMaster)
        {
            fichMaster.Id = (++DepoDatabaseFakeDb.fichMasterId);
            DepoDatabaseFakeDb.fichMasters.Add(fichMaster);
        }

        public void  Update(FichMaster fichMaster)
        {
            var DbItem = FindById(fichMaster.Id);
            if (DbItem!=null)
            {
                DbItem.CompanyName = fichMaster.CompanyName;
                DbItem.FichNumber = fichMaster.FichNumber;
                DbItem.TaxNumber = fichMaster.TaxNumber;
                DbItem.WarehouseIn = fichMaster.WarehouseIn;
                DbItem.WarehouseOut = fichMaster.WarehouseOut;

                ////Ekrandan silinenlerş db den sil
                //foreach (var item in DbItem.FichDetails)
                //{
                //    var fichMasterItem = fichMaster.FichDetails.FirstOrDefault(t0 => t0.Id == item.Id);
                //    if (fichMasterItem==null)
                //    {
                //        DeleteFichDetail(DbItem, item);
                //    }
                //}

            }
        }
        //public void DeleteFichDetail(FichMaster fich, FichDetail item)
        //{

        //    if (fich!=null)
        //    {
        //        var fichDetail = fich.FichDetails.FirstOrDefault(t0 => t0.Id == item.Id);//Detayın ıd sini fich id ye eşitledik.
        //        if (fichDetail!=null)
        //        {
        //            fich.FichDetails.Remove(fichDetail);
        //        }
        //    }
        //}

        public FichMaster FindById(int Id)
        {
            var result=DepoDatabaseFakeDb.fichMasters.FirstOrDefault(t0 => t0.Id == Id);
            return result;
        }

        public void Delete(int id)
        {
            var dbItem = FindById(id);
            if (dbItem!=null)
            {
                DepoDatabaseFakeDb.fichMasters.Remove(dbItem);
            }
        }

        public List<FichMaster> Get()
        {
            return DepoDatabaseFakeDb.fichMasters;
        }

    }
}

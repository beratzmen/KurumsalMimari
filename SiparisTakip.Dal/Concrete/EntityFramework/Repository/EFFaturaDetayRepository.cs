using SiparisTakip.Dal.Abstract.FaturaDetayDal;
using SiparisTakip.Dal.Concrete.EntityFramework.Context;
using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Repository
{
  public  class EFFaturaDetayRepository:IFaturaDetayDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public FaturaDetay Getir(int id)
        {
            return SiparisTakipContext.FaturaDetay.AsNoTracking().Where(x => x.FaturaDetayID == id).SingleOrDefault();
        }

        public int Guncelle(FaturaDetay entity)
        {
            SiparisTakipContext.FaturaDetay.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public FaturaDetay Kaydet(FaturaDetay entity)
        {
            SiparisTakipContext.FaturaDetay.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<FaturaDetay> Listele()
        {
            return SiparisTakipContext.FaturaDetay.AsNoTracking().ToList();
        }

        public List<FaturaDetay> Listele(Expression<Func<FaturaDetay, bool>> predicate)
        {
            return SiparisTakipContext.FaturaDetay.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var faturadetay = Getir(id);
            return Sil(faturadetay);
        }

        public bool Sil(FaturaDetay entity)
        {
            SiparisTakipContext.FaturaDetay.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }

    }
}

using SiparisTakip.Dal.Abstract.CariHareketDal;
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
  public  class EFCariHareketRepository:ICariHareketDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public CariHareket Getir(int id)
        {
            return SiparisTakipContext.CariHareket.AsNoTracking().Where(x => x.CariHareketID == id).SingleOrDefault();
        }

        public int Guncelle(CariHareket entity)
        {
            SiparisTakipContext.CariHareket.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public CariHareket Kaydet(CariHareket entity)
        {
            SiparisTakipContext.CariHareket.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<CariHareket> Listele()
        {
            return SiparisTakipContext.CariHareket.AsNoTracking().ToList();
        }

        public List<CariHareket> Listele(Expression<Func<CariHareket, bool>> predicate)
        {
            return SiparisTakipContext.CariHareket.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var carihareket = Getir(id);
            return Sil(carihareket);
        }

        public bool Sil(CariHareket entity)
        {
            SiparisTakipContext.CariHareket.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }
    }
}

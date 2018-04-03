using SiparisTakip.Dal.Abstract.CariDal;
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
  public  class EFCariRepository:ICariDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public Cari Getir(int id)
        {
            return SiparisTakipContext.Cari.AsNoTracking().Where(x => x.CariID == id).SingleOrDefault();
        }

        public int Guncelle(Cari entity)
        {
            SiparisTakipContext.Cari.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public Cari Kaydet(Cari entity)
        {
            SiparisTakipContext.Cari.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<Cari> Listele()
        {
            return SiparisTakipContext.Cari.AsNoTracking().ToList();
        }

        public List<Cari> Listele(Expression<Func<Cari, bool>> predicate)
        {
            return SiparisTakipContext.Cari.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var cari = Getir(id);
            return Sil(cari);
        }

        public bool Sil(Cari entity)
        {
            SiparisTakipContext.Cari.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }
    }
}

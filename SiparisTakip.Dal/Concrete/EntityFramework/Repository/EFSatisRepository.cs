using SiparisTakip.Dal.Abstract.SatisDal;
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
  public  class EFSatisRepository:ISatisDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public Satis Getir(int id)
        {
            return SiparisTakipContext.Satis.AsNoTracking().Where(x => x.SatisID == id).SingleOrDefault();
        }

        public int Guncelle(Satis entity)
        {
            SiparisTakipContext.Satis.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public Satis Kaydet(Satis entity)
        {
            SiparisTakipContext.Satis.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<Satis> Listele()
        {
            return SiparisTakipContext.Satis.AsNoTracking().ToList();
        }

        public List<Satis> Listele(Expression<Func<Satis, bool>> predicate)
        {
            return SiparisTakipContext.Satis.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var sat= Getir(id);
            return Sil(sat);
        }

        public bool Sil(Satis entity)
        {
            SiparisTakipContext.Satis.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }
    }
}

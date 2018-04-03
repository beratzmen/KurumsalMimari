using SiparisTakip.Dal.Abstract.IlceDal;
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
  public  class EFIlceRepository:IIlceDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public Ilce Getir(int id)
        {
            return SiparisTakipContext.Ilce.AsNoTracking().Where(x => x.IlceID == id).SingleOrDefault();
        }

        public int Guncelle(Ilce entity)
        {
            SiparisTakipContext.Ilce.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public Ilce Kaydet(Ilce entity)
        {
            SiparisTakipContext.Ilce.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<Ilce> Listele()
        {
            return SiparisTakipContext.Ilce.AsNoTracking().ToList();
        }

        public List<Ilce> Listele(Expression<Func<Ilce, bool>> predicate)
        {
            return SiparisTakipContext.Ilce.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var ilce = Getir(id);
            return Sil(ilce);
        }

        public bool Sil(Ilce entity)
        {
            SiparisTakipContext.Ilce.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }
    }
}

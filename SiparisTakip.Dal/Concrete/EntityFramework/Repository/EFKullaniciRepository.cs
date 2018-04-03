using SiparisTakip.Dal.Abstract.KullaniciDal;
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
   public class EFKullaniciRepository:IKullaniciDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public Kullanici Getir(int id)
        {
            return SiparisTakipContext.Kullanici.AsNoTracking().Where(x => x.KullaniciID == id).SingleOrDefault();
        }

        public int Guncelle(Kullanici entity)
        {
            SiparisTakipContext.Kullanici.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public Kullanici Kaydet(Kullanici entity)
        {
            SiparisTakipContext.Kullanici.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<Kullanici> Listele()
        {
            return SiparisTakipContext.Kullanici.AsNoTracking().ToList();
        }

        public List<Kullanici> Listele(Expression<Func<Kullanici, bool>> predicate)
        {
            return SiparisTakipContext.Kullanici.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var kullanici = Getir(id);
            return Sil(kullanici);
        }

        public bool Sil(Kullanici entity)
        {
            SiparisTakipContext.Kullanici.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }
    }
}

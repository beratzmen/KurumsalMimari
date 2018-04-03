using SiparisTakip.Dal.Abstract.KullaniciYetkiDal;
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
   public class EFKullaniciYetkiRepository:IKullaniciYetkiDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public KullaniciYetki Getir(int id)
        {
            return SiparisTakipContext.KullaniciYetki.AsNoTracking().Where(x => x.KullaniciYetkiID == id).SingleOrDefault();
        }

        public int Guncelle(KullaniciYetki entity)
        {
            SiparisTakipContext.KullaniciYetki.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public KullaniciYetki Kaydet(KullaniciYetki entity)
        {
            SiparisTakipContext.KullaniciYetki.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<KullaniciYetki> Listele()
        {
            return SiparisTakipContext.KullaniciYetki.AsNoTracking().ToList();
        }

        public List<KullaniciYetki> Listele(Expression<Func<KullaniciYetki, bool>> predicate)
        {
            return SiparisTakipContext.KullaniciYetki.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var kyetki = Getir(id);
            return Sil(kyetki);
        }

        public bool Sil(KullaniciYetki entity)
        {
            SiparisTakipContext.KullaniciYetki.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }
    }
}

using SiparisTakip.Dal.Abstract.PersonelDal;
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
   public class EFPersonelRepository:IPersonelDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public Personel Getir(int id)
        {
            return SiparisTakipContext.Personel.AsNoTracking().Where(x => x.PersonelID == id).SingleOrDefault();
        }

        public int Guncelle(Personel entity)
        {
            SiparisTakipContext.Personel.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public Personel Kaydet(Personel entity)
        {
            SiparisTakipContext.Personel.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<Personel> Listele()
        {
            return SiparisTakipContext.Personel.AsNoTracking().ToList();
        }

        public List<Personel> Listele(Expression<Func<Personel, bool>> predicate)
        {
            return SiparisTakipContext.Personel.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var per = Getir(id);
            return Sil(per);
        }

        public bool Sil(Personel entity)
        {
            SiparisTakipContext.Personel.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }
    }
}

using SiparisTakip.Dal.Abstract.SektorDal;
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
   public class EFSektorRepository:ISektorDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public Sektor Getir(int id)
        {
            return SiparisTakipContext.Sektor.AsNoTracking().Where(x => x.SektorID == id).SingleOrDefault();
        }

        public int Guncelle(Sektor entity)
        {
            SiparisTakipContext.Sektor.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public Sektor Kaydet(Sektor entity)
        {
            SiparisTakipContext.Sektor.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<Sektor> Listele()
        {
            return SiparisTakipContext.Sektor.AsNoTracking().ToList();
        }

        public List<Sektor> Listele(Expression<Func<Sektor, bool>> predicate)
        {
            return SiparisTakipContext.Sektor.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var sek = Getir(id);
            return Sil(sek);
        }

        public bool Sil(Sektor entity)
        {
            SiparisTakipContext.Sektor.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }
    }
}

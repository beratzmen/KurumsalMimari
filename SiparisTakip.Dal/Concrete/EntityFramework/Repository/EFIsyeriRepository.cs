using SiparisTakip.Dal.Abstract.IsyeriDal;
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
    public class EFIsyeriRepository : IIsyeriDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public Isyeri Getir(int id)
        {
            return SiparisTakipContext.Isyeri.AsNoTracking().Where(x => x.IsyeriID == id).SingleOrDefault();
        }

        public int Guncelle(Isyeri entity)
        {
            SiparisTakipContext.Isyeri.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public Isyeri Kaydet(Isyeri entity)
        {
            SiparisTakipContext.Isyeri.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<Isyeri> Listele()
        {
            return SiparisTakipContext.Isyeri.AsNoTracking().ToList();
        }

        public List<Isyeri> Listele(Expression<Func<Isyeri, bool>> predicate)
        {
            return SiparisTakipContext.Isyeri.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var isy = Getir(id);
            return Sil(isy);
        }

        public bool Sil(Isyeri entity)
        {
            SiparisTakipContext.Isyeri.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }
    }
}

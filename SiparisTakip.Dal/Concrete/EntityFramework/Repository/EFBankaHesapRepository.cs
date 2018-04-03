using SiparisTakip.Dal.Abstract.BankaHesapDal;
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
  public  class EFBankaHesapRepository:IBankaHesapDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public BankaHesap Getir(int id)
        {
            return SiparisTakipContext.BankaHesap.AsNoTracking().Where(x => x.BankaHesapID == id).SingleOrDefault();
        }

        public int Guncelle(BankaHesap entity)
        {
            SiparisTakipContext.BankaHesap.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public BankaHesap Kaydet(BankaHesap entity)
        {
            SiparisTakipContext.BankaHesap.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<BankaHesap> Listele()
        {
            return SiparisTakipContext.BankaHesap.AsNoTracking().ToList();
        }

        public List<BankaHesap> Listele(Expression<Func<BankaHesap, bool>> predicate)
        {
            return SiparisTakipContext.BankaHesap.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var bankahesap = Getir(id);
            return Sil(bankahesap);
        }

        public bool Sil(BankaHesap entity)
        {
            SiparisTakipContext.BankaHesap.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }
    }
}

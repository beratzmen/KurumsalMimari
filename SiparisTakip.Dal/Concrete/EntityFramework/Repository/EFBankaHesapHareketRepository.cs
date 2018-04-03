using SiparisTakip.Dal.Abstract.BankaHesapHareketDal;
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
   public class EFBankaHesapHareketRepository:IBankaHesapHareketDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public BankaHesapHareket Getir(int id)
        {
            return SiparisTakipContext.BankaHesapHareket.AsNoTracking().Where(x => x.BankaHesapHareketID == id).SingleOrDefault();
        }

        public int Guncelle(BankaHesapHareket entity)
        {
            SiparisTakipContext.BankaHesapHareket.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public BankaHesapHareket Kaydet(BankaHesapHareket entity)
        {
            SiparisTakipContext.BankaHesapHareket.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<BankaHesapHareket> Listele()
        {
            return SiparisTakipContext.BankaHesapHareket.AsNoTracking().ToList();
        }
        public List<BankaHesapHareket> Listele(Expression<Func<BankaHesapHareket, bool>> predicate)
        {
            return SiparisTakipContext.BankaHesapHareket.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var bankahesaphareket = Getir(id);
            return Sil(bankahesaphareket);
        }

        public bool Sil(BankaHesapHareket entity)
        {
            SiparisTakipContext.BankaHesapHareket.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }
    }
}

using SiparisTakip.Dal.Abstract.MarkaDal;
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
   public class EFMarkaRepository:IMarkaDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public Marka Getir(int id)
        {
            return SiparisTakipContext.Marka.AsNoTracking().Where(x => x.MarkaID == id).SingleOrDefault();
        }

        public int Guncelle(Marka entity)
        {
            SiparisTakipContext.Marka.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public Marka Kaydet(Marka entity)
        {
            SiparisTakipContext.Marka.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<Marka> Listele()
        {
            return SiparisTakipContext.Marka.AsNoTracking().ToList();
        }

        public List<Marka> Listele(Expression<Func<Marka, bool>> predicate)
        {
            return SiparisTakipContext.Marka.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var mar = Getir(id);
            return Sil(mar);
        }

        public bool Sil(Marka entity)
        {
            SiparisTakipContext.Marka.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }
    }
}

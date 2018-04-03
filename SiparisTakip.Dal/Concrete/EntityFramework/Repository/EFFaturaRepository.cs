using SiparisTakip.Dal.Abstract.FaturaDal;
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
  public  class EFFaturaRepository:IFaturaDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public Fatura Getir(int id)
        {
            return SiparisTakipContext.Fatura.AsNoTracking().Where(x => x.FaturaID == id).SingleOrDefault();
        }

        public int Guncelle(Fatura entity)
        {
            SiparisTakipContext.Fatura.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public Fatura Kaydet(Fatura entity)
        {
            SiparisTakipContext.Fatura.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<Fatura> Listele()
        {
            return SiparisTakipContext.Fatura.AsNoTracking().ToList();
        }

        public List<Fatura> Listele(Expression<Func<Fatura, bool>> predicate)
        {
            return SiparisTakipContext.Fatura.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var fat = Getir(id);
            return Sil(fat);
        }

        public bool Sil(Fatura entity)
        {
            SiparisTakipContext.Fatura.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }
    }
}

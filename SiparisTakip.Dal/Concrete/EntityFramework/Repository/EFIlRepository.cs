using SiparisTakip.Dal.Abstract.ILDal;
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
  public  class EFIlRepository:IILDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public Il Getir(int id)
        {
            return SiparisTakipContext.Il.AsNoTracking().Where(x => x.IlID == id).SingleOrDefault();
        }

        public int Guncelle(Il entity)
        {
            SiparisTakipContext.Il.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public Il Kaydet(Il entity)
        {
            SiparisTakipContext.Il.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<Il> Listele()
        {
            return SiparisTakipContext.Il.AsNoTracking().ToList();
        }

        public List<Il> Listele(Expression<Func<Il, bool>> predicate)
        {
            return SiparisTakipContext.Il.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var il = Getir(id);
            return Sil(il);
        }

        public bool Sil(Il entity)
        {
            SiparisTakipContext.Il.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }
    }
}

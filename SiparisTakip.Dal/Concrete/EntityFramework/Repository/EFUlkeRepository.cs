using SiparisTakip.Dal.Abstract.UlkeDal;
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
  public  class EFUlkeRepository:IUlkeDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public Ulke Getir(int id)
        {
            return SiparisTakipContext.Ulke.AsNoTracking().Where(x => x.UlkeID == id).SingleOrDefault();
        }

        public int Guncelle(Ulke entity)
        {
            SiparisTakipContext.Ulke.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public Ulke Kaydet(Ulke entity)
        {
            SiparisTakipContext.Ulke.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<Ulke> Listele()
        {
            return SiparisTakipContext.Ulke.AsNoTracking().ToList();
        }

        public List<Ulke> Listele(Expression<Func<Ulke, bool>> predicate)
        {
            return SiparisTakipContext.Ulke.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var ul = Getir(id);
            return Sil(ul);
        }

        public bool Sil(Ulke entity)
        {
            SiparisTakipContext.Ulke.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }
    }
}

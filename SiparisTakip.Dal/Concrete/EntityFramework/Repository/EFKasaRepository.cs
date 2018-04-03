using SiparisTakip.Dal.Abstract.KasaDal;
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
  public  class EFKasaRepository:IKasaDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public Kasa Getir(int id)
        {
            return SiparisTakipContext.Kasa.AsNoTracking().Where(x => x.KasaID == id).SingleOrDefault();
        }

        public int Guncelle(Kasa entity)
        {
            SiparisTakipContext.Kasa.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public Kasa Kaydet(Kasa entity)
        {
            SiparisTakipContext.Kasa.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<Kasa> Listele()
        {
            return SiparisTakipContext.Kasa.AsNoTracking().ToList();
        }

        public List<Kasa> Listele(Expression<Func<Kasa, bool>> predicate)
        {
            return SiparisTakipContext.Kasa.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var kasa = Getir(id);
            return Sil(kasa);
        }

        public bool Sil(Kasa entity)
        {
            SiparisTakipContext.Kasa.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }
    }
}

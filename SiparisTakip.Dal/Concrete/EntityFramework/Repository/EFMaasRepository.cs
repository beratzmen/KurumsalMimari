using SiparisTakip.Dal.Abstract.MaasDal;
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
    public  class EFMaasRepository:IMaasDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public Maas Getir(int id)
        {
            return SiparisTakipContext.Maas.AsNoTracking().Where(x => x.MaasID == id).SingleOrDefault();
        }

        public int Guncelle(Maas entity)
        {
            SiparisTakipContext.Maas.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public Maas Kaydet(Maas entity)
        {
            SiparisTakipContext.Maas.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<Maas> Listele()
        {
            return SiparisTakipContext.Maas.AsNoTracking().ToList();
        }

        public List<Maas> Listele(Expression<Func<Maas, bool>> predicate)
        {
            return SiparisTakipContext.Maas.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var maas = Getir(id);
            return Sil(maas);
        }

        public bool Sil(Maas entity)
        {
            SiparisTakipContext.Maas.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }
    }
}

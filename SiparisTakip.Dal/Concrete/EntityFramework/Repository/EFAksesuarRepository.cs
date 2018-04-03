using SiparisTakip.Dal.Abstract.AksesuarDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisTakip.Entity.Models;
using SiparisTakip.Dal.Concrete.EntityFramework.Context;
using System.Data.Entity.Migrations;
using System.Linq.Expressions;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Repository
{
    public class EFAksesuarRepository : IAksesuarDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public Aksesuar Getir(int id)
        {
            return SiparisTakipContext.Aksesuar.AsNoTracking().Where(x => x.StokID == id).SingleOrDefault();
        }

        public int Guncelle(Aksesuar entity)
        {
            SiparisTakipContext.Aksesuar.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public Aksesuar Kaydet(Aksesuar entity)
        {
            SiparisTakipContext.Aksesuar.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<Aksesuar> Listele()
        {
            return SiparisTakipContext.Aksesuar.AsNoTracking().ToList();
        }
        public List<Aksesuar> Listele(Expression<Func<Aksesuar, bool>> predicate)
        {
            return SiparisTakipContext.Aksesuar.Where(predicate).ToList();
        }
        
        public bool Sil(int id)
        {
            var stok = Getir(id);
            return Sil(stok);
        }
        
        public bool Sil(Aksesuar entity)
        {
            SiparisTakipContext.Aksesuar.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }
    }
}

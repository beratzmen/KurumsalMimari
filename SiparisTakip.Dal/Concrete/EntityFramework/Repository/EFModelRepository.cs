using SiparisTakip.Dal.Abstract.ModelDal;
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
   public class EFModelRepository:IModelDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public Model Getir(int id)
        {
            return SiparisTakipContext.Model.AsNoTracking().Where(x => x.ModelID == id).SingleOrDefault();
        }

        public int Guncelle(Model entity)
        {
            SiparisTakipContext.Model.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public Model Kaydet(Model entity)
        {
            SiparisTakipContext.Model.Add(entity);
            SiparisTakipContext.SaveChanges();
            return entity;
        }

        public List<Model> Listele()
        {
            return SiparisTakipContext.Model.AsNoTracking().ToList();
        }

        public List<Model> Listele(Expression<Func<Model, bool>> predicate)
        {
            return SiparisTakipContext.Model.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var mod = Getir(id);
            return Sil(mod);
        }

        public bool Sil(Model entity)
        {
            SiparisTakipContext.Model.Remove(entity);
            return SiparisTakipContext.SaveChanges() > 0;
        }
    }
}

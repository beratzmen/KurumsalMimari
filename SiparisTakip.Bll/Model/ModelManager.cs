using SiparisTakip.Dal.Abstract.ModelDal;
using SiparisTakip.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.Model
{
   public class ModelManager:IModelService
    {
        IModelDal _modelDal;
        public ModelManager(IModelDal modelDal)
        {
            this._modelDal = modelDal;
        }
        public Entity.Models.Model Getir(int id)
        {
            return _modelDal.Getir(id);
        }

        public int Guncelle(Entity.Models.Model entity)
        {
            return _modelDal.Guncelle(entity);
        }

        public Entity.Models.Model Kaydet(Entity.Models.Model entity)
        {
            return _modelDal.Kaydet(entity);
        }

        public List<Entity.Models.Model> Listele()
        {
            return _modelDal.Listele();
        }

        public List<Entity.Models.Model> Listele(Expression<Func<Entity.Models.Model, bool>> predicate)
        {
            return _modelDal.Listele(predicate);
        }

        public bool Sil(Entity.Models.Model entity)
        {
            return _modelDal.Sil(entity);
        }

        public bool Sil(int id)
        {
            return _modelDal.Sil(id);
        }
    }
}

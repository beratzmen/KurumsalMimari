using SiparisTakip.Dal.Abstract.IsyeriDal;
using SiparisTakip.Interfaces.Isyeri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.Isyeri
{
    public  class IsyeriManager:IIsyeriService
    {
        IIsyeriDal _isyeriDal;
        public IsyeriManager(IIsyeriDal isyeriDal)
        {
            this._isyeriDal = isyeriDal;
        }
        public Entity.Models.Isyeri Getir(int id)
        {
            return _isyeriDal.Getir(id);
        }

        public int Guncelle(Entity.Models.Isyeri entity)
        {
            return _isyeriDal.Guncelle(entity);
        }

        public Entity.Models.Isyeri Kaydet(Entity.Models.Isyeri entity)
        {
            return _isyeriDal.Kaydet(entity);
        }

        public List<Entity.Models.Isyeri> Listele()
        {
            return _isyeriDal.Listele();
        }

        public List<Entity.Models.Isyeri> Listele(Expression<Func<Entity.Models.Isyeri, bool>> predicate)
        {
            return _isyeriDal.Listele(predicate);
        }

        public bool Sil(Entity.Models.Isyeri entity)
        {
            return _isyeriDal.Sil(entity);
        }

        public bool Sil(int id)
        {
            return _isyeriDal.Sil(id);
        }
    }
}

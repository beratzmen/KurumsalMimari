using SiparisTakip.Dal.Abstract.CariHareketDal;
using SiparisTakip.Interfaces.CariHareket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.CariHareket
{
   public class CariHareketManager:ICariHareketService
    {
        ICariHareketDal _carihareketDal;
        public CariHareketManager(ICariHareketDal carihareketDal)
        {
            this._carihareketDal = carihareketDal;
        }
        public Entity.Models.CariHareket Getir(int id)
        {
            return _carihareketDal.Getir(id);
        }

        public int Guncelle(Entity.Models.CariHareket entity)
        {
            return _carihareketDal.Guncelle(entity);
        }

        public Entity.Models.CariHareket Kaydet(Entity.Models.CariHareket entity)
        {
            return _carihareketDal.Kaydet(entity);
        }

        public List<Entity.Models.CariHareket> Listele()
        {
            return _carihareketDal.Listele();
        }

        public List<Entity.Models.CariHareket> Listele(Expression<Func<Entity.Models.CariHareket, bool>> predicate)
        {
            return _carihareketDal.Listele(predicate);
        }

        public bool Sil(Entity.Models.CariHareket entity)
        {
            return _carihareketDal.Sil(entity);
        }

        public bool Sil(int id)
        {
            return _carihareketDal.Sil(id);
        }
    }
}

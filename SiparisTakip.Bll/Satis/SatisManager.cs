using SiparisTakip.Dal.Abstract.SatisDal;
using SiparisTakip.Interfaces.Satis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.Satis
{
   public class SatisManager:ISatisService
    {
        ISatisDal _satisDal;
        public SatisManager(ISatisDal satisDal)
        {
            this._satisDal = satisDal;
        }


        public Entity.Models.Satis Getir(int id)
        {
            return _satisDal.Getir(id);
        }

        public int Guncelle(Entity.Models.Satis entity)
        {
            return _satisDal.Guncelle(entity);
        }

        public Entity.Models.Satis Kaydet(Entity.Models.Satis entity)
        {
            return _satisDal.Kaydet(entity);
        }

        public List<Entity.Models.Satis> Listele()
        {
            return _satisDal.Listele();
        }

        public List<Entity.Models.Satis> Listele(Expression<Func<Entity.Models.Satis, bool>> predicate)
        {
            return _satisDal.Listele(predicate);
        }

        public bool Sil(Entity.Models.Satis entity)
        {
            return _satisDal.Sil(entity);
        }

        public bool Sil(int id)
        {
            return _satisDal.Sil(id);
        }
    }
}

using SiparisTakip.Dal.Abstract.MaasDal;
using SiparisTakip.Interfaces.Maas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.Maas
{
  public  class MaasManager:IMaasService
    {
        IMaasDal _maasDal;
        public MaasManager(IMaasDal maasDal)
        {
            this._maasDal = maasDal;
        }
        public Entity.Models.Maas Getir(int id)
        {
            return _maasDal.Getir(id);
        }

        public int Guncelle(Entity.Models.Maas entity)
        {
            return _maasDal.Guncelle(entity);
        }

        public Entity.Models.Maas Kaydet(Entity.Models.Maas entity)
        {
            return _maasDal.Kaydet(entity);
        }

        public List<Entity.Models.Maas> Listele()
        {
            return _maasDal.Listele();
        }

        public List<Entity.Models.Maas> Listele(Expression<Func<Entity.Models.Maas, bool>> predicate)
        {
            return _maasDal.Listele(predicate);
        }

        public bool Sil(Entity.Models.Maas entity)
        {
            return _maasDal.Sil(entity);
        }

        public bool Sil(int id)
        {
            return _maasDal.Sil(id);
        }
    }
}

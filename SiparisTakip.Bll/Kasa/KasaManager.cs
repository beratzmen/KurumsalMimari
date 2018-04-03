using SiparisTakip.Dal.Abstract.KasaDal;
using SiparisTakip.Interfaces.Kasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.Kasa
{
    public  class KasaManager:IKasaService
    {
        IKasaDal _kasaDal;
        public KasaManager(IKasaDal kasaDal)
        {
            this._kasaDal = kasaDal;
        }
        public Entity.Models.Kasa Getir(int id)
        {
            return _kasaDal.Getir(id);
        }

        public int Guncelle(Entity.Models.Kasa entity)
        {
            return _kasaDal.Guncelle(entity);
        }

        public Entity.Models.Kasa Kaydet(Entity.Models.Kasa entity)
        {
            return _kasaDal.Kaydet(entity);
        }

        public List<Entity.Models.Kasa> Listele()
        {
            return _kasaDal.Listele();
        }

        public List<Entity.Models.Kasa> Listele(Expression<Func<Entity.Models.Kasa, bool>> predicate)
        {
            return _kasaDal.Listele(predicate);
        }

        public bool Sil(Entity.Models.Kasa entity)
        {
            return _kasaDal.Sil(entity);
        }

        public bool Sil(int id)
        {
            return _kasaDal.Sil(id);
        }
    }
}

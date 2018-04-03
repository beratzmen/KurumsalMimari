using SiparisTakip.Dal.Abstract.SektorDal;
using SiparisTakip.Interfaces.Sektor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.Sektor
{
    class SektorManager:ISektorService
    {
        ISektorDal _sektorDal;
        public SektorManager(ISektorDal sektorDal)
        {
            this._sektorDal = sektorDal;
        }


        public Entity.Models.Sektor Getir(int id)
        {
            return _sektorDal.Getir(id);
        }

        public int Guncelle(Entity.Models.Sektor entity)
        {
            return _sektorDal.Guncelle(entity);
        }

        public Entity.Models.Sektor Kaydet(Entity.Models.Sektor entity)
        {
            return _sektorDal.Kaydet(entity);
        }

        public List<Entity.Models.Sektor> Listele()
        {
            return _sektorDal.Listele();
        }

        public List<Entity.Models.Sektor> Listele(Expression<Func<Entity.Models.Sektor, bool>> predicate)
        {
            return _sektorDal.Listele(predicate);
        }

        public bool Sil(Entity.Models.Sektor entity)
        {
            return _sektorDal.Sil(entity);
        }

        public bool Sil(int id)
        {
            return _sektorDal.Sil(id);
        }
    }
}

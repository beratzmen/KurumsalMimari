using SiparisTakip.Dal.Abstract.CariDal;
using SiparisTakip.Interfaces.Cari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.Cari
{
   public class CariManager:ICariService
    {
        ICariDal _cariDal;
        public CariManager(ICariDal cariDal)
        {
            this._cariDal = cariDal;
        }
        public Entity.Models.Cari Getir(int id)
        {
            return _cariDal.Getir(id);
        }

        public int Guncelle(Entity.Models.Cari entity)
        {
            return _cariDal.Guncelle(entity);
        }

        public Entity.Models.Cari Kaydet(Entity.Models.Cari entity)
        {
            return _cariDal.Kaydet(entity);
        }

        public List<Entity.Models.Cari> Listele()
        {
            return _cariDal.Listele();
        }

        public List<Entity.Models.Cari> Listele(Expression<Func<Entity.Models.Cari, bool>> predicate)
        {
            return _cariDal.Listele(predicate);
        }

        public bool Sil(Entity.Models.Cari entity)
        {
            return _cariDal.Sil(entity);
        }

        public bool Sil(int id)
        {
            return _cariDal.Sil(id);
        }
    }
}

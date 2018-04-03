using SiparisTakip.Dal.Abstract.FaturaDetayDal;
using SiparisTakip.Interfaces.FaturaDetay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.FaturaDetay
{
    public class FaturaDetayManager:IFaturaDetayService
    {
        IFaturaDetayDal _faturdetayDal;
        public FaturaDetayManager(IFaturaDetayDal faturaDetayDal)
        {
            this._faturdetayDal = faturaDetayDal;
        }
        public Entity.Models.FaturaDetay Getir(int id)
        {
            return _faturdetayDal.Getir(id);
        }

        public int Guncelle(Entity.Models.FaturaDetay entity)
        {
            return _faturdetayDal.Guncelle(entity);
        }

        public Entity.Models.FaturaDetay Kaydet(Entity.Models.FaturaDetay entity)
        {
            return _faturdetayDal.Kaydet(entity);
        }

        public List<Entity.Models.FaturaDetay> Listele()
        {
            return _faturdetayDal.Listele();
        }

        public List<Entity.Models.FaturaDetay> Listele(Expression<Func<Entity.Models.FaturaDetay, bool>> predicate)
        {
            return _faturdetayDal.Listele(predicate);
        }

        public bool Sil(Entity.Models.FaturaDetay entity)
        {
            return _faturdetayDal.Sil(entity);
        }

        public bool Sil(int id)
        {
            return _faturdetayDal.Sil(id);
        }
    }
}

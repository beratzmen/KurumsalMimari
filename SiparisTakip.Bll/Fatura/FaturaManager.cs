using SiparisTakip.Dal.Abstract.FaturaDal;
using SiparisTakip.Interfaces.Fatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.Fatura
{
  public  class FaturaManager:IFaturaService
    {
        IFaturaDal _faturDal;
        public FaturaManager(IFaturaDal faturaDal)
        {
            this._faturDal = faturaDal;
        }
        public Entity.Models.Fatura Getir(int id)
        {
            return _faturDal.Getir(id);
        }

        public int Guncelle(Entity.Models.Fatura entity)
        {
            return _faturDal.Guncelle(entity);
        }

        public Entity.Models.Fatura Kaydet(Entity.Models.Fatura entity)
        {
            return _faturDal.Kaydet(entity);
        }

        public List<Entity.Models.Fatura> Listele()
        {
            return _faturDal.Listele();
        }

        public List<Entity.Models.Fatura> Listele(Expression<Func<Entity.Models.Fatura, bool>> predicate)
        {
            return _faturDal.Listele(predicate);
        }

        public bool Sil(Entity.Models.Fatura entity)
        {
            return _faturDal.Sil(entity);
        }

        public bool Sil(int id)
        {
            return _faturDal.Sil(id);
        }
    }
}

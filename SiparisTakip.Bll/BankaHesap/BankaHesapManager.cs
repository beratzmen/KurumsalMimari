using SiparisTakip.Dal.Abstract.BankaHesapDal;
using SiparisTakip.Interfaces.BankaHesap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.BankaHesap
{
  public  class BankaHesapManager:IBankaHesapService
    {
        IBankaHesapDal _bankahesapDal;
        public BankaHesapManager(IBankaHesapDal bankaDal)
        {
            this._bankahesapDal = bankaDal;
        }


        public Entity.Models.BankaHesap Getir(int id)
        {
            return _bankahesapDal.Getir(id);
        }

        public int Guncelle(Entity.Models.BankaHesap entity)
        {
            return _bankahesapDal.Guncelle(entity);
        }

        public Entity.Models.BankaHesap Kaydet(Entity.Models.BankaHesap entity)
        {
            return _bankahesapDal.Kaydet(entity);
        }

        public List<Entity.Models.BankaHesap> Listele()
        {
            return _bankahesapDal.Listele();
        }

        public List<Entity.Models.BankaHesap> Listele(Expression<Func<Entity.Models.BankaHesap, bool>> predicate)
        {
            return _bankahesapDal.Listele(predicate);
        }

        public bool Sil(Entity.Models.BankaHesap entity)
        {
            return _bankahesapDal.Sil(entity);
        }

        public bool Sil(int id)
        {
            return _bankahesapDal.Sil(id);
        }
    }
}

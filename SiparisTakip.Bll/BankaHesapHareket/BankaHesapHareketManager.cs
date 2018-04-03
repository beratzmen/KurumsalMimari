
using SiparisTakip.Dal.Abstract.BankaHesapHareketDal;
using SiparisTakip.Interfaces.BankaHesapHareket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.BankaHesapHareket
{
 public   class BankaHesapHareketManager:IBankaHesapHareketService
    {
        IBankaHesapHareketDal _bankahesaphareketDal;
        public BankaHesapHareketManager(IBankaHesapHareketDal bankahesaphareketDal)
        {
            this._bankahesaphareketDal = bankahesaphareketDal;
        }


        public Entity.Models.BankaHesapHareket Getir(int id)
        {
            return _bankahesaphareketDal.Getir(id);
        }

        public int Guncelle(Entity.Models.BankaHesapHareket entity)
        {
            return _bankahesaphareketDal.Guncelle(entity);
        }

        public Entity.Models.BankaHesapHareket Kaydet(Entity.Models.BankaHesapHareket entity)
        {
            return _bankahesaphareketDal.Kaydet(entity);
        }

        public List<Entity.Models.BankaHesapHareket> Listele()
        {
            return _bankahesaphareketDal.Listele();
        }

        public List<Entity.Models.BankaHesapHareket> Listele(Expression<Func<Entity.Models.BankaHesapHareket, bool>> predicate)
        {
            return _bankahesaphareketDal.Listele(predicate);
        }

        public bool Sil(Entity.Models.BankaHesapHareket entity)
        {
            return _bankahesaphareketDal.Sil(entity);
        }

        public bool Sil(int id)
        {
            return _bankahesaphareketDal.Sil(id);
        }
    }
}

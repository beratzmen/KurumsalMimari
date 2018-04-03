using SiparisTakip.Dal.Abstract.KullaniciDal;
using SiparisTakip.Interfaces.Kullanici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.Kullanici
{
 public   class KullaniciManager:IKullaniciService
    {
        IKullaniciDal _kullaniciDal;
        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            this._kullaniciDal = kullaniciDal;
        }
        public Entity.Models.Kullanici Getir(int id)
        {
            return _kullaniciDal.Getir(id);
        }

        public int Guncelle(Entity.Models.Kullanici entity)
        {
            return _kullaniciDal.Guncelle(entity);
        }

        public Entity.Models.Kullanici Kaydet(Entity.Models.Kullanici entity)
        {
            return _kullaniciDal.Kaydet(entity);
        }

        public List<Entity.Models.Kullanici> Listele()
        {
            return _kullaniciDal.Listele();
        }

        public List<Entity.Models.Kullanici> Listele(Expression<Func<Entity.Models.Kullanici, bool>> predicate)
        {
            return _kullaniciDal.Listele(predicate);
        }

        public bool Sil(Entity.Models.Kullanici entity)
        {
            return _kullaniciDal.Sil(entity);
        }

        public bool Sil(int id)
        {
            return _kullaniciDal.Sil(id);
        }
    }
}

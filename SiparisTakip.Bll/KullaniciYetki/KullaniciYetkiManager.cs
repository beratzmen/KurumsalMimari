using SiparisTakip.Dal.Abstract.KullaniciYetkiDal;
using SiparisTakip.Interfaces.KullaniciYetki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.KullaniciYetki
{
   public class KullaniciYetkiManager:IKullaniciYetkiService
    {

        IKullaniciYetkiDal _kullaniciyetkiDal;
        public KullaniciYetkiManager(IKullaniciYetkiDal kullaniciyetkiDal)
        {
            this._kullaniciyetkiDal = kullaniciyetkiDal;
        }
        public Entity.Models.KullaniciYetki Getir(int id)
        {
            return _kullaniciyetkiDal.Getir(id);
        }

        public int Guncelle(Entity.Models.KullaniciYetki entity)
        {
            return _kullaniciyetkiDal.Guncelle(entity);
        }

        public Entity.Models.KullaniciYetki Kaydet(Entity.Models.KullaniciYetki entity)
        {
            return _kullaniciyetkiDal.Kaydet(entity);
        }

        public List<Entity.Models.KullaniciYetki> Listele()
        {
            return _kullaniciyetkiDal.Listele();
        }

        public List<Entity.Models.KullaniciYetki> Listele(Expression<Func<Entity.Models.KullaniciYetki, bool>> predicate)
        {
            return _kullaniciyetkiDal.Listele(predicate);
        }

        public bool Sil(Entity.Models.KullaniciYetki entity)
        {
            return _kullaniciyetkiDal.Sil(entity);
        }

        public bool Sil(int id)
        {
            return _kullaniciyetkiDal.Sil(id);
        }
    }
}

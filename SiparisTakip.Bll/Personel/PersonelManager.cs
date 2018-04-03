using SiparisTakip.Dal.Abstract.PersonelDal;
using SiparisTakip.Interfaces.Personel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.Personel
{
   public class PersonelManager:IPersonelService
    {
        IPersonelDal _personelDal;
        public PersonelManager(IPersonelDal personelDal)
        {
            this._personelDal = personelDal;
        }
        public Entity.Models.Personel Getir(int id)
        {
            return _personelDal.Getir(id);
        }

        public int Guncelle(Entity.Models.Personel entity)
        {
            return _personelDal.Guncelle(entity);
        }

        public Entity.Models.Personel Kaydet(Entity.Models.Personel entity)
        {
            return _personelDal.Kaydet(entity);
        }

        public List<Entity.Models.Personel> Listele()
        {
            return _personelDal.Listele();
        }

        public List<Entity.Models.Personel> Listele(Expression<Func<Entity.Models.Personel, bool>> predicate)
        {
            return _personelDal.Listele(predicate);
        }

        public bool Sil(Entity.Models.Personel entity)
        {
            return _personelDal.Sil(entity);
        }

        public bool Sil(int id)
        {
            return _personelDal.Sil(id);
        }
    }
}

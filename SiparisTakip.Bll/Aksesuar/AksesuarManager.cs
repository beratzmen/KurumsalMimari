using SiparisTakip.Dal.Abstract.AksesuarDal;
using SiparisTakip.Interfaces.Aksesuar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SiparisTakip.Entity.Models;

namespace SiparisTakip.Bll.Aksesuar
{
    public class AksesuarManager : IAksesuarService
    {
        IAksesuarDal _aksesuarDal;
        public AksesuarManager(IAksesuarDal aksesuarDal)
        {
            this._aksesuarDal = aksesuarDal;
        }
        public Entity.Models.Aksesuar Getir(int id)
        {
            return _aksesuarDal.Getir(id);
        }

        public int Guncelle(Entity.Models.Aksesuar entity)
        {
            return _aksesuarDal.Guncelle(entity);
        }

        public Entity.Models.Aksesuar Kaydet(Entity.Models.Aksesuar entity)
        {
            return _aksesuarDal.Kaydet(entity);
        }

        public List<Entity.Models.Aksesuar> Listele()
        {
            return _aksesuarDal.Listele();
        }

        public List<Entity.Models.Aksesuar> Listele(Expression<Func<Entity.Models.Aksesuar, bool>> predicate)
        {
            return _aksesuarDal.Listele(predicate);
        }

        public bool Sil(Entity.Models.Aksesuar entity)
        {
            return _aksesuarDal.Sil(entity);
        }

        public bool Sil(int id)
        {
            return _aksesuarDal.Sil(id);
        }
    }
}

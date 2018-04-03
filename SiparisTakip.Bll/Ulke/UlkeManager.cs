using SiparisTakip.Dal.Abstract.UlkeDal;
using SiparisTakip.Interfaces.Ulke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.Ulke
{
   public class UlkeManager:IUlkeService
    {
        IUlkeDal _ulkeDal;
        public UlkeManager(IUlkeDal ulkeDal)
        {
            this._ulkeDal = ulkeDal;
        }


        public Entity.Models.Ulke Getir(int id)
        {
            return _ulkeDal.Getir(id);
        }

        public int Guncelle(Entity.Models.Ulke entity)
        {
            return _ulkeDal.Guncelle(entity);
        }

        public Entity.Models.Ulke Kaydet(Entity.Models.Ulke entity)
        {
            return _ulkeDal.Kaydet(entity);
        }

        public List<Entity.Models.Ulke> Listele()
        {
            return _ulkeDal.Listele();
        }

        public List<Entity.Models.Ulke> Listele(Expression<Func<Entity.Models.Ulke, bool>> predicate)
        {
            return _ulkeDal.Listele(predicate);
        }

        public bool Sil(Entity.Models.Ulke entity)
        {
            return _ulkeDal.Sil(entity);
        }

        public bool Sil(int id)
        {
            return _ulkeDal.Sil(id);
        }
    }
}

using SiparisTakip.Dal.Abstract.IlceDal;
using SiparisTakip.Interfaces.Ilce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.Ilce
{
    public class IlceManager : IIlceService
    {

        IIlceDal _ilceDal;
        public IlceManager(IIlceDal ilcedal)
        {
            this._ilceDal = ilcedal;
        }
        public Entity.Models.Ilce Getir(int id)
        {
            return _ilceDal.Getir(id);
        }

        public int Guncelle(Entity.Models.Ilce entity)
        {
            return _ilceDal.Guncelle(entity);
        }

        public Entity.Models.Ilce Kaydet(Entity.Models.Ilce entity)
        {
            return _ilceDal.Kaydet(entity);
        }

        public List<Entity.Models.Ilce> Listele()
        {
            return _ilceDal.Listele();
        }

        public List<Entity.Models.Ilce> Listele(Expression<Func<Entity.Models.Ilce, bool>> predicate)
        {
            return _ilceDal.Listele(predicate);
        }

        public bool Sil(Entity.Models.Ilce entity)
        {
            return _ilceDal.Sil(entity);
        }

        public bool Sil(int id)
        {
            return _ilceDal.Sil(id);
        }
    }
}

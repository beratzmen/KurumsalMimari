using SiparisTakip.Dal.Abstract.MarkaDal;
using SiparisTakip.Interfaces.Marka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.Marka
{
   public class MarkaManager:IMarkaService
    {
        IMarkaDal _markaDal;
        public MarkaManager(IMarkaDal markaDal)
        {
            this._markaDal = markaDal;
        }
        public Entity.Models.Marka Getir(int id)
        {
            return _markaDal.Getir(id);
        }

        public int Guncelle(Entity.Models.Marka entity)
        {
            return _markaDal.Guncelle(entity);
        }

        public Entity.Models.Marka Kaydet(Entity.Models.Marka entity)
        {
            return _markaDal.Kaydet(entity);
        }

        public List<Entity.Models.Marka> Listele()
        {
            return _markaDal.Listele();
        }

        public List<Entity.Models.Marka> Listele(Expression<Func<Entity.Models.Marka, bool>> predicate)
        {
            return _markaDal.Listele(predicate);
        }

        public bool Sil(Entity.Models.Marka entity)
        {
            return _markaDal.Sil(entity);
        }

        public bool Sil(int id)
        {
            return _markaDal.Sil(id);
        }
    }
}

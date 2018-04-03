using SiparisTakip.Dal.Abstract.ILDal;
using SiparisTakip.Interfaces.IL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.IL
{
    public  class ILManager:IILService
    { 
        IILDal _ilDal;
    public ILManager(IILDal ildal)
    {
        this._ilDal = ildal;
    }
    public Entity.Models.Il Getir(int id)
    {
        return _ilDal.Getir(id);
    }

    public int Guncelle(Entity.Models.Il entity)
    {
        return _ilDal.Guncelle(entity);
    }

    public Entity.Models.Il Kaydet(Entity.Models.Il entity)
    {
        return _ilDal.Kaydet(entity);
    }

    public List<Entity.Models.Il> Listele()
    {
        return _ilDal.Listele();
    }

    public List<Entity.Models.Il> Listele(Expression<Func<Entity.Models.Il, bool>> predicate)
    {
        return _ilDal.Listele(predicate);
    }

    public bool Sil(Entity.Models.Il entity)
    {
        return _ilDal.Sil(entity);
    }

    public bool Sil(int id)
    {
        return _ilDal.Sil(id);
    }
}
}

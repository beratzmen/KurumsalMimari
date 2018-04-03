using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.ModelDal
{
  public  interface IModelDal
    {
        Model Kaydet(Model entity);
        List<Model> Listele();
        List<Model> Listele(Expression<Func<Model, bool>> predicate);

        Model Getir(int id);
        int Guncelle(Model entity);

        bool Sil(int id);

        bool Sil(Model entity);
    }
}

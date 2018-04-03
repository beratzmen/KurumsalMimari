using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.ILDal
{
    public  interface IILDal
    {
        Il Kaydet(Il entity);
        List<Il> Listele();
        List<Il> Listele(Expression<Func<Il, bool>> predicate);

        Il Getir(int id);
        int Guncelle(Il entity);

        bool Sil(int id);

        bool Sil(Il entity);
    }
}

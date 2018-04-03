using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.FaturaDetayDal
{
    public  interface IFaturaDetayDal
    {
        FaturaDetay Kaydet(FaturaDetay entity);
        List<FaturaDetay> Listele();
        List<FaturaDetay> Listele(Expression<Func<FaturaDetay, bool>> predicate);
        FaturaDetay Getir(int id);
        int Guncelle(FaturaDetay entity);

        bool Sil(int id);

        bool Sil(FaturaDetay entity);
    }
}

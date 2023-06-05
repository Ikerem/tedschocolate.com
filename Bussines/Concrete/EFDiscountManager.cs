using Bussines.Abstract;
using Dataaccses.Abstract;
using Dataaccses.GenericRepostories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class EFDiscountManager :GenericRepostories<Discount>, IDiscountService
    {
        IDsicountDal _DsicountDal;

        public EFDiscountManager(IDsicountDal dsicountDal)
        {
            _DsicountDal = dsicountDal;
        }

        public void tDelete(Discount t)
        {
           _DsicountDal.Delete(t);
        }

        public Discount tGetByID(int id)
        {
           return _DsicountDal.GetByID(id);
        }

        public List<Discount> tGetList()
        {
            return _DsicountDal.GetList();  
        }

        public void tInsert(Discount t)
        {
            _DsicountDal.Insert(t);
        }

        public void tUpdate(Discount t)
        {
           _DsicountDal.Update(t);
        }
    }
}

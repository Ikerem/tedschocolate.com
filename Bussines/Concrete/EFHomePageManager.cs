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
    public class EFHomePageManager : GenericRepostories<Homepage>,  IHomePageService
    {
        IHomePageDal _HomePageDal;

        public EFHomePageManager(IHomePageDal homePageDal)
        {
            _HomePageDal = homePageDal;
        }

        public void tDelete(Homepage t)
        {
            _HomePageDal.Delete(t);
        }

        public Homepage tGetByID(int id)
        {
            return _HomePageDal.GetByID(id);
        }

        public List<Homepage> tGetList()
        {
            return _HomePageDal.GetList();
        }

        public void tInsert(Homepage t)
        {
           _HomePageDal.Insert(t);
        }

        public void tUpdate(Homepage t)
        {
            _HomePageDal.Update(t);
        }
    }
}

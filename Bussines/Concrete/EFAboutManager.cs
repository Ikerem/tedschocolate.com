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
    public class EFAboutManager : GenericRepostories<About>, IAboutService
    {
        IAboutDal _AboutDal;

        public EFAboutManager(IAboutDal aboutDal)
        {
            _AboutDal = aboutDal;
        }

        public void tDelete(About t)
        {
           _AboutDal.Delete(t);
        }

        public About tGetByID(int id)
        {
           return _AboutDal.GetByID(id);
        }

        public List<About> tGetList()
        {
           return _AboutDal.GetList();  
        }

        public void tInsert(About t)
        {
           _AboutDal.Insert(t);
        }

        public void tUpdate(About t)
        {
           _AboutDal.Update(t);
        }
    }
}

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
    public class EFOurChocolatesManager : GenericRepostories<OurChocolates>, IOurChocolatesService
    {
        IOurChocolatesDal _OurChocolatesDal;

        public EFOurChocolatesManager(IOurChocolatesDal ourChocolatesDal)
        {
            _OurChocolatesDal = ourChocolatesDal;
        }

        public void tDelete(OurChocolates t)
        {
           _OurChocolatesDal.Delete(t);
        }

        public OurChocolates tGetByID(int id)
        {
           return _OurChocolatesDal.GetByID(id);
        }

        public List<OurChocolates> tGetList()
        {
            return _OurChocolatesDal.GetList();
        }

        public void tInsert(OurChocolates t)
        {
            _OurChocolatesDal.Insert(t);
        }

        public void tUpdate(OurChocolates t)
        {
           _OurChocolatesDal.Update(t);
        }
    }
}

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
    public class EFColorCategoryManager : IColorCategoryService
    {
        IColorCategoryDal _ColorCategoryDal;

        public EFColorCategoryManager(IColorCategoryDal colorCategoryDal)
        {
            _ColorCategoryDal = colorCategoryDal;
        }

        public void tDelete(ColorCategory t)
        {
            throw new NotImplementedException();
        }

        public ColorCategory tGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ColorCategory> tGetList()
        {
            return _ColorCategoryDal.GetList();
        }

        public void tInsert(ColorCategory t)
        {
            throw new NotImplementedException();
        }

        public void tUpdate(ColorCategory t)
        {
            throw new NotImplementedException();
        }
    }
}

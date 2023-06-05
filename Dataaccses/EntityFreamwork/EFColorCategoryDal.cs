using Dataaccses.Abstract;
using Dataaccses.GenericRepostories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccses.EntityFreamwork
{
    public class EFColorCategoryDal:GenericRepostories<ColorCategory>, IColorCategoryDal
    {
    }
}

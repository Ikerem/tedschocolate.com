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
    public class EFChocolateoptionsListManager  : GenericRepostories<ChocolateoptionsList>, IChocolateoptionsListService
    {
        IChocolateoptionsListDal _ChocolateoptionsList;

        public EFChocolateoptionsListManager(IChocolateoptionsListDal chocolateoptionsList)
        {
            _ChocolateoptionsList = chocolateoptionsList;
        }

        public void tDelete(ChocolateoptionsList t)
        {
            _ChocolateoptionsList.Delete(t);
        }

        public ChocolateoptionsList tGetByID(int id)
        {
            return _ChocolateoptionsList.GetByID(id);
        }

        public List<ChocolateoptionsList> tGetList()
        {
           return _ChocolateoptionsList.GetList();
        }

        public void tInsert(ChocolateoptionsList t)
        {
           _ChocolateoptionsList.Insert(t);
        }

        public void tUpdate(ChocolateoptionsList t)
        {
           _ChocolateoptionsList.Update(t);
        }
    }
}

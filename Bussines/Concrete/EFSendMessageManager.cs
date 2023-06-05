using Bussines.Abstract;
using Dataaccses.Abstract;
using Dataaccses.GenericRepostories;
using EntityLayer.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class EFSendMessageManager : GenericRepostories<SendMessage>, ISendMessageService
    {
        ISendMessageDal _SendMessageDal;

        public EFSendMessageManager(ISendMessageDal sendMessageDal)
        {
            _SendMessageDal = sendMessageDal;
        }

        public void tDelete(SendMessage t)
        {
            _SendMessageDal.Delete(t);
        }

        public SendMessage tGetByID(int id)
        {
           return _SendMessageDal.GetByID(id);
        }

        public List<SendMessage> tGetList()
        {
         

            return _SendMessageDal.GetList();
        }

        public void tInsert(SendMessage t)
        {
            _SendMessageDal.Insert(t);
        }

        public void tUpdate(SendMessage t)
        {
           _SendMessageDal.Update(t);
        }
    }
}

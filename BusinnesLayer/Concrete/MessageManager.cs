﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinnesLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinnesLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TAdd(Message entity)
        {
            _messageDal.Insert(entity);
        }

        public void TDelete(Message entity)
        {
            _messageDal.Delete(entity);
        }

        public Message TGetByID(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message> TGetList()
        {
            return _messageDal.GetList();
        }

        public void TUpdate(Message entity)
        {
            _messageDal.Update(entity);
        }
    }
}

﻿using Blogy.BusinessLayer.Abstract;
using Blogy.DataAccessLayer.Abstract;
using Blogy.DataAccessLayer.EntityFramework;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void TDelete(int id)
        {
            if (id != 0)
            {
                _commentDal.Delete(id);
            }
            else
            {
                //hata mesajı
            }
        }

        public Comment TGetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> TGetCommentsByArticleId(int id)
        {
            return _commentDal.GetCommentsByArticleId(id);
        }

        public List<Comment> TGetListAll()
        {
            return _commentDal.GetListAll();
        }

        public void TInsert(Comment entity)
        {
            _commentDal.Insert(entity);
        }

        public void TUpdate(Comment entity)
        {
            _commentDal.Update(entity);
        }
    }
}

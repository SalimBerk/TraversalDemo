using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }



        public List<Comment> GetAll()
        {
            return _commentDal.getAll();
        }

        public List<Comment> GetListCommentWithDestination()
        {
            return _commentDal.GetListCommentWithDestination();
        }

        public List<Comment> GetListCommentWithDestinationAndUser(int id)
        {
            return _commentDal.GetListCommentWithDestinationAndUser(id);
        }

        public void TAdd(Comment entity)
        {
            _commentDal.add(entity);    
        }

        public Comment TGetById(int id)
        {
            return _commentDal.getById(id);
        }
        public List<Comment> TGetDesninationById(int id)
        {
            return _commentDal.GetListByFilter(x=>x.DesninationId==id);    
        }

        public void TRemove(Comment entity)
        {
            _commentDal.delete(entity);
        }

        public void TUpdate(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}

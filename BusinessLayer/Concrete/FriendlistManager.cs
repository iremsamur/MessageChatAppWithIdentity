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
    public class FriendlistManager : IFriendlistService
    {
        private readonly IFriendlistDal _friendlistDal;

        public FriendlistManager(IFriendlistDal friendlistDal)
        {
            _friendlistDal = friendlistDal;
        }

        public List<Friendlist> GetFriendlist(int loggedUserID)
        {
            return _friendlistDal.getFriendlist(loggedUserID);
        }

        public void TDelete(Friendlist t)
        {
            _friendlistDal.Delete(t);
        }

        public Friendlist TGetByID(int id)
        {
            return _friendlistDal.GetByID(id);
        }

        public List<Friendlist> TGetList()
        {
            return _friendlistDal.GetList();
        }

        public void TInsert(Friendlist t)
        {
            _friendlistDal.Insert(t);
        }

        public void TUpdate(Friendlist t)
        {
            _friendlistDal.Update(t);
        }
    }
}

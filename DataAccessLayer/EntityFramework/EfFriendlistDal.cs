using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{

    public class EfFriendlistDal : GenericRepository<Friendlist>, IFriendlistDal
    {
        public List<Friendlist> getFriendlist(int loggedUserID)
        {
            using (var context = new Context())
            {
                var values = context.Friendlists.Include(x => x.FriendPerson).Include(x => x.AccountOwnerPerson).Where(x=>x.AccountOwnerPersonID==loggedUserID).ToList();
                //assignee ve follower user bilgileriyle birlikte taskları getirir. Include ile tüm ilişkili olduğu tabloları veriyoruz
                return values;
            }
        }
    }
}

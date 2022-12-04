using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public AppUser getLoggedUserID(string username)
        {
            using (var context = new Context())
            {
                var userInformations = context.Users.Where(x => x.UserName == username).FirstOrDefault();
                return userInformations;
            }
        }
    }
}

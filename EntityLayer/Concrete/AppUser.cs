using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name
        {
            get; set;
        }
        public string Surname
        {
            get; set;
        }
        public string ImageUrl
        {
            get; set;
        }
        public string Gender
        {
            get; set;
        }
        public virtual ICollection<Message> UserSender { get; set; }
        public virtual ICollection<Message> UserReceiver { get; set; }

        public List<Friendlist> AccountOwner { get; set; }
        public List<Friendlist> Friend { get; set; }

    }
}

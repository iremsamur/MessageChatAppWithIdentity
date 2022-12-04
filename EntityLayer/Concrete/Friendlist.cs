using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Friendlist
    {
        [Key]
        public int ID { get; set; }
        //hesabın sahibi
        public int AccountOwnerPersonID { get; set; }
        public AppUser AccountOwnerPerson { get; set; }

        //ekli olan arkadaşı
        public int FriendPersonID { get; set; }
        public AppUser FriendPerson { get; set; }
    }
}

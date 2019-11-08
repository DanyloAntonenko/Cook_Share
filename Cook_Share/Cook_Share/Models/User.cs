using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cook_Share.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Photo { get; set; }

        public virtual IList<Subscribers> Subscribers { get; set; }

        public virtual IList<Subscriptions> Subscriptions { get; set; }

        public virtual IList<Comment> Comments { get; set; }

        public virtual IList<Favourites> Favourites{ get; set; }

        public virtual IList<Publication> Publications{ get; set; }


    }
}

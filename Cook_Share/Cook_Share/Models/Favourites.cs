using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cook_Share.Models
{
    public class Favourites
    {
        public int Id { get; set; }

        public int? PublicationId { get; set; }

        public int? UserId { get; set; }

        public User User { get; set; }

        public Publication Publication { get; set; }
    }
}

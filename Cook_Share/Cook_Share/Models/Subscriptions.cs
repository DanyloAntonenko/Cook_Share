using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cook_Share.Models
{
    public class Subscriptions
    {
        public int Id { get; set; }

        public int SubscriptionUserId { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }








    }
}

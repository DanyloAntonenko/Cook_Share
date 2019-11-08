using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cook_Share.Models
{
    public class Publication
    {
        [Key]
        public int Id { get; set; }

        public DateTime Time { get; set; }

        public int UserId { get; set; }

        public int Likes { get; set; }

        public IList<Comment> Comments { get; set; }

        public IList<Favourites> Favourites { get; set; }

        //!!!!!!!!!!!!!!!
        public virtual Dish Dish { get; set; }

        public virtual User User { get; set; }


        


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cook_Share.Models
{
    public class Publication
    {
        public int? Id { get; set; }

        public DateTime Time { get; set; }

        public int? UserId { get; set; }

        public int Likes { get; set; }

        public string DishName { get; set; }

        public string Discription { get; set; }
        
        public string Recipe { get; set; }

        public int? CalorificVal { get; set; }

        public string Cuisine { get; set; }

        public int? CategoryId { get; set; }

        public virtual IList<PublicationPhoto> Photos { get; set; }

        public virtual Category Category { get; set; }

        public IList<Comment> Comments { get; set; }

        public IList<Favourites> Favourites { get; set; }

        public virtual User User { get; set; }


        


    }
}

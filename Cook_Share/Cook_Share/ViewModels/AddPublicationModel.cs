using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cook_Share.ViewModels
{
    public class AddPublicationModel
    {
        
        public DateTime Time { get; set; }

        public int? UserId { get; set; }

        public int Likes { get; set; }

        public string DishName { get; set; }

        public string Discription { get; set; }

        public string Recipe { get; set; }

        public int? CalorificVal { get; set; }

        public string Cuisine { get; set; }

        public string Category { get; set; }

        public IEnumerable<string> Categories { get; set; }
    

        public virtual IFormFile Photos { get; set; }

    }
}

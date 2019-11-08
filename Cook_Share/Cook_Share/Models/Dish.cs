using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cook_Share.Models
{
    public class Dish
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public string Discription { get; set; }

        public int? CalorificVal { get; set; }

        public string Cuisine { get; set; }

        public int? CategoryId { get; set; }

        public int? PublicationId { get; set; }

        public string Photo { get; set; }
        
        //!!!!!!!!!!!!!!!
        public virtual Publication Publication { get; set; }
         
        public virtual Category Category { get; set; }


    }
}

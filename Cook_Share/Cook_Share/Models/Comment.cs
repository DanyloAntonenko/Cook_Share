using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cook_Share.Models
{
    public class Comment
    {
        public int? Id { get; set; }

        public string Discription { get; set; }
        [Required]
        [ForeignKey("User")]
        public int? UserId { get; set; }

        [Required]
        public int PublicationId { get; set; }

        [Required]
        public User User { get; set; }

       
        public Publication Publication { get; set; }




    }
}

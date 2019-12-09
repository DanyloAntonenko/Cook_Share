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
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        public string Discription { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }


        public int? PublicationId { get; set; }


        public User User { get; set; }

       
        public Publication Publication { get; set; }




    }
}

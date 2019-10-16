using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPP.ViewModels
{
    public class ChangeModel
    {
        [RegularExpression(@"^[A-Z]+[a-z]*$")]
        [StringLength(20, MinimumLength = 3)]
        [Required(ErrorMessage = "Не указан Name")]
        public string Name { get; set; }
        

        [RegularExpression(@"^[A-Z]+[a-z]*$")]
        [StringLength(40, MinimumLength = 3)]
        [Required(ErrorMessage = "Не указан Surname")]
        public string Surname { get; set; }

        [Range(1, 110, ErrorMessage = "Недопустимый возраст")]
        [Required(ErrorMessage = "Не указан Age")]
        public string Age { get; set; }

        [RegularExpression(@"^[A-Z]+[a-z]*$")]
        [Required(ErrorMessage = "Не указан Address")]
        public string Address { get; set; }

        [RegularExpression(@"^[A-Z]+[a-z]*$")]
        [Required(ErrorMessage = "Не указан About")]
        public string About { get; set; }
    }
}

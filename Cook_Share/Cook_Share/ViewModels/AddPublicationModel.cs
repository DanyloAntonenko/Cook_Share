﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cook_Share.ViewModels
{
    public class AddPublicationModel
    {
        
        public DateTime Time { get; set; }

        public int? UserId { get; set; }

        public int Likes { get; set; }

        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Размер имени от 2 до 20 символов")]
        public string DishName { get; set; }

        [Required(ErrorMessage = "Не указано описание")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Размер описания от 2 до 40 символов")]
        public string Discription { get; set; }

        public string Recipe { get; set; }
        
        
        [Range(10,1500, ErrorMessage = "Размер калорийности от 10 до 1500 символов")]
        public int? CalorificVal { get; set; }

        [StringLength(20, MinimumLength = 2, ErrorMessage = "Размер кухни от 2 до 20 символов")]
        public string Cuisine { get; set; }

        public string Category { get; set; }

        public IEnumerable<string> Categories { get; set; }
    

        public virtual IFormFile Photos { get; set; }

    }
}

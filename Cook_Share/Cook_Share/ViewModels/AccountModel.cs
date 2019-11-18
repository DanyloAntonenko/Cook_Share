using Cook_Share.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cook_Share.ViewModels
{
    public class AccountModel
    {
        //public string Email { get; set; }

        //[RegularExpression(@"^\s*[A-ZА-Я][a-zа-я]+('[a-zа-я]+|-[A-ZА-Я][a-zа-я]+)?\s*$", ErrorMessage = "Имя указано неверно")]
        //[StringLength(30, MinimumLength = 3)]
        //[Required(ErrorMessage = "Не указано имя")]
        //public string Name { get; set; }

        //[RegularExpression(@"^\s*[A-ZА-Я][a-zа-я]+('[a-zа-я]+|-[A-ZА-Я][a-zа-я]+)?\s*$", ErrorMessage = "Фамилия указана неверно")]
        //[StringLength(30, MinimumLength = 3)]
        //[Required(ErrorMessage = "Не указана фамилия")]
        //public string Surname { get; set; }
        public User User { get; set; }

        public IFormFile  Photo { get; set; }

        public IEnumerable<Publication> Publications { get; set; }

    }
}

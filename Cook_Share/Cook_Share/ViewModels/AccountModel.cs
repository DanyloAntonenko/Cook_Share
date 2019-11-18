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
        public User User { get; set; }

        public IFormFile  Photo { get; set; }

        public IEnumerable<Publication> Publications { get; set; }

        public IEnumerable<PublicationPhoto> Photos { get; set; }

        

    }
}

using Cook_Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cook_Share.ViewModels
{
    public class PublicationModel
    {
        public Publication Publication { get; set;}

        public User User { get; set; }

        public Category Category { get; set; }

        public IEnumerable<PublicationPhoto> Photos { get; set; }
    }
}

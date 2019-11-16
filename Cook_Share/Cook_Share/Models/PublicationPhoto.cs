using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cook_Share.Models
{
    public class PublicationPhoto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public  Publication Publication { get; set; }


    }
}

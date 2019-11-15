using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPP.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserInfo info { get; set; }

        public User() {
             info = new UserInfo();
         }
    }

    public class UserInfo
    {
        public int Id { get; set; }

       
        public string Email { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }
            public string About { get; set; }

    }
}

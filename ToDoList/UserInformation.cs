using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class UserInformation
    {
        public string User_name { get; set; }
        public string Email { get; set; }
        public int User_id { get; set; }


        public UserInformation() { }

        public UserInformation(string _name, string _email)
        {
            User_name = _name;
            Email = _email;
        }
    }
}

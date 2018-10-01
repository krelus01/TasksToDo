using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ToDoList
{
    [Table("TasksUsers")]
    public class User
    {
        public User()
        {
            User_tasks = new List<Task>();
        }


        [Key]
        public int User_id { get; set; }
        public string User_name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Task> User_tasks { get; set; }


        public User(string _name, string _email)
        {
            User_name = _name;
            Email = _email;
        }

    }
}

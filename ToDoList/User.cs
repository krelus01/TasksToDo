using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

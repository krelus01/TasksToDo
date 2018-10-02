using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ToDoList
{
    [Table("TasksToDo")]
    public class Task
    {
        [Key]
        public int Task_id { get; set; }
        public string Task_name { get; set; }
        public string Date_day { get; set; }
        public string Date_hour { get; set; }
        public string Additional_info { get; set; }

        public int User_id { get; set; }

        public Task() { }

        public Task(int user_id, string name, string day, string hour, string additional)
        {
            User_id = user_id;
            Task_name = name;
            Date_day = day;
            Date_hour = hour;
            Additional_info = additional;
        }
    }
}

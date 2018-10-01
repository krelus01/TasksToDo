using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class TaskInformation
    {
        public string Name { get; set; }
        public string Date_day { get; set; }
        public string Date_hour { get; set; }
        public int ID { get; set; }
        public string Additional_info { get; set; }

        public TaskInformation() { }

        public TaskInformation(string name, string day, string hour, int id, string additional)
        {
            Name = name;
            Date_day = day;
            Date_hour = hour;
            ID = ID;
            Additional_info = additional;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList
{
    class TaskDataService
    {
        TaskContext context;
        IEnumerable<TaskInformation> filteredByDate;

        public TaskDataService() { }

        /// <summary>
        /// Funkcja wyszukująca po dacie. Flagi: 0 - późniejsze niż data, 1 - wcześniejsze niż data, 2 - równe dacie
        /// </summary>
        /// <param name="date"></param>
        /// <param name="signFlag"></param>
        /// <returns></returns>
        public List<TaskInformation> GetByDate(string date, int user_id, int signFlag = 2)
        {
            List<TaskInformation> result = new List<TaskInformation>();
            List<TaskInformation> linqQuery;
            DateTime convertedDate = Convert.ToDateTime(date);

            using (context = new TaskContext())
            {
                linqQuery = (from t in context.Tasks
                             where t.User_id == user_id
                             select new TaskInformation
                             { Name = t.Task_name, Date_day = t.Date_day, Date_hour = t.Date_hour, ID = t.Task_id, Additional_info = t.Additional_info }).ToList<TaskInformation>();
                switch (signFlag)
                {
                    case 0:
                        filteredByDate = from f in linqQuery
                                         where Convert.ToDateTime(f.Date_day) >= convertedDate
                                         orderby Convert.ToDateTime(f.Date_day) ascending, Convert.ToDateTime(f.Date_hour) ascending
                                         select f;
                        break;
                    case 1:
                        filteredByDate = from f in linqQuery
                                         where Convert.ToDateTime(f.Date_day) <= convertedDate
                                         orderby Convert.ToDateTime(f.Date_day) ascending, Convert.ToDateTime(f.Date_hour) ascending
                                         select f;
                        break;
                    case 2:
                    default:
                        filteredByDate = from f in linqQuery
                                         where f.Date_day == date
                                         orderby Convert.ToDateTime(f.Date_day) ascending, Convert.ToDateTime(f.Date_hour) ascending
                                         select f;
                        break;
                }

                foreach (var _task in filteredByDate)
                {
                    result.Add(_task);
                }
            }
            return result;
        }

        //Wyszukiwanie po nazwie zadania
        public List<TaskInformation> GetByName(string name, int user_id)
        {
            List<TaskInformation> result = new List<TaskInformation>();
            using (context = new TaskContext())
            {
                var linqQuery = (from t in context.Tasks
                                 where t.User_id == user_id && t.Task_name.ToLower().Contains(name.ToLower())
                                 select new TaskInformation
                                 { Name = t.Task_name, Date_day = t.Date_day, Date_hour = t.Date_hour, ID = t.Task_id, Additional_info = t.Additional_info }).ToList<TaskInformation>();
                filteredByDate = from f in linqQuery
                                 orderby Convert.ToDateTime(f.Date_day) ascending, Convert.ToDateTime(f.Date_hour) ascending
                                 select f;

                foreach (var _task in filteredByDate)
                {
                    result.Add(_task);
                }
            }
            return result;
        }

        //Wyszukiwanie wszystkich zadań
        public List<TaskInformation> GetAll(int user_id)
        {
            List<TaskInformation> result = new List<TaskInformation>();
            using (context = new TaskContext())
            {
                var linqQuery = (from t in context.Tasks
                                 where t.User_id == user_id
                                 select new TaskInformation
                                 { Name = t.Task_name, Date_day = t.Date_day, Date_hour = t.Date_hour, ID = t.Task_id, Additional_info = t.Additional_info }).ToList<TaskInformation>();
                filteredByDate = from f in linqQuery
                                 orderby Convert.ToDateTime(f.Date_day) ascending, Convert.ToDateTime(f.Date_hour) ascending
                                 select f;
                foreach (var _task in filteredByDate)
                {
                    result.Add(_task);
                }
            }
            return result;
        }
    }
}

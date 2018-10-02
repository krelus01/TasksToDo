using System.Collections.Generic;
using System.Linq;

namespace ToDoList
{
    class UserDataService
    {
        TaskContext context;

        public UserDataService() { }

        public List<UserInformation> GetAll() //Funkcja zwraca wszystkich userów
        {
            List<UserInformation> result = new List<UserInformation>();
            using (context = new TaskContext())
            {
                var linqQuery = (from u in context.Users
                                 select new UserInformation
                                 { User_name = u.User_name, Email = u.Email, User_id = u.User_id }).ToList<UserInformation>();
                foreach (var _user in linqQuery)
                {
                    result.Add(_user);
                }
            }
            return result;
        }

        public User GetbyID(int id) //Funkcja zwraca obiekt user z bazy po ID
        {
            using (context = new TaskContext())
            {
                return context.Users.Single(a => a.User_id == id);
            }
        }
    }
}

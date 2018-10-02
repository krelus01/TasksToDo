using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class UserEdytujUsun : Form
    {
        User u;
        public User returnUser;

        public UserEdytujUsun(int userID)
        {
            InitializeComponent();
            using (var context = new TaskContext())
            {
                u = context.Users.Single
                    (a => a.User_id == userID);
            }
            UserNameTextbox.Text = u.User_name;
            EmailTextbox.Text = u.Email;
        }

        private void RemoveUserBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Jesteś pewny?", "Potwierdzenie", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                using (var context = new TaskContext())
                {
                    var user = context.Users.Single
                        (a => a.User_id == u.User_id);
                    var userTasks = from t in context.Tasks
                                    where t.User_id == u.User_id
                                    select t;
                    foreach (var task in userTasks)
                    {
                        context.Tasks.Remove(task);
                    }
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
                MessageBox.Show("Użytkownika usunięto.", "Informacja");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            if (UserNameTextbox.Text == "")
                MessageBox.Show("Pole nazwa użytkownika nie może być pusta", "Błąd!");
            else
            {
                using (var context = new TaskContext())
                {
                    returnUser = context.Users.Single(a => a.User_id == u.User_id);
                    returnUser.User_name = UserNameTextbox.Text;
                    returnUser.Email = EmailTextbox.Text;
                    context.SaveChanges();
                }
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }
    }
}

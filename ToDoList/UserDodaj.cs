using System;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class UserDodaj : Form
    {
        public User returnUser;

        public UserDodaj()
        {
            InitializeComponent();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            if (UserNameTextbox.Text == "")
                MessageBox.Show("Pole nazwa użytkownika nie może być puste.", "Błąd!");
            else
            {
                using (var context = new TaskContext())
                {
                    returnUser = new User(UserNameTextbox.Text, EmailTextbox.Text);
                    context.Users.Add(returnUser);
                    context.SaveChanges();
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void ClearTextBtn_Click(object sender, EventArgs e)
        {
            UserNameTextbox.Text = "";
            EmailTextbox.Text = "";
        }
    }
}

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class ZadaniaDodaj : Form
    {
        int _activeUser;
        public string returnDate;

        public ZadaniaDodaj(int user)
        {
            InitializeComponent();
            _activeUser = user;
            HourPicker.Text = "00:00";
        }

        private void ClearTextBtn_Click(object sender, EventArgs e) //Wyczyść
        {
            TaskNameTextbox.Text = "";
            AdditInfoRichtextbox.Text = "";
            HourPicker.Text = "00:00";
        }

        private void AddTaskBtn_Click(object sender, EventArgs e) //Dodaj
        {
            if (TaskNameTextbox.Text == "" || HourPicker.Text == "")
                MessageBox.Show("Nazwa i/lub godzina nie uzupełniona!", "Błąd!");
            else if (!Regex.IsMatch(HourPicker.Text, "[0-9][0-9]:[0-9][0-9]"))
                MessageBox.Show("Godzina zadania jest niepoprawna!", "Błąd!");
            else
            {
                using (var context = new TaskContext())
                {
                    Task t;
                    context.Users.Single
                        (a => a.User_id == _activeUser).User_tasks.Add
                        ((t = new Task(_activeUser, TaskNameTextbox.Text, dateTimePicker1.Value.ToShortDateString(), HourPicker.Text, AdditInfoRichtextbox.Text)));
                    context.SaveChanges();
                }
                this.returnDate = dateTimePicker1.Value.ToShortDateString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

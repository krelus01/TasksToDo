using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class ZadaniaEdytujUsun : Form
    {
        public string returnDate;
        Task t;

        public ZadaniaEdytujUsun(int taskID)
        {
            InitializeComponent();
            using (var context = new TaskContext())
            {
                t = context.Tasks.Single
                    (a => a.Task_id == taskID);
            }
            dateTimePicker1.Value = Convert.ToDateTime(t.Date_day);
            HourPicker.Text = t.Date_hour;
            TaskNameTextbox.Text = t.Task_name;
            AdditInfoRichtextbox.Text = t.Additional_info;
        }

        private void RemoveTaskBtn_Click(object sender, EventArgs e) //Usuń
        {
            DialogResult res = MessageBox.Show("Czy jesteś pewny?", "Potwierdzenie", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                using (var context = new TaskContext())
                {
                    var task = context.Tasks.Single
                        (a => a.Task_id == t.Task_id);
                    context.Tasks.Remove(task);
                    context.SaveChanges();
                }
                MessageBox.Show("Zadanie usunięto.", "Informacja");
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void EditTaskBtn_Click(object sender, EventArgs e) //Edytuj
        {
            if (TaskNameTextbox.Text == "" || HourPicker.Text == "")
                MessageBox.Show("Nazwa i/lub godzina nie uzupełniona!", "Błąd!");
            else if (!Regex.IsMatch(HourPicker.Text, "[0-9][0-9]:[0-9][0-9]"))
                MessageBox.Show("Godzina zadania jest niepoprawna!", "Błąd!");
            else
            {
                using (var context = new TaskContext())
                {
                var task = context.Tasks.Single(a => a.Task_id == t.Task_id);
                task.Date_day = dateTimePicker1.Value.ToShortDateString();
                task.Date_hour = HourPicker.Text;
                task.Task_name = TaskNameTextbox.Text;
                task.Additional_info = AdditInfoRichtextbox.Text;
                context.SaveChanges();
                }
                this.returnDate = dateTimePicker1.Value.ToShortDateString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

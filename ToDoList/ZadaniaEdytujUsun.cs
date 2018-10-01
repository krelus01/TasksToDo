using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            comboBox1.Text = t.Date_hour;
            textBox1.Text = t.Task_name;
            richTextBox1.Text = t.Additional_info;
        }

        private void button2_Click(object sender, EventArgs e) //Usuń
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

        private void button1_Click(object sender, EventArgs e) //Edytuj
        {
            if (textBox1.Text == "" || comboBox1.Text == "")
                MessageBox.Show("Nazwa i/lub godzina nie uzupełniona!", "Błąd!");
            else if (!Regex.IsMatch(comboBox1.Text, "[0-9][0-9]:[0-9][0-9]"))
                MessageBox.Show("Godzina zadania jest niepoprawna!", "Błąd!");
            else
            {
                using (var context = new TaskContext())
                {
                var task = context.Tasks.Single(a => a.Task_id == t.Task_id);
                task.Date_day = dateTimePicker1.Value.ToShortDateString();
                task.Date_hour = comboBox1.Text;
                task.Task_name = textBox1.Text;
                task.Additional_info = richTextBox1.Text;
                context.SaveChanges();
                }
                this.returnDate = dateTimePicker1.Value.ToShortDateString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

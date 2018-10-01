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
    public partial class ZadaniaDodaj : Form
    {
        int _activeUser;
        public string returnDate;

        public ZadaniaDodaj(int user)
        {
            InitializeComponent();
            _activeUser = user;
            comboBox1.Text = "00:00";
        }

        private void button2_Click(object sender, EventArgs e) //Wyczyść
        {
            textBox1.Text = "";
            richTextBox1.Text = "";
            comboBox1.Text = "00:00";
        }

        private void button1_Click(object sender, EventArgs e) //Dodaj
        {
            if (textBox1.Text == "" || comboBox1.Text == "")
                MessageBox.Show("Nazwa i/lub godzina nie uzupełniona!", "Błąd!");
            else if (!Regex.IsMatch(comboBox1.Text, "[0-9][0-9]:[0-9][0-9]"))
                MessageBox.Show("Godzina zadania jest niepoprawna!", "Błąd!");
            else
            {
                using (var context = new TaskContext())
                {
                    Task t;
                    context.Users.Single
                        (a => a.User_id == _activeUser).User_tasks.Add
                        ((t = new Task(_activeUser, textBox1.Text, dateTimePicker1.Value.ToShortDateString(), comboBox1.Text, richTextBox1.Text)));
                    context.SaveChanges();
                }
                this.returnDate = dateTimePicker1.Value.ToShortDateString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

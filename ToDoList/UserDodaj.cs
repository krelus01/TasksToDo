using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void button2_Click(object sender, EventArgs e) //Wyczyść
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e) //Dodaj
        {
            if (textBox1.Text == "")
                MessageBox.Show("Pole nazwa użytkownika nie może być puste.", "Błąd!");
            else
            {
            using (var context = new TaskContext())
            {
                returnUser = new User(textBox1.Text, textBox2.Text);
                context.Users.Add(returnUser);
                context.SaveChanges();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
            }
        }
    }
}

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
    public partial class UserPrzelaczUsera : Form
    {
        UserDataService UDS = new UserDataService();
        public User u = null;
        public bool closedWithoutUsers = true;

        public UserPrzelaczUsera()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData ()
        {
            dataGridView1.DataSource = UDS.GetAll();
            dataGridView1.Columns[0].HeaderText = "Nazwa";
            dataGridView1.Columns[1].HeaderText = "Email";
            dataGridView1.Columns[2].Visible = false;
            if (dataGridView1.Rows.Count == 0)
            {
                this.ControlBox = false;
                closedWithoutUsers = true;
                u = null;
            }
        }

        private void button1_Click(object sender, EventArgs e) //Wybierz
        {
            if (dataGridView1.Rows.Count != 0)
            {
                u = UDS.GetbyID((int)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value);
                closedWithoutUsers = false;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) //Usuń
        {
            if (dataGridView1.Rows.Count != 0)
            {
                DialogResult res = MessageBox.Show("Jesteś pewny?", "Potwierdzenie", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    using (var context = new TaskContext())
                    {
                        int user_id = (int)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value;
                        var user = context.Users.Single
                            (a => a.User_id == user_id);
                        var userTasks = from t in context.Tasks
                                        where t.User_id == u.User_id
                                        select t;
                        if (userTasks == null)
                        {
                            foreach (var task in userTasks)
                            {
                                context.Tasks.Remove(task);
                            }
                        }
                        context.Users.Remove(user);
                        context.SaveChanges();
                    }
                    dataGridView1.DataSource = UDS.GetAll();
                    if (dataGridView1.Rows.Count == 0)
                    {
                        this.ControlBox = false;
                        closedWithoutUsers = true;
                        u = null;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var dodaj = new UserDodaj())
            {
                var result = dodaj.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadData();
                }
                if (dataGridView1.Rows.Count != 0)
                    this.ControlBox = true;
            }
        }
    }
}

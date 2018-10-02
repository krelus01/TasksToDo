using System;
using System.Data;
using System.Linq;
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
            DGV_UserList.DataSource = UDS.GetAll();
            DGV_UserList.Columns[0].HeaderText = "Nazwa";
            DGV_UserList.Columns[1].HeaderText = "Email";
            DGV_UserList.Columns[2].Visible = false;
            if (DGV_UserList.Rows.Count == 0)
            {
                this.ControlBox = false;
                closedWithoutUsers = true;
                u = null;
            }
        }

        private void SelectUserBtn_Click(object sender, EventArgs e) //Wybierz
        {
            if (DGV_UserList.Rows.Count != 0)
            {
                u = UDS.GetbyID((int)DGV_UserList.Rows[DGV_UserList.CurrentCell.RowIndex].Cells[2].Value);
                closedWithoutUsers = false;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void RemoveUserBtn_Click(object sender, EventArgs e) //Usuń
        {
            if (DGV_UserList.Rows.Count != 0)
            {
                DialogResult res = MessageBox.Show("Jesteś pewny?", "Potwierdzenie", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    using (var context = new TaskContext())
                    {
                        int user_id = (int)DGV_UserList.Rows[DGV_UserList.CurrentCell.RowIndex].Cells[2].Value;
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
                    DGV_UserList.DataSource = UDS.GetAll();
                    if (DGV_UserList.Rows.Count == 0)
                    {
                        this.ControlBox = false;
                        closedWithoutUsers = true;
                        u = null;
                    }
                }
            }
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            using (var dodaj = new UserDodaj())
            {
                var result = dodaj.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadData();
                }
                if (DGV_UserList.Rows.Count != 0)
                    this.ControlBox = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace ToDoList
{
    public partial class Form1 : Form
    {
        TaskDataService _TaskDataService;
        TaskContext context;
        User activeUser;
        DialogResult switchUserResult;

        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(464, 300);
            _TaskDataService = new TaskDataService();

            using (context = new TaskContext())
            {
                var users = from u in context.Users
                            select u;
                if (users.Count() == 0)
                {
                    MessageBox.Show("Witaj w aplikacji TasksToDo!\nBaza " +
                        "uzytkowników jest pusta, utwórz nowego użytkownika.", "Witaj!");
                    AddUser();
                }
                else
                    SwitchUser();
            }
            if (switchUserResult == DialogResult.Cancel)
            {
                Load += (s, e) => Close();
                return;
            }
            else
            {
                LoadTasks(0);
                DGV_TasksList.Columns[0].HeaderText = "Nazwa";
                DGV_TasksList.Columns[1].HeaderText = "Data";
                DGV_TasksList.Columns[2].HeaderText = "Godzina";
                DGV_TasksList.Columns[3].Visible = false;
                DGV_TasksList.Columns[4].Visible = false;
            }

            System.Threading.Tasks.Task task = new System.Threading.Tasks.Task(new Action(AlarmFunction));
            task.Start();
        }

        void AddUser ()
        {
            using (var dodaj = new UserDodaj())
            {
                var result = dodaj.ShowDialog();
                if (result == DialogResult.OK)
                {
                    activeUser = dodaj.returnUser;
                    LoadTasks(0);
                    SetActiveName();
                }
            }
        }

        void SwitchUser () //Przełącza między użytkownikami
        {
            using (var przelacz = new UserPrzelaczUsera())
            {
                switchUserResult = przelacz.ShowDialog();
                if (switchUserResult == DialogResult.OK)
                {
                    activeUser = przelacz.u;
                    DGV_TasksList.DataSource = _TaskDataService.GetAll(activeUser.User_id);
                    SetActiveName();
                }
                if (przelacz.u == null && przelacz.closedWithoutUsers)
                {
                    SwitchUser();
                }
            }
        }

        void SetActiveName ()
        {
            label2.Location = new Point(351, 4);
            int labelLenght = activeUser.User_name.Count();
            label2.Text = activeUser.User_name.ToLower(); //Ustawia nazwę aktywnego użytkownika
            if (labelLenght > 12)
            {
                label2.Left -= (labelLenght*4);
            }
        }

        void SetUrgencyColors () //Ustawia kolorki
        {
            foreach (DataGridViewRow row in DGV_TasksList.Rows)
            {
                DateTime taskDate = Convert.ToDateTime(row.Cells[1].Value);
                if (taskDate <= DateTime.Today)
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                if (taskDate >= DateTime.Today.AddDays(1) && taskDate <= DateTime.Today.AddDays(3))
                    row.DefaultCellStyle.BackColor = Color.LightSalmon;
                if (taskDate >= DateTime.Today.AddDays(4))
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        void AlarmFunction () //Funkcja uruchamiana w tle, odpowiedzialna za wyświetlanie powiadomień o zbliżających się zadaniach
        {
            string oneHourFromNow;
            List<TaskInformation> tasksToCheck;
            while (true)
            {
                oneHourFromNow = DateTime.Now.AddHours(1).ToShortTimeString();
                tasksToCheck = _TaskDataService.GetByDate(DateTime.Today.ToShortDateString(), activeUser.User_id);
                if (tasksToCheck.Count() > 0)
                    foreach (var _task in tasksToCheck)
                    {
                        if (_task.Date_hour == oneHourFromNow)
                        {
                            System.Media.SystemSounds.Exclamation.Play();
                            MessageBox.Show("Zadanie " + _task.Name + " do wykonania za godzinę!", "Przypomnienie!");
                        }
                    }
                System.Threading.Thread.Sleep(60000);
            }
        }

        /// <summary>
        /// Ładuje dane na podstawie flagi: 0-wszystkie 1-filtr na nazwę, 2-filtr na datę
        /// </summary>
        /// <param name="flag"></param>
        void LoadTasks (int flag, string data = "")
        {
            switch (flag)
            {
                case 0:
                default:
                    DGV_TasksList.DataSource = _TaskDataService.GetAll(activeUser.User_id);
                    break;
                case 1:
                    DGV_TasksList.DataSource = _TaskDataService.GetByName(TextToSearch.Text, activeUser.User_id);
                    break;
                case 2:
                    DGV_TasksList.DataSource = _TaskDataService.GetByDate(data, activeUser.User_id);
                    break;
            }
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e) //Wybór daty po zamknięciu listy rozwijanej
        {
            DGV_TasksList.DataSource = _TaskDataService.GetByDate(dateTimePicker1.Value.ToShortDateString(), activeUser.User_id);
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e) //Wybór daty po odkliknięciu elementu
        {
            DGV_TasksList.DataSource = _TaskDataService.GetByDate(dateTimePicker1.Value.ToShortDateString(), activeUser.User_id);
        } 

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e) //Wybór daty po kliknięciu enter
        {
            if (e.KeyChar == (char)13)
                DGV_TasksList.DataSource = _TaskDataService.GetByDate(dateTimePicker1.Value.ToShortDateString(), activeUser.User_id);
        } 

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e) //Zadania->Dodaj
        {
            using (var dodaj = new ZadaniaDodaj(activeUser.User_id))
            {
                var result = dodaj.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string data = dodaj.returnDate;
                    LoadTasks(2, data);
                }
            }
        }

        private void edytujUsuńToolStripMenuItem_Click(object sender, EventArgs e) //Zadania->Edytuj/Usuń
        {
            using (var edytUsun = new ZadaniaEdytujUsun((int)DGV_TasksList.Rows[DGV_TasksList.CurrentCell.RowIndex].Cells[3].Value))
            {
                var result = edytUsun.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string data = edytUsun.returnDate;
                    LoadTasks(2, data);
                }
                if (result == DialogResult.Yes)
                    LoadTasks(0);
            }
        }

        private void dodajNowegoToolStripMenuItem_Click(object sender, EventArgs e) //Użytkownicy->Dodaj
        {
            AddUser();
        }

        private void edytujDaneToolStripMenuItem_Click(object sender, EventArgs e) //Użytkownicy->Edytuj/Usuń
        {
            using (var edytUsun = new UserEdytujUsun(activeUser.User_id))
            {
                var result = edytUsun.ShowDialog();
                if (result == DialogResult.OK)
                    SwitchUser();
                if (result == DialogResult.Yes)
                {
                    activeUser = edytUsun.returnUser;
                    SetActiveName();
                }
            }
        }

        private void zmieńUżytkownikaToolStripMenuItem_Click(object sender, EventArgs e) //Użytkownicy->Przełącz
        {
            SwitchUser();
        }

        private void DGV_TasksList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) //Nakłada kolorki po załadowaniu danych
        {
            SetUrgencyColors();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e) //Plik->Zakończ
        {
            Application.Exit();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e) //Plik->Autor
        {
            MessageBox.Show("Autor: Michał Krela\n" +
                "E-mail: michalkrela@gmail.com", "Autor");
        }

        private void GetClosestTasksBtn_Click(object sender, EventArgs e)
        {
            DGV_TasksList.DataSource = _TaskDataService.GetByDate(DateTime.Today.AddDays(3).ToShortDateString(), activeUser.User_id, 1);
        }

        private void GetAllTasksBtn_Click(object sender, EventArgs e)
        {
            LoadTasks(0);
        }

        private void SearchByTextBtn_Click(object sender, EventArgs e)
        {
            if (TextToSearch.Text.Count() < 3)
                MessageBox.Show("Fraza musi zawierać co najmniej 3 znaki!", "Błąd!");
            else
                LoadTasks(1, TextToSearch.Text);
        }

        private void TextToSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                if (TextToSearch.Text.Count() < 3)
                    MessageBox.Show("Wymagane co najmniej 3 znaki!", "Uwaga");
                else
                {
                    LoadTasks(1);
                    TextToSearch.Text = "";
                }
        }

        private void DGV_TasksList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (context = new TaskContext())
            {
                string addinfo;
                int index = (int)DGV_TasksList.Rows[DGV_TasksList.CurrentCell.RowIndex].Cells[3].Value;
                Task t = context.Tasks.Single(a => a.Task_id == index);
                if (t.Additional_info == "" || t.Additional_info == null)
                    addinfo = "Brak";
                else
                    addinfo = t.Additional_info;
                MessageBox.Show(addinfo, t.Task_name + " dodatkowe:");
            }
        }
    }
}

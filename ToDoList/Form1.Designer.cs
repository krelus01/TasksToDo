namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_TasksList = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zadaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujUsuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.użytkownicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNowegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujDaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńUżytkownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.GetClosestTasksBtn = new System.Windows.Forms.Button();
            this.GetAllTasksBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextToSearch = new System.Windows.Forms.TextBox();
            this.SearchByTextBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TasksList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_TasksList
            // 
            this.DGV_TasksList.AllowUserToAddRows = false;
            this.DGV_TasksList.AllowUserToDeleteRows = false;
            this.DGV_TasksList.AllowUserToResizeColumns = false;
            this.DGV_TasksList.AllowUserToResizeRows = false;
            this.DGV_TasksList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_TasksList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_TasksList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_TasksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TasksList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_TasksList.Location = new System.Drawing.Point(12, 94);
            this.DGV_TasksList.MultiSelect = false;
            this.DGV_TasksList.Name = "DGV_TasksList";
            this.DGV_TasksList.ReadOnly = true;
            this.DGV_TasksList.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DGV_TasksList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_TasksList.Size = new System.Drawing.Size(424, 352);
            this.DGV_TasksList.TabIndex = 5;
            this.DGV_TasksList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_TasksList_CellDoubleClick);
            this.DGV_TasksList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGV_TasksList_DataBindingComplete);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.CloseUp += new System.EventHandler(this.dateTimePicker1_CloseUp);
            this.dateTimePicker1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePicker1_KeyPress);
            this.dateTimePicker1.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.zadaniaToolStripMenuItem,
            this.użytkownicyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(448, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // zadaniaToolStripMenuItem
            // 
            this.zadaniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.edytujUsuńToolStripMenuItem});
            this.zadaniaToolStripMenuItem.Name = "zadaniaToolStripMenuItem";
            this.zadaniaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.zadaniaToolStripMenuItem.Text = "Zadania";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // edytujUsuńToolStripMenuItem
            // 
            this.edytujUsuńToolStripMenuItem.Name = "edytujUsuńToolStripMenuItem";
            this.edytujUsuńToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.edytujUsuńToolStripMenuItem.Text = "Edytuj / Usuń";
            this.edytujUsuńToolStripMenuItem.Click += new System.EventHandler(this.edytujUsuńToolStripMenuItem_Click);
            // 
            // użytkownicyToolStripMenuItem
            // 
            this.użytkownicyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNowegoToolStripMenuItem,
            this.edytujDaneToolStripMenuItem,
            this.zmieńUżytkownikaToolStripMenuItem});
            this.użytkownicyToolStripMenuItem.Name = "użytkownicyToolStripMenuItem";
            this.użytkownicyToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.użytkownicyToolStripMenuItem.Text = "Użytkownicy";
            // 
            // dodajNowegoToolStripMenuItem
            // 
            this.dodajNowegoToolStripMenuItem.Name = "dodajNowegoToolStripMenuItem";
            this.dodajNowegoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.dodajNowegoToolStripMenuItem.Text = "Dodaj";
            this.dodajNowegoToolStripMenuItem.Click += new System.EventHandler(this.dodajNowegoToolStripMenuItem_Click);
            // 
            // edytujDaneToolStripMenuItem
            // 
            this.edytujDaneToolStripMenuItem.Name = "edytujDaneToolStripMenuItem";
            this.edytujDaneToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.edytujDaneToolStripMenuItem.Text = "Edytuj dane / Usuń";
            this.edytujDaneToolStripMenuItem.Click += new System.EventHandler(this.edytujDaneToolStripMenuItem_Click);
            // 
            // zmieńUżytkownikaToolStripMenuItem
            // 
            this.zmieńUżytkownikaToolStripMenuItem.Name = "zmieńUżytkownikaToolStripMenuItem";
            this.zmieńUżytkownikaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.zmieńUżytkownikaToolStripMenuItem.Text = "Przełącz";
            this.zmieńUżytkownikaToolStripMenuItem.Click += new System.EventHandler(this.zmieńUżytkownikaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Termin:";
            // 
            // GetClosestTasksBtn
            // 
            this.GetClosestTasksBtn.Location = new System.Drawing.Point(296, 33);
            this.GetClosestTasksBtn.Name = "GetClosestTasksBtn";
            this.GetClosestTasksBtn.Size = new System.Drawing.Size(67, 29);
            this.GetClosestTasksBtn.TabIndex = 1;
            this.GetClosestTasksBtn.Text = "Najbliższe";
            this.GetClosestTasksBtn.UseVisualStyleBackColor = true;
            this.GetClosestTasksBtn.Click += new System.EventHandler(this.GetClosestTasksBtn_Click);
            // 
            // GetAllTasksBtn
            // 
            this.GetAllTasksBtn.Location = new System.Drawing.Point(369, 33);
            this.GetAllTasksBtn.Name = "GetAllTasksBtn";
            this.GetAllTasksBtn.Size = new System.Drawing.Size(67, 29);
            this.GetAllTasksBtn.TabIndex = 2;
            this.GetAllTasksBtn.Text = "Wszystkie";
            this.GetAllTasksBtn.UseVisualStyleBackColor = true;
            this.GetAllTasksBtn.Click += new System.EventHandler(this.GetAllTasksBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(351, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(8, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fraza:";
            // 
            // TextToSearch
            // 
            this.TextToSearch.Location = new System.Drawing.Point(93, 68);
            this.TextToSearch.MaxLength = 30;
            this.TextToSearch.Name = "TextToSearch";
            this.TextToSearch.Size = new System.Drawing.Size(197, 20);
            this.TextToSearch.TabIndex = 3;
            this.TextToSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextToSearch_KeyPress);
            // 
            // SearchByTextBtn
            // 
            this.SearchByTextBtn.Location = new System.Drawing.Point(296, 67);
            this.SearchByTextBtn.Name = "SearchByTextBtn";
            this.SearchByTextBtn.Size = new System.Drawing.Size(140, 22);
            this.SearchByTextBtn.TabIndex = 4;
            this.SearchByTextBtn.Text = "Szukaj";
            this.SearchByTextBtn.UseVisualStyleBackColor = true;
            this.SearchByTextBtn.Click += new System.EventHandler(this.SearchByTextBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 458);
            this.Controls.Add(this.SearchByTextBtn);
            this.Controls.Add(this.TextToSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GetAllTasksBtn);
            this.Controls.Add(this.GetClosestTasksBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DGV_TasksList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task to DO by M. Krela";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TasksList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_TasksList;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zadaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujUsuńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem użytkownicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNowegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujDaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńUżytkownikaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetClosestTasksBtn;
        private System.Windows.Forms.Button GetAllTasksBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextToSearch;
        private System.Windows.Forms.Button SearchByTextBtn;
    }
}


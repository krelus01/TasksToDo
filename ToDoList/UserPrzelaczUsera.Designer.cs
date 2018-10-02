namespace ToDoList
{
    partial class UserPrzelaczUsera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectUserBtn = new System.Windows.Forms.Button();
            this.DGV_UserList = new System.Windows.Forms.DataGridView();
            this.RemoveUserBtn = new System.Windows.Forms.Button();
            this.AddUserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz użytkownika:";
            // 
            // SelectUserBtn
            // 
            this.SelectUserBtn.Location = new System.Drawing.Point(159, 281);
            this.SelectUserBtn.Name = "SelectUserBtn";
            this.SelectUserBtn.Size = new System.Drawing.Size(70, 23);
            this.SelectUserBtn.TabIndex = 2;
            this.SelectUserBtn.Text = "Wybierz";
            this.SelectUserBtn.UseVisualStyleBackColor = true;
            this.SelectUserBtn.Click += new System.EventHandler(this.SelectUserBtn_Click);
            // 
            // DGV_UserList
            // 
            this.DGV_UserList.AllowUserToAddRows = false;
            this.DGV_UserList.AllowUserToDeleteRows = false;
            this.DGV_UserList.AllowUserToResizeColumns = false;
            this.DGV_UserList.AllowUserToResizeRows = false;
            this.DGV_UserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_UserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_UserList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_UserList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_UserList.Location = new System.Drawing.Point(12, 38);
            this.DGV_UserList.MultiSelect = false;
            this.DGV_UserList.Name = "DGV_UserList";
            this.DGV_UserList.ReadOnly = true;
            this.DGV_UserList.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DGV_UserList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_UserList.Size = new System.Drawing.Size(208, 237);
            this.DGV_UserList.TabIndex = 1;
            // 
            // RemoveUserBtn
            // 
            this.RemoveUserBtn.Location = new System.Drawing.Point(83, 281);
            this.RemoveUserBtn.Name = "RemoveUserBtn";
            this.RemoveUserBtn.Size = new System.Drawing.Size(70, 23);
            this.RemoveUserBtn.TabIndex = 3;
            this.RemoveUserBtn.Text = "Usuń";
            this.RemoveUserBtn.UseVisualStyleBackColor = true;
            this.RemoveUserBtn.Click += new System.EventHandler(this.RemoveUserBtn_Click);
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(7, 281);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(70, 23);
            this.AddUserBtn.TabIndex = 4;
            this.AddUserBtn.Text = "Dodaj";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // UserPrzelaczUsera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 312);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.RemoveUserBtn);
            this.Controls.Add(this.DGV_UserList);
            this.Controls.Add(this.SelectUserBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserPrzelaczUsera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wybór użytkownika";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_UserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectUserBtn;
        private System.Windows.Forms.DataGridView DGV_UserList;
        private System.Windows.Forms.Button RemoveUserBtn;
        private System.Windows.Forms.Button AddUserBtn;
    }
}
namespace ToDoList
{
    partial class ZadaniaDodaj
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.HourPicker = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TaskNameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AdditInfoRichtextbox = new System.Windows.Forms.RichTextBox();
            this.AddTaskBtn = new System.Windows.Forms.Button();
            this.ClearTextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz datę:";
            // 
            // HourPicker
            // 
            this.HourPicker.FormattingEnabled = true;
            this.HourPicker.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.HourPicker.Location = new System.Drawing.Point(218, 36);
            this.HourPicker.Name = "HourPicker";
            this.HourPicker.Size = new System.Drawing.Size(56, 21);
            this.HourPicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwa zadania:";
            // 
            // TaskNameTextbox
            // 
            this.TaskNameTextbox.Location = new System.Drawing.Point(12, 88);
            this.TaskNameTextbox.MaxLength = 30;
            this.TaskNameTextbox.Name = "TaskNameTextbox";
            this.TaskNameTextbox.Size = new System.Drawing.Size(262, 20);
            this.TaskNameTextbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dodatkowe informacje:";
            // 
            // AdditInfoRichtextbox
            // 
            this.AdditInfoRichtextbox.Location = new System.Drawing.Point(12, 139);
            this.AdditInfoRichtextbox.MaxLength = 800;
            this.AdditInfoRichtextbox.Name = "AdditInfoRichtextbox";
            this.AdditInfoRichtextbox.Size = new System.Drawing.Size(262, 92);
            this.AdditInfoRichtextbox.TabIndex = 3;
            this.AdditInfoRichtextbox.Text = "";
            // 
            // AddTaskBtn
            // 
            this.AddTaskBtn.Location = new System.Drawing.Point(199, 237);
            this.AddTaskBtn.Name = "AddTaskBtn";
            this.AddTaskBtn.Size = new System.Drawing.Size(75, 23);
            this.AddTaskBtn.TabIndex = 4;
            this.AddTaskBtn.Text = "Dodaj";
            this.AddTaskBtn.UseVisualStyleBackColor = true;
            this.AddTaskBtn.Click += new System.EventHandler(this.AddTaskBtn_Click);
            // 
            // ClearTextBtn
            // 
            this.ClearTextBtn.Location = new System.Drawing.Point(118, 237);
            this.ClearTextBtn.Name = "ClearTextBtn";
            this.ClearTextBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearTextBtn.TabIndex = 5;
            this.ClearTextBtn.Text = "Wyczyść";
            this.ClearTextBtn.UseVisualStyleBackColor = true;
            this.ClearTextBtn.Click += new System.EventHandler(this.ClearTextBtn_Click);
            // 
            // ZadaniaDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 267);
            this.Controls.Add(this.ClearTextBtn);
            this.Controls.Add(this.AddTaskBtn);
            this.Controls.Add(this.AdditInfoRichtextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TaskNameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HourPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ZadaniaDodaj";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj zadanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HourPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TaskNameTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox AdditInfoRichtextbox;
        private System.Windows.Forms.Button AddTaskBtn;
        private System.Windows.Forms.Button ClearTextBtn;
    }
}
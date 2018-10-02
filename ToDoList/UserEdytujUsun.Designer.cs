namespace ToDoList
{
    partial class UserEdytujUsun
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
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.RemoveUserBtn = new System.Windows.Forms.Button();
            this.EditUserBtn = new System.Windows.Forms.Button();
            this.UserNameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(12, 117);
            this.EmailTextbox.MaxLength = 40;
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(262, 20);
            this.EmailTextbox.TabIndex = 2;
            // 
            // RemoveUserBtn
            // 
            this.RemoveUserBtn.Location = new System.Drawing.Point(118, 237);
            this.RemoveUserBtn.Name = "RemoveUserBtn";
            this.RemoveUserBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveUserBtn.TabIndex = 4;
            this.RemoveUserBtn.Text = "Usuń";
            this.RemoveUserBtn.UseVisualStyleBackColor = true;
            this.RemoveUserBtn.Click += new System.EventHandler(this.RemoveUserBtn_Click);
            // 
            // EditUserBtn
            // 
            this.EditUserBtn.Location = new System.Drawing.Point(199, 237);
            this.EditUserBtn.Name = "EditUserBtn";
            this.EditUserBtn.Size = new System.Drawing.Size(75, 23);
            this.EditUserBtn.TabIndex = 3;
            this.EditUserBtn.Text = "Edytuj";
            this.EditUserBtn.UseVisualStyleBackColor = true;
            this.EditUserBtn.Click += new System.EventHandler(this.EditUserBtn_Click);
            // 
            // UserNameTextbox
            // 
            this.UserNameTextbox.Location = new System.Drawing.Point(12, 37);
            this.UserNameTextbox.MaxLength = 22;
            this.UserNameTextbox.Name = "UserNameTextbox";
            this.UserNameTextbox.Size = new System.Drawing.Size(262, 20);
            this.UserNameTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Adres e-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nazwa użytkownika:";
            // 
            // UserEdytujUsun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 267);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.RemoveUserBtn);
            this.Controls.Add(this.EditUserBtn);
            this.Controls.Add(this.UserNameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserEdytujUsun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserEdytujUsun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.Button RemoveUserBtn;
        private System.Windows.Forms.Button EditUserBtn;
        private System.Windows.Forms.TextBox UserNameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
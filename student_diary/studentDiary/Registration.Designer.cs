namespace studentDiary
{
    partial class RegistrationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationWindow));
            this.NameReg = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Patronymic = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.CheckPassword = new System.Windows.Forms.Label();
            this.RegistrationStart = new System.Windows.Forms.Button();
            this.NameText = new System.Windows.Forms.TextBox();
            this.SurnameText = new System.Windows.Forms.TextBox();
            this.PatronymicText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.CheckPasswordText = new System.Windows.Forms.TextBox();
            this.IStudentButton = new System.Windows.Forms.RadioButton();
            this.RBtnAdmin = new System.Windows.Forms.RadioButton();
            this.TelephoneText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameReg
            // 
            this.NameReg.AutoSize = true;
            this.NameReg.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameReg.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.NameReg.Location = new System.Drawing.Point(43, 32);
            this.NameReg.Name = "NameReg";
            this.NameReg.Size = new System.Drawing.Size(53, 25);
            this.NameReg.TabIndex = 0;
            this.NameReg.Text = "Имя";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Surname.Location = new System.Drawing.Point(259, 32);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(100, 25);
            this.Surname.TabIndex = 1;
            this.Surname.Text = "Фамилия";
            // 
            // Patronymic
            // 
            this.Patronymic.AutoSize = true;
            this.Patronymic.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Patronymic.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Patronymic.Location = new System.Drawing.Point(498, 32);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(236, 25);
            this.Patronymic.TabIndex = 2;
            this.Patronymic.Text = "Отчество(при наличии)";
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birthday.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Birthday.Location = new System.Drawing.Point(43, 138);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(94, 25);
            this.Birthday.TabIndex = 3;
            this.Birthday.Text = "Телефон";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Email.Location = new System.Drawing.Point(43, 234);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(195, 25);
            this.Email.TabIndex = 4;
            this.Email.Text = "Электронная почта";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Password.Location = new System.Drawing.Point(43, 330);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(84, 25);
            this.Password.TabIndex = 5;
            this.Password.Text = "Пароль";
            // 
            // CheckPassword
            // 
            this.CheckPassword.AutoSize = true;
            this.CheckPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckPassword.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.CheckPassword.Location = new System.Drawing.Point(434, 330);
            this.CheckPassword.Name = "CheckPassword";
            this.CheckPassword.Size = new System.Drawing.Size(188, 25);
            this.CheckPassword.TabIndex = 6;
            this.CheckPassword.Text = "Повторите пароль";
            // 
            // RegistrationStart
            // 
            this.RegistrationStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RegistrationStart.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RegistrationStart.Location = new System.Drawing.Point(264, 535);
            this.RegistrationStart.Name = "RegistrationStart";
            this.RegistrationStart.Size = new System.Drawing.Size(262, 68);
            this.RegistrationStart.TabIndex = 7;
            this.RegistrationStart.Text = "Зарегистрироваться";
            this.RegistrationStart.UseVisualStyleBackColor = false;
            this.RegistrationStart.Click += new System.EventHandler(this.RegistrationStart_Click_1);
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(48, 72);
            this.NameText.Multiline = true;
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(173, 31);
            this.NameText.TabIndex = 8;
            // 
            // SurnameText
            // 
            this.SurnameText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameText.Location = new System.Drawing.Point(264, 72);
            this.SurnameText.Multiline = true;
            this.SurnameText.Name = "SurnameText";
            this.SurnameText.Size = new System.Drawing.Size(206, 31);
            this.SurnameText.TabIndex = 9;
            // 
            // PatronymicText
            // 
            this.PatronymicText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicText.Location = new System.Drawing.Point(503, 72);
            this.PatronymicText.Multiline = true;
            this.PatronymicText.Name = "PatronymicText";
            this.PatronymicText.Size = new System.Drawing.Size(267, 31);
            this.PatronymicText.TabIndex = 10;
            // 
            // EmailText
            // 
            this.EmailText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailText.Location = new System.Drawing.Point(48, 271);
            this.EmailText.Multiline = true;
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(722, 31);
            this.EmailText.TabIndex = 11;
            // 
            // PasswordText
            // 
            this.PasswordText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.Location = new System.Drawing.Point(48, 372);
            this.PasswordText.Multiline = true;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(285, 31);
            this.PasswordText.TabIndex = 12;
            // 
            // CheckPasswordText
            // 
            this.CheckPasswordText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckPasswordText.Location = new System.Drawing.Point(439, 372);
            this.CheckPasswordText.Multiline = true;
            this.CheckPasswordText.Name = "CheckPasswordText";
            this.CheckPasswordText.PasswordChar = '*';
            this.CheckPasswordText.Size = new System.Drawing.Size(285, 31);
            this.CheckPasswordText.TabIndex = 13;
            // 
            // IStudentButton
            // 
            this.IStudentButton.AutoSize = true;
            this.IStudentButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IStudentButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.IStudentButton.Location = new System.Drawing.Point(48, 452);
            this.IStudentButton.Name = "IStudentButton";
            this.IStudentButton.Size = new System.Drawing.Size(132, 31);
            this.IStudentButton.TabIndex = 17;
            this.IStudentButton.TabStop = true;
            this.IStudentButton.Text = "Я студент";
            this.IStudentButton.UseVisualStyleBackColor = true;
            this.IStudentButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RBtnAdmin
            // 
            this.RBtnAdmin.AutoSize = true;
            this.RBtnAdmin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBtnAdmin.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.RBtnAdmin.Location = new System.Drawing.Point(247, 452);
            this.RBtnAdmin.Name = "RBtnAdmin";
            this.RBtnAdmin.Size = new System.Drawing.Size(215, 31);
            this.RBtnAdmin.TabIndex = 18;
            this.RBtnAdmin.TabStop = true;
            this.RBtnAdmin.Text = "Я администратор";
            this.RBtnAdmin.UseVisualStyleBackColor = true;
            // 
            // TelephoneText
            // 
            this.TelephoneText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TelephoneText.Location = new System.Drawing.Point(48, 184);
            this.TelephoneText.MaxLength = 11;
            this.TelephoneText.Multiline = true;
            this.TelephoneText.Name = "TelephoneText";
            this.TelephoneText.Size = new System.Drawing.Size(267, 31);
            this.TelephoneText.TabIndex = 19;
            // 
            // RegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.TelephoneText);
            this.Controls.Add(this.RBtnAdmin);
            this.Controls.Add(this.IStudentButton);
            this.Controls.Add(this.CheckPasswordText);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.PatronymicText);
            this.Controls.Add(this.SurnameText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.RegistrationStart);
            this.Controls.Add(this.CheckPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.NameReg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameReg;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Patronymic;
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label CheckPassword;
        private System.Windows.Forms.Button RegistrationStart;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox SurnameText;
        private System.Windows.Forms.TextBox PatronymicText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox CheckPasswordText;
        private System.Windows.Forms.RadioButton IStudentButton;
        private System.Windows.Forms.RadioButton RBtnAdmin;
        private System.Windows.Forms.TextBox TelephoneText;
    }
}
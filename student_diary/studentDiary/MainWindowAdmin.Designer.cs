namespace studentDiary
{
    partial class MainWindowAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowAdmin));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GroupList = new System.Windows.Forms.Button();
            this.ScheduleAdminProfile = new System.Windows.Forms.Button();
            this.AdminProfileButton = new System.Windows.Forms.Button();
            this.MainWindowButton = new System.Windows.Forms.Button();
            this.StudentProfileImage = new System.Windows.Forms.PictureBox();
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Today = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.splitContainer1.Panel1.Controls.Add(this.GroupList);
            this.splitContainer1.Panel1.Controls.Add(this.ScheduleAdminProfile);
            this.splitContainer1.Panel1.Controls.Add(this.AdminProfileButton);
            this.splitContainer1.Panel1.Controls.Add(this.MainWindowButton);
            this.splitContainer1.Panel1.Controls.Add(this.StudentProfileImage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel2.Controls.Add(this.Time);
            this.splitContainer1.Panel2.Controls.Add(this.Date);
            this.splitContainer1.Panel2.Controls.Add(this.Today);
            this.splitContainer1.Panel2.Controls.Add(this.monthCalendar);
            this.splitContainer1.Size = new System.Drawing.Size(800, 654);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // GroupList
            // 
            this.GroupList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GroupList.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupList.Location = new System.Drawing.Point(3, 319);
            this.GroupList.Name = "GroupList";
            this.GroupList.Size = new System.Drawing.Size(263, 56);
            this.GroupList.TabIndex = 13;
            this.GroupList.Text = "Список групп";
            this.GroupList.UseVisualStyleBackColor = false;
            this.GroupList.Click += new System.EventHandler(this.GroupList_Click);
            // 
            // ScheduleAdminProfile
            // 
            this.ScheduleAdminProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ScheduleAdminProfile.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScheduleAdminProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScheduleAdminProfile.Location = new System.Drawing.Point(0, 260);
            this.ScheduleAdminProfile.Name = "ScheduleAdminProfile";
            this.ScheduleAdminProfile.Size = new System.Drawing.Size(266, 63);
            this.ScheduleAdminProfile.TabIndex = 10;
            this.ScheduleAdminProfile.Text = "Расписание занятий";
            this.ScheduleAdminProfile.UseVisualStyleBackColor = false;
            this.ScheduleAdminProfile.Click += new System.EventHandler(this.ScheduleAdminProfile_Click);
            // 
            // AdminProfileButton
            // 
            this.AdminProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AdminProfileButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminProfileButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AdminProfileButton.Location = new System.Drawing.Point(0, 210);
            this.AdminProfileButton.Name = "AdminProfileButton";
            this.AdminProfileButton.Size = new System.Drawing.Size(266, 55);
            this.AdminProfileButton.TabIndex = 9;
            this.AdminProfileButton.Text = "Личный кабинет";
            this.AdminProfileButton.UseVisualStyleBackColor = false;
            this.AdminProfileButton.Click += new System.EventHandler(this.AdminProfileButton_Click);
            // 
            // MainWindowButton
            // 
            this.MainWindowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MainWindowButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainWindowButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainWindowButton.Location = new System.Drawing.Point(0, 157);
            this.MainWindowButton.Name = "MainWindowButton";
            this.MainWindowButton.Size = new System.Drawing.Size(266, 57);
            this.MainWindowButton.TabIndex = 8;
            this.MainWindowButton.Text = "Главная";
            this.MainWindowButton.UseVisualStyleBackColor = false;
            // 
            // StudentProfileImage
            // 
            this.StudentProfileImage.Location = new System.Drawing.Point(0, 0);
            this.StudentProfileImage.Name = "StudentProfileImage";
            this.StudentProfileImage.Size = new System.Drawing.Size(263, 160);
            this.StudentProfileImage.TabIndex = 3;
            this.StudentProfileImage.TabStop = false;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Time.Location = new System.Drawing.Point(22, 110);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(144, 52);
            this.Time.TabIndex = 3;
            this.Time.Text = "label1";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Date.Location = new System.Drawing.Point(23, 110);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(0, 36);
            this.Date.TabIndex = 2;
            // 
            // Today
            // 
            this.Today.AutoSize = true;
            this.Today.Font = new System.Drawing.Font("Microsoft JhengHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Today.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Today.Location = new System.Drawing.Point(13, 18);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(286, 60);
            this.Today.TabIndex = 1;
            this.Today.Text = "СЕГОДНЯ";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthCalendar.Location = new System.Drawing.Point(320, 18);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // MainWindowAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 654);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindowAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentProfileImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button ScheduleAdminProfile;
        private System.Windows.Forms.Button AdminProfileButton;
        private System.Windows.Forms.Button MainWindowButton;
        private System.Windows.Forms.PictureBox StudentProfileImage;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Today;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button GroupList;
    }
}
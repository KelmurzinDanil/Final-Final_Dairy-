namespace studentDiary
{
    partial class MainWindowStudent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowStudent));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ScheduleStudentProfile = new System.Windows.Forms.Button();
            this.StudentProfileButton = new System.Windows.Forms.Button();
            this.MainWindowButton = new System.Windows.Forms.Button();
            this.StudentProfileImage = new System.Windows.Forms.PictureBox();
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Today = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.Timer = new System.Windows.Forms.Timer(this.components);
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
            this.splitContainer1.Panel1.Controls.Add(this.ScheduleStudentProfile);
            this.splitContainer1.Panel1.Controls.Add(this.StudentProfileButton);
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
            this.splitContainer1.Size = new System.Drawing.Size(800, 618);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // ScheduleStudentProfile
            // 
            this.ScheduleStudentProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ScheduleStudentProfile.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScheduleStudentProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScheduleStudentProfile.Location = new System.Drawing.Point(0, 260);
            this.ScheduleStudentProfile.Name = "ScheduleStudentProfile";
            this.ScheduleStudentProfile.Size = new System.Drawing.Size(266, 63);
            this.ScheduleStudentProfile.TabIndex = 10;
            this.ScheduleStudentProfile.Text = "Расписание занятий";
            this.ScheduleStudentProfile.UseVisualStyleBackColor = false;
            this.ScheduleStudentProfile.Click += new System.EventHandler(this.ScheduleStudentProfile_Click);
            // 
            // StudentProfileButton
            // 
            this.StudentProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.StudentProfileButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentProfileButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentProfileButton.Location = new System.Drawing.Point(0, 210);
            this.StudentProfileButton.Name = "StudentProfileButton";
            this.StudentProfileButton.Size = new System.Drawing.Size(266, 55);
            this.StudentProfileButton.TabIndex = 9;
            this.StudentProfileButton.Text = "Личный кабинет";
            this.StudentProfileButton.UseVisualStyleBackColor = false;
            this.StudentProfileButton.Click += new System.EventHandler(this.StudentProfileButton_Click);
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
            this.MainWindowButton.Click += new System.EventHandler(this.MainWindowButton_Click);
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
            // MainWindowStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindowStudent";
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
        private System.Windows.Forms.PictureBox StudentProfileImage;
        private System.Windows.Forms.Button MainWindowButton;
        private System.Windows.Forms.Button StudentProfileButton;
        private System.Windows.Forms.Button ScheduleStudentProfile;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label Today;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label Time;
    }
}
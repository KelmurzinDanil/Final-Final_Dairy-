using System;
using System.Windows.Forms;

namespace studentDiary
{
    public partial class MainWindowAdmin : Form
    {
        public MainWindowAdmin()
        {
            MaximizeBox = false;
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(Ticker);
        }
        private void Ticker(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToShortTimeString();
        }

        private void AdminProfileButton_Click(object sender, EventArgs e)
        {
            AdministratorProfile administratorProfile = new AdministratorProfile();
            administratorProfile.Show();
        }

        private void ScheduleAdminProfile_Click(object sender, EventArgs e)
        {
            AdminSchedule adminSchedule = new AdminSchedule();
            adminSchedule.Show();
        }

        private void GroupList_Click(object sender, EventArgs e)
        {
            EditGroupForm editGroupForm = new EditGroupForm();
            editGroupForm.Show();
        }
    }
}

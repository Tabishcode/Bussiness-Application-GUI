using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.UI
{
    public partial class AdminMenu : Form
    {
        public AdminMenu(string UserName)
        {
            InitializeComponent();
            HeadLbl.Text = "Welcome, " + UserName;
        }
        private void AddUserControl(UserControl user)
        {
            user.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(user);
            user.BringToFront();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void viewRegisteredBtn_Click(object sender, EventArgs e)
        {
            ViewReg view = new ViewReg();
            AddUserControl(view);
        }

        private void manageTrainBtn_Click(object sender, EventArgs e)
        {
            ManageTrains manageTrains = new ManageTrains();
            AddUserControl(manageTrains);
        }

        private void ManageDriverBtn_Click(object sender, EventArgs e)
        {
            ManageDrivers drivers = new ManageDrivers();
            AddUserControl(drivers);
        }

        private void RegisterTrainBtn_Click(object sender, EventArgs e)
        {
            RegTrains regTrains = new RegTrains();
            AddUserControl(regTrains);
        }

        private void UnRegisterTrainBtn_Click(object sender, EventArgs e)
        {
            UnRegTrain train = new UnRegTrain();
            AddUserControl(train);
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

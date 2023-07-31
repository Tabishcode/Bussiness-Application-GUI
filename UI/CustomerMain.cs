using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.BL;
using TMS.DL;   
namespace TMS.UI
{
    public partial class CustomerMain : Form
    {
        public CustomerMain(string UserName)
        {
            InitializeComponent();
            HeadLbl.Text = "Welcome, " + UserName;
        }
        private void AddUserControl(UserControl user)
        {
            user.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(user);
            user.BringToFront();

        }

        private void manageTrainBtn_Click(object sender, EventArgs e)
        {
            ViewReg view = new ViewReg();
            AddUserControl(view);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            BuyTicket buy = new BuyTicket();
            AddUserControl(buy);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            PrintTicket ticket = new PrintTicket();
            AddUserControl(ticket);
        }

        private void cancelTicketBtn_Click(object sender, EventArgs e)
        {
            CancelTicket ticket = new CancelTicket();
            AddUserControl(ticket);
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

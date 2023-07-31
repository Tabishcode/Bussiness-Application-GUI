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
    public partial class CancelTicket : UserControl
    {
        public CancelTicket()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Customer customer = CustomerDL.isValidCustomerName(nameBx.Text);
            if (customer != null)
            {
                wrongLbl.Visible = false;
                existLbl.Visible = true;
                MessageBox.Show("Your Ticket has been cancelled and amount refunded to your account");
                nameBx.Text = string.Empty;
                CustomerDL.CustomerList.Remove(customer);
                CustomerDL.StoreCustomerDetailAfterUpdate();
            }
            else
            {
               
                wrongLbl.Visible = true;
                existLbl.Visible = false;
            }

        }

        private void CancelTicket_Load(object sender, EventArgs e)
        {

        }
    }
}
